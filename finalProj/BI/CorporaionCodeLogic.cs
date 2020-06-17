using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BL
{
    public static class CorporaionCodeLogic
    {
        static RavKavApplicationEntities db = new RavKavApplicationEntities();
        // ממינים את טבלת C לפי קוד שיתוף
        public static List<IGrouping<int, area>> sortByCorporaionCode()
        {
            return  db.areas.GroupBy(are => are.corporation_code).ToList();
            
        }
        //get CorporaionCode list of user

        public static List<travel> GetTravelsByUser(string userId)
        {
            List<users_travels> userTravels = db.users_travels.Where(tu => tu.userId == userId).ToList();
            return db.travels.Where(travel =>
              userTravels.FirstOrDefault(ut => travel.travelId == ut.travelId) != null
            ).ToList();
        }
        // בודקים איזה קוד שיתוף יש לו הכי הרבה אזורים משותפים(אם אין אזור אז טבעת במקום) לנסיעות שערך באותו יום(אם יש כמה באותו מספר השוואות אז את ההכי זול)
        public static Dictionary<int, int> FuncCode(List<area> areas)
        {
            Dictionary<int,int> SaveCode = new Dictionary<int, int>();
            foreach (var code in sortByCorporaionCode())
            {
                foreach (var item in code)
                {

                    var result = areas.Where(x => x.ring_or_area == item.ring_or_area);
                    SaveCode.Add(code.Key, result.Count());

                }
            }

            return SaveCode;
        }

      



        ////chek into many codes
        //        public static List<int>  FuncBestCode(List<travel> travels)
        //        {
        //            int bestCode = 0;
        //            int maxCode = 0;
        //            var listCode = travels.GroupBy(x => x.corporateCode);
        //            List<int> codes = new List<int>();
        //            foreach (var item in listCode)
        //            {
        //                int count = item.Count();
        //                if (count > maxCode)
        //                {
        //                    maxCode = count;
        //                    bestCode = item.Key;
        //                }
        //                else
        //                {
        //                    if (count == maxCode)
        //                    {
        //                        codes.Add(item.Key);

        //                    }
        //                }
        //            }

        //            foreach (var item in codes)
        //            { int max = codes.Max();
        //                if (item < max)
        //                    codes.Remove(item);
        //            }
        //            return codes;
        //        }

    }
}
