using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class CorporaionCodeLogic
    {
        static RavKavApplicationEntities db = new RavKavApplicationEntities();
        // ממינים את טבלת C לפי קוד שיתוף
        public static List<area> sortByCorporaionCode()
        {
            return db.areas.OrderBy(are => are.corporation_code).ToList();
        }
        //get CorporaionCode list of user

        public static List<travel> GetTravelsByUser(string userId)
        {
            List<users_travels> users_Travels = db.users_travels.Where(tu => tu.userId == userId).ToList();
            return db.travels.Where(travel =>
              users_Travels.FirstOrDefault(ut => travel.travelId == ut.travelId)!=null
            ).ToList();
        }
        // בודקים איזה קוד שיתוף יש לו הכי הרבה אזורים משותפים(אם אין אזור אז טבעת במקום) לנסיעות שערך באותו יום(אם יש כמה באותו מספר השוואות אז את ההכי זול)


    }
}
