using Portal.DB;
using Portal.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Portal.Models.Persistencia
{
    public class FuncionarioDAO
    {
        //----------------------------------------------------------------------------------------------------------------
        public static DataTable buscarRelatorioFuncionarios(DBConexao db, int idEmpresa, DateTime dataInicial)
        {
            DataTable dtRetorno;
            using (SqlCommand comando = new SqlCommand(SQL.PROCEDURE_RELAT_FUNCIONARIOS, db.getConexao()))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                comando.Parameters.AddWithValue("@dataInicio", dataInicial);
                comando.Parameters.AddWithValue("@dataFinal", DateTime.Now);

                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = comando;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "result_table");

                    dtRetorno  = ds.Tables["result_table"];                                        
                }
            }
            return dtRetorno;
        }


    }
}