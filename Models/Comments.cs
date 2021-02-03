using System;
using System.Collections.Generic;
using System.IO;
using InstaDev_G1_DT.Interfaces;

namespace InstaDev_G1_DT.Models
{
    public class Comments : InstaDevBase, IComments
    {
        public int IdComment { get; set; } // Id do comentário
        public string Message { get; set; } // Id da mensagem do comentário
        public int IdUser { get; set; } // CORRIGIR: IdUser - int id - FK || Id do usuário do comentário
        public int IdPublication { get; set; } // CORRIGIR: IdPublication - int id - FK || Id da publicação do comentário
        private const string PATH = "Database/Comentários.CSV";

        Comments()
        {
            CreateFolderAndFile(PATH);
        }
        public string PrepareLinesCSV(Comments c)
        {
            return $"{c.IdPublication};{c.IdUser};{c.IdComment};{c.Message}";
        }

        public void Create(Comments newComments)
        {
            string[] Lines = {PrepareLinesCSV(newComments)};
            File.AppendAllLines(PATH, Lines);
        }

        public List<Comments> ReadAllItens()
        {
            List<Comments> comment = new List<Comments>();
            //ler todas a linhas CSV
            string[] Lines = File.ReadAllLines(PATH);

            //percorrer as linhas e adicionar na lista de equipes cada objeto "equipe"
            foreach (var item in Lines)
            {
                string[] line = item.Split(";");

                Comments Comment = new Comments();

                Comment.IdPublication   = Int32.Parse(line [0]);
                Comment.IdUser          = Int32.Parse(line [1]);
                Comment.IdComment       = Int32.Parse(line [2]);
                Comment.Message         = line[3];


                comment.Add(Comment);
            }
            return comment;
        }

        public void Update(Comments c)
        {
            List<String> lines = ReadAllLinesCSV(PATH);
            lines.RemoveAll(x => x.Split(";") [0] == c.IdComment.ToString());
            lines.Add(PrepareLinesCSV(c) );
            RewriteCSV(PATH, lines);

        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}