namespace InstaDev_G1_DT.Models
{
    public class Comments
    {
        public int IdComment { get; set; } // Id do comentário
        public string Message { get; set; } // Id da mensagem do comentário
        public int IdUser { get; set; } // CORRIGIR: IdUser - int id - FK || Id do usuário do comentário
        public int IdPublication { get; set; } // CORRIGIR: IdPublication - int id - FK || Id da publicação do comentário

    }
}