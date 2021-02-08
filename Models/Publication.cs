using System.Collections.Generic;
using System.IO;
using InstaDev_G1_DT.Interfaces;

namespace InstaDev_G1_DT.Models
{
    public class Publication:InstaDevBase, IPublication
    {
        public int IdPublication { get; set; } // Id da publicação
        public string Image { get; set; } // Imagem da publicação
        public string Subtitle { get; set; } // Legenda da publicação
        private const string PATH = "Database/publication.CSV";

        public Publication()
        {
            CreateFolderAndFile(PATH);
        }
        public string PrepareLinesCSV(Publication p)
        {
            return $"{p.IdPublication};{p.Subtitle};{p.Image}";
        }

        public int idGPublication()
        {
            var ids = ReadAllItens();

            if (ids.Count == 0)
            {
                return 1;
            }

            var idCode = ids[ids.Count - 1].IdPublication;

            idCode++;

            return idCode;
        }
        public void Create(Publication newPublication)
        {
            string[] linhas = { PrepareLinesCSV(newPublication) };
            File.AppendAllLines(PATH, linhas);
        }


        public void Delete(int Id)
        {
            List<string> line = ReadAllLinesCSV(PATH);
            line.RemoveAll(x => x.Split(";")[0] == Id.ToString());
            RewriteCSV(PATH, line);
        }

        public List<Publication> ReadAllItens()
        {
            List<Publication> publications = new List<Publication>();
            //ler todos os itens
            string[] Lines = File.ReadAllLines(PATH);

            foreach (var item in Lines)
            {
                string[] Line = item.Split(";");

                //objeto publicação criado
                Publication publication = new Publication();

                publication.IdPublication = int.Parse(Lines[0]);
                publication.Subtitle = Lines[1];
                publication.Image = Lines[2];

                publications.Add(publication);

            }
            return publications;
        }

        public void Update(){}
        
    }
}