using System.Collections.Generic;
using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_G1_DT.Controllers
{

    [Route("Login")]
    public class LoginController : Controller
    {
        User userModel = new User();
        [TempData]

        public string Mensagem { get; set; }
        
        [Route("Logar")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Logando")]

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
            return LocalRedirect("~/");

        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/");
        }
    }
}