using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
	public class MovieController : Controller
	{
		//	public IActionResult Index()
		//	{

		//		return View();

		//	
		//	}
		public IActionResult Index()
		{
			return View("MovieIndex");
		}
        //public string Welcome()
        //{


        //    return "sdvf";
        //}
        public IActionResult Welcome(int id =0 , string name = "testing")
        {
            // Pass the parameters to the view using ViewBag
            ViewBag.Name = name;
            ViewBag.ID = id;

            return View("Welcome");
        }
    }
}
