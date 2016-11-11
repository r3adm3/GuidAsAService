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
        public Guid Create()
        {
            Guid myGuid;
            myGuid = myGuid.createGuid();
            return myGuid;
        }
    }
}
