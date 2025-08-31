using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TurkcellDependencyInjection.Helpers;
using TurkcellDependencyInjection.Models;

namespace TurkcellDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHelper _helper;
        //Helper _helper2;

        public HomeController(ILogger<HomeController> logger, IHelper helper/*,Helper helper2*/)
        {
            _helper = helper;
            //_helper2 = helper2;
            _logger = logger;
        }

        public IActionResult Index([FromServices]IHelper helper2)
        {
            var text = "asp";
            var upperText = _helper.Upper(text);

            var status = _helper.Equals(helper2);//nesnein tek nesne olduðunu kontrol


            //Helper h = new Helper();

            return View();
        }

        public IActionResult Privacy()
        {
            //var text = "Mesaj";
            //var upperText=_helper2.Upper(text);


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
