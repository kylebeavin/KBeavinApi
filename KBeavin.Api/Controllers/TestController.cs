using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KBeavin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Test> Get()
        {
            List<Test> test = new List<Test>();
            test.Add(new Test { Name = "Kyle", FavNumber = 3, Date = new DateTime(1986, 4, 11) });
            test.Add(new Test { Name = "Sheila", FavNumber = 7, Date = new DateTime(1976, 7, 8) });
            test.Add(new Test { Name = "Ashley", FavNumber = 14, Date = new DateTime(2002, 7, 3) });
            test.Add(new Test { Name = "Carter", FavNumber = 1, Date = new DateTime(2016, 3, 1) });
            test.Add(new Test { Name = "Moe", FavNumber = 12, Date = new DateTime(2009, 10, 27) });

            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new Test
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();

            return test;
        }
    }
}
