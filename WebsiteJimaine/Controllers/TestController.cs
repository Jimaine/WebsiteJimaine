﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebsiteJimaine.Controllers
{
    /// <summary>
    /// Test Api to play with
    /// </summary>
    public class TestController : ApiController
    {
        /// <summary>
        /// Override Default Route Test with more Parameters
        /// With get and post
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        [Route("api/Test/GetNewRoute/{userId:int}/{age:int}")]
        [HttpGet, HttpPost]
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

        /// <summary>
        /// Override Default Route Test with more Parameters
        /// With get
        /// </summary>
        /// <returns></returns>
        [Route("api/Test/GetNewRoute")]
        [HttpGet] // [HttpPost]
        public IEnumerable<string> GetNewRoute()
        {
            // Select
            return new string[] { "Lorem", "Ipsum", "Dolor", "Sit", "Amet" };
        }

        /// <summary>
        /// GET api/Test 
        /// cRud Read
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            // Select
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// GET api/Test/5
        /// cRud Read
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return $"value {id}";
        }

        /// <summary>
        /// POST api/Test
        /// Crud Create
        /// Value in Body with ssl. Other than Get. Post > Get 
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
            _ = value.Trim();
        }

        /// <summary>
        /// PUT api/Test/5
        /// crUd Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
            _ = value.ToCharArray()[id];
        }

        /// <summary>
        /// DELETE api/Test/5
        /// cruD Delete
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            _ = id / id;
        }
    }
}