using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL.Conversions
{
    class TravelUsersConvert
    {
        public static users_travels ConvertDTOtoDAL(TravelUserDTO travel)
        {
            return new users_travels()
            {
                id = travel.id,
                travelDate = travel.travelDate,
                travelId = travel.travelId,
                userId = travel.userId
            };
        }
        public static TravelUserDTO ConvertDalToDto(users_travels travel)
        {
            return new TravelUserDTO()
            {
                id = travel.id,
                travelDate = travel.travelDate,
                travelId = travel.travelId,
                userId = travel.userId
            };
        }
    }
}
