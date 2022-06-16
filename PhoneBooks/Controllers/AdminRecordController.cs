
using BusinessLayer;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBooks.Controllers
{
    public class AdminRecordController : Controller
    {
        // GET: AdminRecord
        RecordsManager recordsManager = new RecordsManager(new EfRecordDal());
        public ActionResult Index()
        {
            var recordValues = recordsManager.GetList();
            return View(recordValues);
        }
        [HttpGet]
        public ActionResult AddRecord() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddRecord(Records p)
        {
            RecordsValidator recordsValidator = new RecordsValidator();
            ValidationResult results = recordsValidator.Validate(p);
            if (results.IsValid)
            {
                recordsManager.RecordsAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        [HttpGet]
        public ActionResult EditRecord(int id)
        {

            var recordsValue = recordsManager.GetByIdRecords(id);
            return View(recordsValue);
        }
        [HttpPost]
        public ActionResult EditRecord(Records p)
        {
            recordsManager.RecordsUpdate(p);
            RecordsValidator recordsValidator = new RecordsValidator();
            ValidationResult results = recordsValidator.Validate(p);
            if (results.IsValid)
            {
                recordsManager.RecordsAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return RedirectToAction("Index");
            }
        }

      
        public ActionResult DeleteRecord(int id)
        {
            var recordValue = recordsManager.GetByIdRecords(id);
            recordsManager.RecordsDelete(recordValue);
            return RedirectToAction("Index");
        }

    }
}