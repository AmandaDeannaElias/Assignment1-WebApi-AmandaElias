using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_WebApi_AmandaElias.Controllers
{
    public class SquareController : ApiController
    {//GET api/Square/{id}
            public IEnumerable<int> Get(int id)
            {
                return new int[] { id * id };
            }
        }
    }

    

