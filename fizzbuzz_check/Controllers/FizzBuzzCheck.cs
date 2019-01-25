using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Authenticators;



namespace fizzbuzz_check.Controllers
{
    [Route("api/check")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "FizzBuzzCheck" };
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] int digitFromBody)
        {
            ProxyClass proxyObject = new ProxyClass("login", "password");
            var cachedData = proxyObject.GetData(digitFromBody);
            return cachedData.ToString();
        }
    }
}

