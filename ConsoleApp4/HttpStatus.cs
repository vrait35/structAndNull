using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public enum HttpStatus:long
    {
        BadRequest=400,
        NotAuthorized=401,
        NotFound=404,
        InternalServerError=500
    }
}
