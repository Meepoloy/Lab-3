using Lab3.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            HttpContext.Session.SetString("inputNum", Request.Form["inputNum"]);
            return View();
        }

        [HttpGet]
        public IActionResult CreateStudent() => View();

        [HttpPost]
        public IActionResult DisplayStudent(Student model)
        {
            // you will complete this
            return View(model);
        }
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
