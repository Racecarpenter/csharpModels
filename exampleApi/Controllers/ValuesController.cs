using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace exampleApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            
            return Json("hello");
        }

        [HttpPost("create")]
        public ActionResult Create([FromBody]Person person)
        {
            
            if(person.age>=13){
                return Json(person.dog);
            }else{
                return Json(false);
            }

        }

		[HttpPost("getdog")]
		public ActionResult GetDog([FromBody]Person person)
		{
            return Json(person.dog);
		}
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string country { get; set; }
        public Dog dog { get; set; }
    }
    public interface Dog
    {
         string Name { get; set; }
         int Age { get; set; }
    }
}
