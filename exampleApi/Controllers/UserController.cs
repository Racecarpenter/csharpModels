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
			
		}
		// GET: /<controller>/
        [HttpGet]
        public ActionResult Add()
        {
            User person = new User { Name = "Item1" };
			_context.Users.Add(person);
			_context.SaveChanges();
			return Json(person);

		}
    }
}
