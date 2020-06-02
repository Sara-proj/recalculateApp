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
        { //if(getUser(newUser.id)!=null)
          ///choose another password
            //disable register with an existing password
            try { 
            MailMessage email = new MailMessage("emuna.win@gmail.com", "rachel170370@gmail.com");
            email.Subject = "Dear Racheli! this is your reciption ";
            email.IsBodyHtml = true;
            email.Body = "<html><head>< meta charset = 'utf-8' />  < title ></ title ></ head ><body dir='rtl'>hello world Hashem help me please</body></html>";
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
           SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("emuna.win@gmail.com", "281299hy");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(email);
                return newUser;
            }
            catch(Exception ex)
            {


                newUser.firstName = ex.Message;
                return newUser;
            }
        }
        public static void SendEmailMesg(User user)
        {
            string email = user.email;
            try
            {


            }
            catch (Exception)
            {

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
             User existingUser = db.Users.FirstOrDefault(user=>user.firstName==userForConfirm.firstName );
            //send email message with confirm code
            SendEmailMesg(userForConfirm);

        }
        //get user by password 
        private static User getUser(string password)
        {
            User existingUser = db.Users.FirstOrDefault(user => user.id == password);
            return existingUser;
        }

    }
}
