using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.Conversions
{
    class AreaConvert
    {
        public static area ConvertDTOtoDAL(AreaDTO are)
        {
            return new area()
            {
                id = are.id,
                corporation_code = are.corporation_code,
                ring_or_area = are.ring_or_area,

            };
        }
        public static AreaDTO ConvertDalToDto(area are)
        {
            return new AreaDTO()
            {
                id = are.id,
                corporation_code = are.corporation_code,
                ring_or_area = are.ring_or_area,

            };
        }
    }
}
