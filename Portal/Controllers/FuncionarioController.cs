using Portal.Models.Handle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using Portal.Models.Data;
using Portal.ServiceReferenceEnviaFuncionario;
using Portal.DB;
using Portal.Negocio;
using System.Data;
using System.Globalization;

namespace Portal.Controllers
{
    public class FuncionarioController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviarFuncionario(FuncionarioHandle funcionario)
        {
            var usuarioSessionVar = this.Session["usuarioLogado"];
            Usuario usuaruioLogado;

            if(usuarioSessionVar != null)
                usuaruioLogado = (Usuario) usuarioSessionVar;            
            else
                return View("../Login/Index");
            
            
            ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoapClient servico = new ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoapClient();

            
            
            //servico.ClientCredentials.SecurityTokenHandlerCollectionManager
            servico.ClientCredentials.UserName.Password = "11111";
            servico.ClientCredentials.UserName.UserName = "ckrique";
            //servico.ClientCredentials. = "12123";
            //servico.ClientCredentials.Windows.ClientCredential.Domain = "Domain";

            PersonalAuthentication credencial = new PersonalAuthentication()
            {
                Username = usuaruioLogado.login,
                Password = usuaruioLogado.senha
            };
            
            var retorno = servico.cadastrarFuncionario(credencial, funcionario.nome, funcionario.codigo,
                                                         funcionario.cpf, funcionario.identidade, funcionario.passaport,
                                                             funcionario.numeroDocumentoAdicional, funcionario.documentoAdicional,
                                                                 funcionario.perfil, funcionario.cargo, funcionario.dataNascimento, funcionario.dataAssuncao,
                                                                 funcionario.dataAdmissao, usuaruioLogado.empresa.codigoEmpresa, funcionario.dataDemissao, usuaruioLogado.login, 
                                                                    usuaruioLogado.email);

            return View("../Home/Forms");
        }
	}
}