using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreDemo.Controllers
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

        public IActionResult Test()
        {
            //test sağ tıklayarak bu methodun viewına gidilebilir.eğer yoksa bu method için view oluşturalablir
            //oluşturulan view razorlı veya razorsız olablir.
            //biliyorsunki razor sayesinde c# kodları kullanılablir
            //view oluşturulurken oluşturulan viewa layout atıyablirsin
            //layout sabit bir şablondur.yani hazır bir html sayfası sadece biz oluşturduğumuz viewları bu layoutlara ekleyebliriz
            return View();
        }
    }
}