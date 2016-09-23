using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Portal.Models.Persistencia;
using Portal.DB;
using Portal.Models.Data;
using Portal.Properties;


namespace Portal.Negocio
{
    public class UsuariosNegocio
    {
        public const int PERFIL_ADMINISTRADOR = 1;
        public const int PERFIL_USUARIO_NORMAL = 2;

        //---------------------------------------------------------------------------------------
        public static void cadastrarUsuario(DBConexao db, Usuario usuario)
        {
            using (DBTransacao tr = new DBTransacao(db))
            {
                try
                {
                    UsuarioDAO.cadastrarUsuario(db, usuario);
                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    throw;
                }
            }
        }

        public static Usuario getUsuario(DBConexao db, string login)
        {
            Usuario usuario;
            usuario = UsuarioDAO.getUsuario(db, login);
            return usuario;
        }

        public static bool autorizarLogin(DBConexao db, Usuario usuario)
        {
            return UsuarioDAO.autorizarLogin(db, usuario);
        }


    }
}