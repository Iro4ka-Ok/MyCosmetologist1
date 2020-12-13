using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCosmetologist.Web.Models;

namespace MyCosmetologist.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (string.IsNullOrEmpty(person.Name))
            {
                ModelState.AddModelError("Name", "Некоректне ім'я");
            }
            else if (person.Name.Length > 5)
            {
                ModelState.AddModelError("Name", "Недопустима довжина стрічки");
            }
            if (ModelState.IsValid)
            {
                return Content($"{person.Name} - {person.Email}");
            }
            if (ModelState.IsValid)
                return Content($"{person.Name} - {person.Email}");
            else
                return View(person);
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult CheckEmail(string email)
        {
            if (email == "admin@gmail.com" || email == "aaa@gmail.com")
                return Json(false);
            return Json(true);
        }
    }
}
