using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_de_vendas.Controllers
{
    public class StockController : Controller
    {

        public IActionResult Stock()
        {
            return View();
        }

        public IActionResult NovoStock()
        {
            return View();
        }



    }
}
