using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
   public  class UserDTO
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public System.DateTime birthDate { get; set; }
        public string profile { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string ravKavCode { get; set; }
        
    }
}
