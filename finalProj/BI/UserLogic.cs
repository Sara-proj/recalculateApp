using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    static public class UserLogic
    {
        private static RavKavApplicationEntities db = new RavKavApplicationEntities();
        public static User Register(User newUser)
        {
            //SendEmailMesg(newUser, "Hello " + newUser.firstName,"we are happy to join you our team");
            return newUser ;
        }
        public static void SendEmailMesg(User user, string subject, string msg)
        {
            string ad = user.email;
            try
            {
                MailMessage email = new MailMessage("emuna.win@gmail.com", ad);
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
        /*login 
         parameters: username and password
         ansure password is correct . 
         If it is- the function returns the user object, otherwise-null */
        public static User Login(string userName, string userPassword)
        {
            User existingUser = new User();
            existingUser = getUser(userPassword);
            if (existingUser != null && existingUser.firstName == userName)
                return existingUser;
            return null;
        }
        /*reset password
         confirm email address- email message with confirm code is sent to user's email address.
         The user has to enter that code within 15 minutes.
         */
        public static void ResetPassword(User userForConfirm)
        {
            //get user by user name
            User existingUser = db.Users.FirstOrDefault(user => user.firstName == userForConfirm.firstName);
            //send email message with confirm code
            SendEmailMesg(userForConfirm, "", "");

        }
        //get user by password 
        //The function returns null if the password was'nt found or if details are incorrect.
        private static User getUser(string password)
        {
            User existingUser = db.Users.FirstOrDefault(user => user.id == password);
            return existingUser;
        }

    }
}
