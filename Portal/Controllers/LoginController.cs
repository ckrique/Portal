using Portal.DB;
using Portal.Models.Data;
using Portal.Negocio;
using Portal.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AutorizarLogin(Usuario usuario)
        {
            Usuario usuarioLogado;
            bool autorizado = false;

            if (ModelState.IsValid)
            {
                using (DBConexao db = new DBConexao())
                {
                    try
                    {
                        autorizado = Convert.ToBoolean(UsuariosNegocio.autorizarLogin(db, usuario));
                    }
                    catch
                    {
                        return
                            Json(new { sucesso = false, mensagem = Mensagens.ERR_LOGIN }, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            else
            {
                return Json(new { sucesso = false, mensagem = Mensagens.ERR_SISTEMA_LOGIN }, JsonRequestBehavior.AllowGet);
            }


            if (autorizado)
            {
                using (DBConexao db = new DBConexao())
                {
                    usuarioLogado = UsuariosNegocio.getUsuario(db, usuario.login);
                }

                if (usuarioLogado != null)
                {
                    Session.Add("usuarioLogado", usuarioLogado);
                    return Json(new { sucesso = true, urlDestino = "../Home/Index" }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { sucesso = false, mensagem = Mensagens.ERR_CADASTRO_USUARIO }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { sucesso = false, mensagem = Mensagens.ERR_LOGIN }, JsonRequestBehavior.AllowGet);
            }

            return View();
        }
	}
}