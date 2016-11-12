using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using GuidAsAService.Models;

namespace GuidAsAService.Controllers
{
    public class GuidController : ApiController
    {
        public string Create()
        {
            GuidService myObj = new GuidService();

            string result = myObj.createGuid();

            return result;
        }
    }
}
