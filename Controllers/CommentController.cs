using InstaDev_G1_DT.Models;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace InstaDev_G1_DT.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Create(IFormCollection form)
        {
            //criação de nova instância de comentário
            //
            Comments NewComment = new Comments();

            NewComment.IdPublication    = Int32.Parse(form["IdPublication"]);
            NewComment.IdUser           = Int32.Parse(form["IdUser"]);
            NewComment.IdComment        = Int32.Parse(form["IdComment"]);
            NewComment.Message          = form["Message"];

            return LocalRedirect("~/");
        }
    }
}