using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_G1_DT.Controllers
{
    
    [Route("Login")]
    public class LoginController : Controller
    {
        [Route("Logar")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Logando")]
        public IActionResult Logar(IFormCollection form)
        {
            return LocalRedirect("~/Login/Logar");
        }
    }
}