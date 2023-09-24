using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_de_vendas.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
