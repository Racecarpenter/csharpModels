using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using exampleApi.Models;
using System.Linq;

namespace exampleApi.Controllers
{
	[Route("api/[controller]")]
    public class UserController : Controller
    {
		private readonly UserContext _context;

        public UserController(UserContext context)
		{
            
			_context = context;

            if(_context.Users.Count() < 1)
            {
				User person = new User { Name = "Item1" };
				_context.Users.Add(person);
                _context.Users.Add(new User { Name = "yiggy" });
				_context.SaveChanges(); 
            }
			
		}
		// GET: /<controller>/
        [HttpGet]
        public ActionResult GetAll()
        {

            return Json(_context.Users);

		}
        // get id
        [HttpGet("{id}")]
        public ActionResult GetOne(long id)
        {
            return Json(_context.Users.Where(user => user.Id == id).ToList()[0]);  
        }
    }
}
