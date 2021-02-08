using System;
using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections.Generic;

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

        [Route("EditarPerfil-Usuario")]
        public User MostrarUsuario()
        {
            var userid = HttpContext.Session.GetString("_UserId");
            User userLogado = userModels.BuscarUsuarioPorId(int.Parse(userid));

            return userLogado;
        }
        [Route("EditarPerfil/SwitchData")]
        public IActionResult SwitchData(IFormCollection form)
        {
            User newUser = MostrarUsuario();
            newUser.CompleteName = form["Name"];
            newUser.Photo = form["Photo"];
            
            if(form.Files.Count > 0){

                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/perfil");

                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                
                newUser.Photo = file.FileName;           
            }

            newUser.Email = form["Email"];
            newUser.UserName = form["Username"];
            
            userModels.Update(newUser);

            ViewBag.UsuarioAtualizado = newUser;

            //Alterar form posts - início
            // List<string> posts = publicacaoModel.ReadAllLinesCSV(publicacaoModel._PATH);

            // var pub = posts.FindAll(x => x.Split(";")[3] == novoUsuario.IdUsuario.ToString());

            // foreach (string item in pub)
            // {
            //     var file = form.Files[0];

            //     string[] linha = item.Split(";");

            //     Publicacao publicacao = new Publicacao();
            //     publicacao.IdPublicacao = int.Parse(linha[0]);
            //     publicacao.Imagem = linha[1];
            //     publicacao.Legenda = linha[2];
            //     publicacao.IdUsuario = int.Parse(linha[3]);
            //     publicacao.Likes = int.Parse(linha[4]);
            //     publicacao.FotoUsuario = file.FileName;

            //     publicacaoModel.Update(publicacao);
            // }
            //Alterar form posts - início

            return LocalRedirect("~/EditarPerfil");
        }

        [Route("ExcluirPerfil")]
        public IActionResult Excluir(int id)
        {
            var userId = HttpContext.Session.GetString("_UserId");
            if (userId == id.ToString())
            {
                userModels.Delete(id);

            }
            return LocalRedirect("~/Login");
        }
    }
}
    