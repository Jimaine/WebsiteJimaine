using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebsiteJimaine.Controllers
{
    public class TestController : ApiController
    {
        // Override Default Rout
        [Route("api/Test/GetNewRoute/{userId:int}/{age:int}")]
        [HttpGet] // [HttpPost]
        public IEnumerable<string> GetNewRoute(int userId, int age)
        {
            // Select
            var returnValue = new string[userId];

            for(int i = 0; i < returnValue.Length; i++)
            {
                returnValue[i] = age.ToString();
            }

            return returnValue;
        }

        // Override Default Rout
        [Route("api/Test/GetNewRoute")]
        [HttpGet] // [HttpPost]
        public IEnumerable<string> GetNewRoute()
        {
            // Select
            return new string[] { "Lorem", "Ipsum", "Dolor", "Sit", "Amet" };
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            // Select
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            // Create
            // in Body with ssl. Other than Get. Post > Get 
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
            // Update
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            // Delete
        }
    }
}