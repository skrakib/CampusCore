using Microsoft.AspNetCore.Mvc;

namespace CampusCore.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
