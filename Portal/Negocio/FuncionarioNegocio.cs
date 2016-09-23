using Portal.DB;
using Portal.Models.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Portal.Negocio
{
    public class FuncionarioNegocio
    {
        public static DataTable buscarRelatorioFuncionarios(DBConexao db, int idEmpresa, DateTime dataInicial)
        {
            DataTable dtRetorno;
            dtRetorno = FuncionarioDAO.buscarRelatorioFuncionarios(db, idEmpresa, dataInicial);
            return dtRetorno;
        }
    }
}