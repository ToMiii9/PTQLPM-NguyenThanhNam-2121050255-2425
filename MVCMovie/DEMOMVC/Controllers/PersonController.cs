using Microsoft.AspNetCore.Mvc;
using MVCMovie.Models;

namespace MVCMovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chao" + ps.PersonId + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }
}
