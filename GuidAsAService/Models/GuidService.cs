using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuidAsAService.Models
{
    public class GuidService
    {
       public string createGuid()
        {
            string result = Guid.NewGuid().ToString();
            
            return result;
        }
    }
}