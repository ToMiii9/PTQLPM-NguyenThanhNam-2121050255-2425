using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MVCMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            string strOutput = "Xin chao" + employee.EmployeeId + "- " + employee.Age;
            ViewBag.employee = strOutput;
            return View();
        }
    }
}
