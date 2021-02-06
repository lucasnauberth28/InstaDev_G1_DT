using System;
using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_G1_DT.Controllers
{
    // localhost:5001/User
    [Route ("User")]
    public class UserController:Controller
    {
        User userModels = new User();

        // localhost:5001/User/Register
        [Route ("Register")]
        public IActionResult Register(){
            ViewBag.Users = userModels.ReadAllItems();
            return View();
        }

        // localhost:5001/User/New
        [Route ("New")]
        public IActionResult Register(IFormCollection registrationForm){ // o IActionResult e o IFormCollection fazem parte de bibliotecas do AspNetCore
            User newUser = new User();
            newUser.Email = registrationForm["Email"];
            newUser.CompleteName = registrationForm["CompleteName"];
            newUser.UserName = registrationForm["UserName"];
            newUser.Password = registrationForm["Password"];

            userModels.Create(newUser);
            ViewBag.Users = userModels.ReadAllItems();

            // localhost:5001/User/Register
            return LocalRedirect("~/Login/Logar");
        }

        [Route ("Edit")]
        
        public IActionResult Edit(IFormCollection profileEdited){
            User edited = new User();
            edited.CompleteName = profileEdited["Name"];
            edited.UserName = profileEdited["Nick"];
            edited.Email = profileEdited["Email"];

            userModels.Update(edited);
            ViewBag.Users = userModels.ReadAllItems();

            // localhost:5001/User/EditProfile
            return LocalRedirect("~/EditProfile");
           
        }

        [Route ("EditProfile")]
        public IActionResult EditProfile(){
            ViewBag.Users = userModels.ReadAllItems();
            return View();
        }
    }
}