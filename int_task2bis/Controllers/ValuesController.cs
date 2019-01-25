using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace int_task2bis.Controllers
{
    [Route("api/fizzbuzz")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Produces("application/json")]
        public string Get(int digit)
        {
            int temp = digit;
            return FizzBuzz(digit);
        }

        public static string FizzBuzz(int digit)
        {

            if (digit % 2 == 0 && digit % 3 == 0)
            {
                return "FizzBuzz";
            }
            else if (digit % 2 == 0 && digit % 3 != 0)
            {
                return "Fizz";
            }
            else if (digit % 2 != 0 && digit % 3 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "*can't devide it by 2 or 3*";
            }
        }
    }
}
