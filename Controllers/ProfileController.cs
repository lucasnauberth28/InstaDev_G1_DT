using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_G1_DT.Controllers
{
    [Route ("Profile")]
    public class ProfileController:Controller
    {
        Comments commentModels = new Comments();
        public IActionResult Profile(){
            ViewBag.Comments = commentModels.ReadAllItems();
            return View();
        }

        public IActionResult Comment(IFormCollection registrationComment){ // método de comentar
            Comments newComment = new Comments(); // instanciamento da classe Comments da Models
            newComment.Message = registrationComment["Message"]; // aqui será realmente registrado qualquer mensagem que o usuário fazer numa publicação

            commentModels.Create(newComment); // aqui será gerado o ID para o comentário
            ViewBag.Comments = commentModels.ReadAllItems(); // o commentModels que estava com o ID e a mensagem do comentário será guardado dentro da ViewBag Comments

            return LocalRedirect("~/Profile");
        }

        [Route ("Profile/{id}")]
        public IActionResult Delete(int id){ // método para apagar o comentário da publicação(e do CSV)
            commentModels.Delete(id); // o commentModels puxa da Models o método de Deletar pelo ID
            ViewBag.Comments = commentModels.ReadAllItems(); // o ViewBag que foi guardado o ID e a mensagem do comentário no método acima(Comment) será "re-lido" para ver as informações que existem lá dentro novamente

            return LocalRedirect("~/Profile");
        }
    }
}