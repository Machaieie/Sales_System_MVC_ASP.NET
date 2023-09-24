using Aplicacao_de_vendas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aplicacao_de_vendas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

   

        public IActionResult wallet()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult Registrations()
        {
            return View();
        }
        

        public IActionResult Notifications()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}