using System;

namespace InstaDev_G1_DT.Models
{
    public class User
    {
        public int IdUser { get; set; } // Id de usuário
        public string CompleteName { get; set; } // Nome completo do usuário
        public string Photo { get; set; } // Foto de perfil do usuário
        public DateTime DateOfBirth { get; set; } // Data de nascimento/aniversário do usuário
        public int Following { get; set; } // CORRIGIR: Following - int[] id || Seguindo
        public string Email { get; set; } // Email do usuário
        public string Username { get; set; } // O @ do usuário
        public string Password { get; set; } // Senha da conta do usuário


    }
}