using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_de_vendas.Controllers
{
    public class ProductsController : Controller
    {
      
      
        public IActionResult Products()
        {
            return View();
        }

       
    }
}
