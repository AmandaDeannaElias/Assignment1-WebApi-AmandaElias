using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_WebApi_AmandaElias.Controllers
{
    public class GreetingController : ApiController
    {
        // POST api/Greeting
        //typed this into command prompt using the curl -d "" method and it worked
        string e = "hello" + " " + "world!";
        public IEnumerable<string> Post()
        {
            return new string[] { e };
        }
        
        //GET /Greeting/{id}
        string a = "Greetings" + " " + "to" + " ";
        string b = " " + "people!";
        public IEnumerable<string> Get(int id)
        {

            return new string[] { a + id + b };
        }
    }
}
