using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.Conversions
{
    class UserConvert
    {
        public static User ConvertDTOtoDAL(UserDTO user)
        {
            return new User()
            {
                id =user.id,
                firstName = user.firstName,
                lastName = user.lastName,
                birthDate = user.birthDate,
                profile = user.profile,
                email = user.email,
                phone = user.phone,
                ravKavCode = user.ravKavCode,

            };
        }
        public static UserDTO ConvertDALtoDTO(User user)
        {
            return new UserDTO()
            {
                id = user.id,
                firstName = user.firstName,
                lastName = user.lastName,
                birthDate = user.birthDate,
                profile = user.profile,
                email = user.email,
                phone = user.phone,
                ravKavCode = user.ravKavCode,

            };
        }
    }
}
