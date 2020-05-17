using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DAL;
using System.Web.Http;
using BL;
namespace finalProj.Controllers
{
     [RoutePrefix("users")]
    public class UsersController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public User Register(User newUser)
        {
            return UserLogic.Register(newUser);
        }
        //public User Update()
        //{
        //    return UserLogic.Update():
        //}
        [HttpGet]
        [Route("login")]
        public User Login(User existingUser)
        {
            return UserLogic.Login(existingUser.firstName,existingUser.id);
        }
    }
}
