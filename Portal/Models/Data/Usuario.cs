using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Portal.Models.Data
{
    public class Usuario
    {
        public const int
            TAM_MAX_NOME = 64;

        public const int
            TAM_MAX_LOGIN = 25;

        public const int
            TAM_MAX_SENHA = 25;

        public const int
            PERFIL_ADMINISTRADOR = 2;

        public const int
            PERFIL_BASICO = 1;


        public const string loginVazio = "O campo login não pode Ser vazio";
        public const string loginMuitoGrande = "O campo login não pode ser tão extenso ";
        public const string senhaVazia = "O campo senha não pode Ser vazio";
        public const string senhaMuitoGrande = "O campo senha não pode ser tão extenso";



        public int idUsuario { get; set; }

        public int? idPessoa { get; set; }

        public String email { get; set; }

        public Empresa empresa { get; set; }

        [Required(ErrorMessage = loginVazio)]
        [StringLength(TAM_MAX_LOGIN,
               ErrorMessage = loginMuitoGrande)]
        public string login { get; set; }


        [Required(ErrorMessage = senhaVazia)]
        [StringLength(TAM_MAX_SENHA,
               ErrorMessage = senhaMuitoGrande)]
        public string senha { get; set; }

        public int idPerfilAcesso { get; set; }


        public Usuario()
        {
            idUsuario = -1;
        }

    }
}