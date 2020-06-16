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
        namespace BL
    {
        static public class UserLogic
        {
            private static RavKavApplicationEntities db = new RavKavApplicationEntities();
            public static User Register(User newUser)
            { //if(getUser(newUser.id)!=null)
              ///choose another password
                //disable register with an existing password

            }
            public static void SendEmailMesg(User user, string subject, string msg)
            {
                string add = user.email;
                try
                {
                    MailMessage email = new MailMessage("emuna.win@gmail.com", add);
                    email.Subject = subject;
                    email.IsBodyHtml = false;
                    email.Body = msg;
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("emuna.win@gmail.com", "281299hy");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(email);
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            public static User Login(string userName, string userPassword)
            {
                User existingUser = new User();
                existingUser = getUser(userPassword);
                if (existingUser != null && existingUser.firstName == userName)
                    return existingUser;
                return null;

            }
            public static void ResetPassword(User userForConfirm)
            {
                //get user by user name
                User existingUser = db.Users.FirstOrDefault(user => user.firstName == userForConfirm.firstName);
                //send email message with confirm code
                SendEmailMesg(userForConfirm, "", "");

            }
            //get user by password 
            private static User getUser(string password)
            {
                User existingUser = db.Users.FirstOrDefault(user => user.id == password);
                return existingUser;
            }

        }
    }
    public static void SortByDay()
        {
            var x = db.users_travels.GroupBy(y => y.travelDate);
            foreach (var item in x)
            {
                List<travel> travelsByDate = new List<travel>();
                foreach (var travel1 in item)
                {
                    travelsByDate.Add(db.travels.FirstOrDefault(z => z.travelId == travel1.travelId));
                    CalcContract(travelsByDate);
                }
            }
          
            //Select(g => new Address
            //{
            //    AddressId = g.Key,
            //    NodeIds = g.ToList()
            //}
        }
        //get CorporaionCode list of user

        public static List<travel> GetTravelsByUser(string userId)
        {
            List<users_travels> userTravels = db.users_travels.Where(tu => tu.userId == userId).ToList();
            return db.travels.Where(travel =>
              userTravels.FirstOrDefault(ut => travel.travelId == ut.travelId)!=null
            ).ToList();
        }
        // בודקים איזה קוד שיתוף יש לו הכי הרבה אזורים משותפים(אם אין אזור אז טבעת במקום) לנסיעות שערך באותו יום(אם יש כמה באותו מספר השוואות אז את ההכי זול)


    }
}
