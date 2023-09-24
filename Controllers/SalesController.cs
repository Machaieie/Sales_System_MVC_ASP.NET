using Aplicacao_de_vendas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Aplicacao_de_vendas.Controllers
{
    public class SalesController : Controller
    {
        
        public IActionResult Sales()
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
