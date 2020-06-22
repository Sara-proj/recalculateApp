//using System;
//using System.Collections.Generic;
//using System.Linq;
//using DAL;
//using System.Text;
//using System.Threading.Tasks;

//namespace BL
//{
//    public static class CorporaionCodeLogic
//    {
//        static RavKavApplicationEntities db = new RavKavApplicationEntities();
//        // ממינים את טבלת C לפי קוד שיתוף
//        //public static List<area> sortByCorporaionCode()
//        //{
//        //    return db.areas.OrderBy(are => are.corporation_code).ToList();
//        //}

//        public static void GroupByDay(List<users_travels> travels)
//        {
//            List<IGrouping<DateTime, users_travels>> travelsList;
//            travelsList = travels.GroupBy(y => y.travelDate).ToList();
//            BuildAreasList(travelsList);
//        }
//        public static void GroupByMonth(List<users_travels> travels)
//        {
//            List<IGrouping<int, users_travels>> travelsList;
//            travelsList = travels.GroupBy(y => y.travelDate.Month).ToList();
//            BuildAreasList(travelsList);
//        }
//        public static void GroupByYear(List<users_travels> travels)
//        {
//            List<IGrouping<int, users_travels>> travelsList;
//            travelsList = travels.GroupBy(y => y.travelDate.Year).ToList();
//            BuildAreasList(travelsList);
//        }
//        //get all user-travels between given dates.
//        private static List<users_travels> GetTravelsInRange(List<users_travels> listTravels, DateTime startDate, DateTime endDate)
//        {
//            return listTravels.Where(d => d.travelDate < endDate).ToList();
//        }

//        //public static List<IGrouping<int, area>> sortByCorporaionCode()
//        //{
//        //    return db.areas.GroupBy(are => are.corporation_code).ToList();

//        //compare:
//        //each day in the  last 12 month
//        //last year-3 years 
//        //the current date in the last 5 years
       
//        public static void BuildAreasList(List<IGrouping<DateTime, users_travels>> travelsList)
//        {

//            foreach (var item in travelsList)
//            {
//                List<string> travelsByDate = new List<string>();
//                foreach (var travel1 in item)
//                {
//                    travel res = db.travels.FirstOrDefault(z => z.travelId == travel1.travelId);
//                    if (res.sourceArea != null)
//                        travelsByDate.Add(res.sourceArea);
//                    else
//                    {
//                        if (res.sourceRing != null)
//                            travelsByDate.Add(res.sourceRing);
//                    }
//                    if (res.destArea != null)
//                        travelsByDate.Add(res.destArea);
//                    else
//                    {
//                        if (res.sourceRing != null)
//                            travelsByDate.Add(res.destRing);
//                    }
//                    //CalcContract(travelsByDate);
//                }
//            }
//        }
        
//        //נסיעות של המשתמש הנוכחי
//        public static void byMonth(DateTime date)
//        {
//            int month = date.Month;
//        }
//        public static void CalcBestContracts()
//        {
//         User currentUser = new User();
//        DateTime now = DateTime.Today;
//            //calc yearly contracts in range of 3 years
//            List<users_travels> listTravels = GetTravelsByUser("315136218");
//            GetTravelsInRange(listTravels,now, new DateTime(now.Year + 3, 12, DateTime.DaysInMonth(now.Year + 3, 12)));

//        }
//        //get CorporaionCode list of user

//        public static List<users_travels> GetTravelsByUser(string userId)
//        {
//            return  db.users_travels.Where(tu => tu.userId == userId).ToList();
//            // db.travels.Where(travel =>
//            //  userTravels.FirstOrDefault(ut => travel.travelId == ut.travelId) != null
//            //).ToList();
//        }
//        // בודקים איזה קוד שיתוף יש לו הכי הרבה אזורים משותפים(אם אין אזור אז טבעת במקום) לנסיעות שערך באותו יום(אם יש כמה באותו מספר השוואות אז את ההכי זול)


//    }
//}
