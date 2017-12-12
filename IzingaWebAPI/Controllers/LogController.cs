using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IzingaWebAPI.Models;
using IzingaWebAPI.DAL;

namespace IzingaWebAPI.Controllers
{
    public class LogController : ApiController
    {
        public LogRepository logRep = new LogRepository();

        [HttpGet]
        [ActionName("GetLog")]
        public List<Event> GetAllFromLog()
        {
            return logRep.GetDataFromLogFile();
        }
    }
}
