using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Portal.Models.Data;
using Portal.Properties;
using Portal.DB;
using System.Data;

namespace Portal.Models.Persistencia
{
    public class UsuarioDAO : DAOPadrao
    {
        // Método cadastrar usuario-----------------------------------------------------------------------------------
        public static void cadastrarUsuario(DBConexao db, Usuario usuario)
        {
            using (SqlCommand comando = new SqlCommand("query cadastrar usuario", db.getConexao()))
            {
                comando.Transaction = db.getOpenTransaction();
                comando.Parameters.AddWithValue("login", usuario.login);
                comando.Parameters.AddWithValue("senha", usuario.senha);

                comando.ExecuteNonQuery();
            }
        }

        //Método que obtém um usuario se ele existe no banco e possui login e senha de acordo com os parâmetros---------
        public static bool autorizarLogin(DBConexao db, Usuario usuario)
        {
            int retorno = 0;

            using (SqlCommand comando = new SqlCommand(SQL.PROCEDURE_AUTORIZA_LOGIN, db.getConexao()))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@login", usuario.login);
                comando.Parameters.AddWithValue("@senha", usuario.senha);

                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = comando;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "result_table");

                    DataTable dt = ds.Tables["result_table"];

                    if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["autoriza"] != DBNull.Value)
                    {
                        retorno = Convert.ToInt32(dt.Rows[0]["autoriza"]);
                    }
                }
            }
            return Convert.ToBoolean(retorno);
        }

        //----------------------------------------------------------------------------------------------------------------
        public static Usuario getUsuario(DBConexao db, string login)
        {
            Usuario usuario = null;
            using (SqlCommand comando = new SqlCommand(SQL.PROCEDURE_BUSCAR_USUARIO, db.getConexao()))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@login", login);

                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = comando;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "result_table");

                    DataTable dtUsuario = ds.Tables["result_table"];

                    if (dtUsuario != null && dtUsuario.Rows.Count > 0)
                        usuario = makeUsuario(dtUsuario);
                }
            }
            return usuario;
        }


        //Métodos Private-------------------------------------------------------------------------------------------------
        private static Usuario makeUsuario(DataTable dtUsuario)
        {
            Usuario usuario = new Usuario();

            if (dtUsuario.Rows[0]["login"] != DBNull.Value &&
                    dtUsuario.Rows[0]["idPerfilAcesso"] != DBNull.Value
                )
            {
                usuario.login = Convert.ToString(dtUsuario.Rows[0]["login"]);
                usuario.senha = Convert.ToString(dtUsuario.Rows[0]["senha"]);
                usuario.idPerfilAcesso = Convert.ToInt32(dtUsuario.Rows[0]["idPerfilAcesso"]);                
                usuario.email = Convert.ToString(dtUsuario.Rows[0]["email"]);

                Empresa empresa = new Empresa();
                empresa.IdEmpresa = Convert.ToInt32(dtUsuario.Rows[0]["idEmpresa"]);
                empresa.nomeEmpresa = Convert.ToString(dtUsuario.Rows[0]["nomeEmpresa"]);
                empresa.codigoEmpresa = Convert.ToString(dtUsuario.Rows[0]["codigoEmpresa"]);

                usuario.empresa = empresa;

                return usuario;
            }

            return null;
        }
    }
}