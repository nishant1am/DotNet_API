using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Enter the /integer after values in URL" };
        }
       

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id % 3 == 0 && id % 5 == 0)
            {
                return "GN";
            } 
            else if (id % 3 == 0)
            {
                return "G";

            }
            else if (id % 5 == 0)
            {
                return "N";
            } 
            else
            {
                string myString = id.ToString();
                return myString;
            }
             
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost("{value}")]
        public int Pi(int value)
        {
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
