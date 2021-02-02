using System.Collections.Generic;
using System.IO;
using InstaDev_G1_DT.Interfaces;

namespace InstaDev_G1_DT.Models
{
    public class Publication : InstaDevBase, IPublication
    {
        public int IdPublication { get; set; } // Id da publicação
        public string Image { get; set; } // Imagem da publicação
        public string Subtitle { get; set; } // Legenda da publicação
        public int IdUser { get; set; } // CORRIGIR: IdUser - int id - FK || Id do usuário da publicação
        public int Likes { get; set; } // Curtidas da publicação
        private const string PATH = "Database/Publicação.CSV";

        public Publication()
        {
            CreateFolderAndFile(PATH );
        }
        public string PrepareLinesCSV(Publication p)
        {
            return $"{p.IdPublication};{p.Subtitle};{p.Image}";
        }
        public void Create(Publication newPublication)
        {
            string[]line = {PrepareLinesCSV(newPublication)};
            File.AppendAllLines(PATH, line);
        }
        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Publication> ReadAllItens()
        {
            List<Publication> publications = new List<Publication>();
            //ler todos os itens
            string[] Lines = File.ReadAllLines(PATH);

            foreach (var item in Lines)
            {
                string[] Line = item.Split(";");

                //obejto publicação criado
                Publication publication = new Publication();

                publication.IdPublication   = int.Parse(Lines[0]);
                publication.Subtitle        = Lines[1];
                publication.Image           = Lines[2];

            }
            return publications;
        }
    }
}