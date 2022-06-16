using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RecordsManager : IRecordsService
    {
        IRecordsDal _recordsDal;
        public RecordsManager(IRecordsDal recordsDal)
        {
            _recordsDal = recordsDal;
        }
        

        public Records GetByIdRecords(int id)
        {
            return _recordsDal.Get(p => p.Id == id);
        }

        public Records GetByNameRecords(string name)
        {
            return _recordsDal.Get(p => p.Name == name);
        }

        public List<Records> GetList()
        {
            return _recordsDal.GetAll();
        }

        public void RecordsAdd(Records records)
        {
           _recordsDal.Add(records);
        }

        public void RecordsDelete(Records records)
        {
            _recordsDal.Delete(records);
        }

        public void RecordsUpdate(Records records)
        {
           _recordsDal.Update(records);
        }
    }
}
