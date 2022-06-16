using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRecordsService
    {
        List<Records> GetList();
        Records GetByIdRecords(int id); // Dal dan gelen T nesnesini karsilar
        void RecordsAdd(Records records);
        void RecordsDelete(Records records);
        void RecordsUpdate(Records records);
        Records GetByNameRecords(string name);
    }
}
