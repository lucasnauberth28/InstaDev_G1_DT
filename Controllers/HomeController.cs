using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;

namespace InstaDev_G1_DT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        User userModel = new User();
        [TempData]

        public string Mensagem { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logando(IFormCollection form)
        {
            // Lemos todos os arquivos do CSV
            List<string> csv = userModel.ReadAllLinesCSV("Database/register.csv");

            // Verificamos se as informações passadas existe na lista de string
            var logado =
             csv.Find(
            x =>
            x.Split(";")[1] == form["Email"] &&
            x.Split(";")[4] == form["Senha"]
             );


            // Redirecionamos o usuário logado caso encontrado
            if (logado != null)
            {
                HttpContext.Session.SetString("E-mail", logado.Split(";")[1]);
                return LocalRedirect("~/User/Register");
            }

            Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/Feed");

        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/");
        }
    }
}
