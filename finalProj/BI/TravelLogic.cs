using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public static class TravelLogic
    {
        private static RavKavApplicationEntities db = new RavKavApplicationEntities();
        public static void GenerateTravels()
        {
            UserDTO user1 =  new UserDTO() { id="315136218"};
            UserDTO user2 = new UserDTO() { id = "315136226" };
            for (int i=0;i<200;i++)
            {
                Random r = new Random();
                int lineBus = r.Next(1, 200);
                int year = r.Next(2000, DateTime.Now.Year);
                int month = r.Next(1, 12);
                int days = DateTime.DaysInMonth(year, month);
                DateTime date = new DateTime(year, month, days);
                TravelUserDTO travelUser = new TravelUserDTO() { userId = (i < 100) ? user1.id : user2.id, travelId = 5, travelDate = date };
                db.users_travels.Add(travelUser.ConvertDTOtoDAL());
            }
            db.SaveChanges();
        }
    }
}
