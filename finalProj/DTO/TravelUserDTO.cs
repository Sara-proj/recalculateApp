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
<<<<<<< HEAD
       
       
=======
        public users_travels ConvertDTOtoDAL()
        {
           return new users_travels()
            {
                id = id,
                travelDate =travelDate,
                travelId = travelId,
                userId = userId
            };
        }
>>>>>>> 8b47b179e0d855f390dbbd485fdd50bf659d5551
    }
}
