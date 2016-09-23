using Portal.DB;
using Portal.Models.Data;
using Portal.Models.Handle;
using Portal.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult FlotCharts()
        {
            return View("FlotCharts");
        }

        public ActionResult MorrisCharts()
        {
            return View("MorrisCharts");
        }

        
        public ActionResult Tables(String strDataInicial)
        {
            DateTime dataInicial;
            
            if (!String.IsNullOrEmpty(strDataInicial))
                dataInicial = Convert.ToDateTime(strDataInicial);
            else
                dataInicial = DateTime.ParseExact("01/01/1940", "dd/MM/yyyy", CultureInfo.InvariantCulture);


            IList<FuncionarioHandle> listaFuncionario = new List<FuncionarioHandle>();
            DataTable dtFuncionarios = new DataTable();
            int idEmpresa = 0;
            

            var usuarioSessionVar = this.Session["usuarioLogado"];
            Usuario usuaruioLogado;

            if (usuarioSessionVar != null)
            {
                usuaruioLogado = (Usuario)usuarioSessionVar;
                idEmpresa = usuaruioLogado.empresa.IdEmpresa;
            }
            else
                return View("../Login/Index");

            using (DBConexao db = new DBConexao())
            {
                try
                {
                    dtFuncionarios = FuncionarioNegocio.buscarRelatorioFuncionarios(db, idEmpresa, dataInicial);

                    if(dtFuncionarios != null && dtFuncionarios.Rows.Count > 0)
                    {
                        foreach(DataRow drFuncionario in dtFuncionarios.Rows)
                        {
                            FuncionarioHandle funcionario = new FuncionarioHandle();

                            if (drFuncionario["nome"] != DBNull.Value && drFuncionario["cargo"] != DBNull.Value)
                            {
                                funcionario.nome = Convert.ToString(drFuncionario["nome"]);
                                funcionario.cargo = Convert.ToString(drFuncionario["cargo"]);
                            }
                            listaFuncionario.Add(funcionario);
                        }
                    }
                }
                catch(Exception)
                {
                    return View();
                }
            }

            
            return View("Tables", listaFuncionario);
        }

        public ActionResult Forms()
        {            
            return View("Forms");
        }

        public ActionResult Panels()
        {
            return View("Panels");
        }

        public ActionResult Buttons()
        {
            return View("Buttons");
        }

        public ActionResult Notifications()
        {
            return View("Notifications");
        }

        public ActionResult Typography()
        {
            return View("Typography");
        }

        public ActionResult Icons()
        {
            return View("Icons");
        }

        public ActionResult Grid()
        {
            return View("Grid");
        }

        public ActionResult Blank()
        {
            return View("Blank");
        }

    }
}