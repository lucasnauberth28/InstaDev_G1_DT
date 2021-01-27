using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_G1_DT.Controllers
{
    [Route ("PageRegister")]
    public class PageRegisterController:Controller
    {
        PageRegister pageRegisterModels = new PageRegister();

        [Route ("Form")]
        public IActionResult Index(){
            ViewBag.Registers = pageRegisterModels.ReadAllItems();
            return View();
        }

        [Route ("Registration")]
        public IActionResult Register(IFormCollection registrationForm){ // o IActionResult e o IFormCollection fazem parte de bibliotecas do AspNetCore
            PageRegister newUser = new PageRegister();
            newUser.Email = registrationForm["Email"];
            newUser.CompleteName = registrationForm["CompleteName"];
            newUser.NickName = registrationForm["NickName"];
            newUser.Password = registrationForm["Password"];

            pageRegisterModels.Create(newUser);
            ViewBag.Registers = pageRegisterModels.ReadAllItems();

            return LocalRedirect("~/Form/Registration");
        }
    }
}