namespace InstaDev_G1_DT.Models
{
    public class Publication
    {
        public int IdPublication { get; set; } // Id da publicação
        public string Image { get; set; } // Imagem da publicação
        public string Subtitle { get; set; } // Legenda da publicação
        public int IdUser { get; set; } // CORRIGIR: IdUser - int id - FK || Id do usuário da publicação
        public int Likes { get; set; } // Curtidas da publicação

    }
}