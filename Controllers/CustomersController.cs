using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_de_vendas.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Customers()
        {
            return View();
        }
    }
}
