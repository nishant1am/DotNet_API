using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
    }
    public class DemoController : ApiController
    {
        public string Get() { return "Welcome to Web API";
        }
        public List<string> Get(int Id)
        {
            return new List<string> {
                "Data1",
                "Data2"
            };
        }
    }

    public class ApiController
    {
    }
}