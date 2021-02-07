using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace InstaDev_G1_DT.Controllers
{
    [Route("Feed")]
    public class PublicationController : Controller
    {
        Publication pubModels = new Publication();

        public IActionResult Feed()
        {
            User user = new User();
            ViewBag.Users = user.BuscarUsuarioPorId(int.Parse(HttpContext.Session.GetString("IdUser")));
            ViewBag.Publications = pubModels.ReadAllItens();
            return View();
        }

        [Route("Publicar")]
        public IActionResult Publicar(IFormCollection form)
        {
            // Criamos uma nova instância de Equipe
            // e armazenamos os dados enviados pelo usúarios
            // através do formulário
            // e salvamos no objeto novaEquipe
            Publication newPub = new Publication();
            User user = new User();
            newPub.IdPublication = pubModels.idGPublication();
            newPub.Subtitle = form["Subtitle"];
            newPub.Image = form["Image"];


            // Inicio uploud
            if (form.Files.Count > 0)
            {
                //Se sim,
                //Armazenamos o arquivo na variável file
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Pubs");

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
            newPub.Subtitle = form["Subtitle"];
            newPub.IdUser = int.Parse(HttpContext.Session.GetString("IdUser"));


            // Chamamos o método Create para salvar
            // a novaEquipe no CSV
            pubModels.Create(newPub);
            ViewBag.Users = pubModels.ReadAllItens();

            return LocalRedirect("~/Feed");
        }

        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            pubModels.Delete(id);
            ViewBag.Publications = pubModels.ReadAllItens();
            return LocalRedirect("~/Feed");
        }
    }
}