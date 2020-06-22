using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class TravelUserDTO
    {
        public int id { get; set; }
        public string userId { get; set; }
        public int travelId { get; set; }
        public DateTime travelDate { get; set; }
       
       
    }
}
