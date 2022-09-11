using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
