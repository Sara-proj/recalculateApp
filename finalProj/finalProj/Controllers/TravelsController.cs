using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BL;

namespace finalProj.Controllers
{
    [RoutePrefix("travels")]
    public class TravelsController : ApiController
    {
        [HttpGet]
        [Route("generate")]
        public void GenerateTravels()
        {
            TravelLogic.GenerateTravels();
        }
    }
}
