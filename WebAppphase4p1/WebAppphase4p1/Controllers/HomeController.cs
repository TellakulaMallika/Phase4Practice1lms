using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppphase4p1.Models;

namespace WebAppphase4p1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        List<User> userlist = new List<User>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            userlist.Add(new Models.User { Username = "Ruchi", Password = "ruchi@123" });
            userlist.Add(new Models.User { Username = "Suji", Password = "suji@123" });
            userlist.Add(new Models.User { Username = "Sai", Password = "sai@123" });
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User u)
        {
            var found = userlist.Find(f => ((f.Username == u.Username) && (f.Password == u.Password)));

            if (found != null)
            {
                return RedirectToAction("Dashboard", "Home");
            }

            else
            {
                return View();
            }
        }


        public IActionResult Dashboard()
        {

            return View();
        }
        
    }
}
