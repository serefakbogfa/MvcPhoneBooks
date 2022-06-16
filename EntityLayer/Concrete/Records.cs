using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Records
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }
     
        public string SurName { get; set; }
      
        public string PhoneNumber { get; set; }
    }
}
