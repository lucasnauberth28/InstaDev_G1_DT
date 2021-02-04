using InstaDev_G1_DT.Models;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstaDev_G1_DT.Controllers
{
    [Route("Feed")]
    public class PublicationController : Controller
    {
        Publication pubModels = new Publication();

        [Route("Listar")]
        public IActionResult Index()
        {
            // Equipe idAutomatico = new Equipe();
            // ViewBag.idAutomatico = idAutomatico.idEquipao();
            // Listando todas as equipes e enviando para a View, através da ViewBag
            ViewBag.publications = pubModels.ReadAllItens();
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult Publicar(IFormCollection form)
        {
            // Criamos uma nova instância de Equipe
            // e armazenamos os dados enviados pelo usúarios
            // através do formulário
            // e salvamos no objeto novaEquipe
            Publication newPub = new Publication();
            newPub.IdPublication = pubModels.idGPublication();
            

            // Inicio uploud
            if (form.Files.Count > 0)
            {
                //Se sim,
                //Armazenamos o arquivo na variável file
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                // Verificamos se a pasta Equipes não existe
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //localhost:5001           +        + Equipes + equipe.jpg        
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    // Salvamos o arquivo no caminho especificado
                    file.CopyTo(stream);
                }
                newPub.Image = file.FileName;
            }

           
            // Uploud termino
            newPub.Subtitle= form["Subtitle"];
            


            // Chamamos o método Create para salvar
            // a novaEquipe no CSV
            pubModels.Create(pubModels);
            ViewBag.Equipes = pubModels.ReadAllItens();

            return LocalRedirect("~/Feed/Listar");
        }
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            pubModels.Delete(id);
            ViewBag.Publications=pubModels.ReadAllItens();
            return LocalRedirect("~/Feed/Listar");
        }
    }

}