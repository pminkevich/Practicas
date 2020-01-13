using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        [Route("api/test1")]
        public string Test()
        {
            return "response1";
        }


        [Route("api/test2")]
        public string Test1()
        {
            string out1 = Request.Form["formvalue1"];
            string out2 = Request.Form["formvalue2"];
            string out3 = Request.Headers["headervalue"];
            return out1 + " " + out2 + " " + out3;
        }
    }
}
