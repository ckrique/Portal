using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Models.Data
{
    public class Funcionario
    {        
        public int idFuncionario { get; set; }
        
        private Pessoa pessoa { get; set; }

        public string codigoFuncionario { get; set; }

        public DateTime dataAssuncaoCargo { get; set; }

        public DateTime dataAdmissao { get; set; }

        public DateTime? dataDemissao { get; set; }

        public string Perfil { get; set; }

        public string Cargo { get; set; }

    }
}