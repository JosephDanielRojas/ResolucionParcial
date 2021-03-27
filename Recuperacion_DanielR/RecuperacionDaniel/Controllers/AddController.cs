using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RecuperacionDaniel.Controllers
{
    public class AddController : ApiController
    {
        [HttpGet]
        [HttpPost]
        public int Sumar(int a, int b)
        {
            return a + b;
        }
        [HttpPost]
        public int Sumar2([FromBody]int a, [FromBody]int b)
        {
            return a + b;
        }
    }
}
