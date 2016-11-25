using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuidAsAService.Models
{
    public class GuidService
    {
       public Guid createGuid()
        {
            Guid result = Guid.NewGuid();
            
            return result;
        }
    }
}