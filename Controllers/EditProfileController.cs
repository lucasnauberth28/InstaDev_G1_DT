using System;
using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_G1_DT.Controllers
{
    [Route("EditProfile")]
    public class EditProfileController : Controller
    {
        User userModels = new User();

        public IActionResult EditProfile()
        {
            ViewBag.Users = userModels.ReadAllItems();
            return View();
        }

        [Route("Edit")]
        public IActionResult Edit(IFormCollection profileEdited)
        {
            User edited = new User();
            edited.CompleteName = profileEdited["Name"];
            edited.UserName = profileEdited["Nick"];
            edited.Email = profileEdited["Email"];

            userModels.Update(edited);
            ViewBag.Users = userModels.ReadAllItems();

            // localhost:5001/User/EditProfile
            return LocalRedirect("~/EditProfile");

        }

    }
}