
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL
{
    //using System.Net.Mail;
    static public class UserLogic
    {
        private static RavKavApplicationEntities db = new RavKavApplicationEntities();
        public static bool Register(User newUser)
        {
            //if(getUser(newUser.id)!=null)
            ///choose another password
            //disable register with an existing password
            db.Users.Add(newUser);
            db.SaveChanges();
            return true;
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
        //update user password
        public static void UpdatePassword(User userForConfirm, string passNew)
        {
            try
            {
                User UpdateUser = db.Users.FirstOrDefault(user => user.id == userForConfirm.id);
                if (UpdateUser != null)
                {
                    db.Users.FirstOrDefault(user => user.id == userForConfirm.id &&
                    user.firstName == userForConfirm.firstName).id = passNew;

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {

            }
        }
        //update all details , get: new user updated
        public static void UpdateDetails(User userForConfirm)
        {
            try
            {
                if (userForConfirm != null)
                {
                    db.Users.FirstOrDefault(user => user.id == userForConfirm.id).firstName = userForConfirm.firstName;
                    db.Users.FirstOrDefault(user => user.id == userForConfirm.id).lastName = userForConfirm.lastName;
                    db.Users.FirstOrDefault(user => user.id == userForConfirm.id).phone = userForConfirm.phone;
                }
                db.SaveChanges();
            }
            catch (Exception)
            {

            }

        }
        //update mail
        public static void UpdateEmail(User userForConfirm)
        {
            try
            {
                db.Users.FirstOrDefault(user => user.id == userForConfirm.id).email = userForConfirm.email;
                db.SaveChanges();
            }
            catch (Exception)
            {

            }
        }

        public static void ResetPassword(User userForConfirm)
        {
            //get user by user name
            User existingUser = db.Users.FirstOrDefault(user => user.firstName == userForConfirm.firstName);
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
