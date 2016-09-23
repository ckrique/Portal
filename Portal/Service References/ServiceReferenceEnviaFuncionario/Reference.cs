﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.ServiceReferenceEnviaFuncionario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoap")]
    public interface CadastroFuncionarioSoap {
        
        // CODEGEN: Generating message contract since message cadastrarFuncionarioRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cadastrarFuncionario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioResponse cadastrarFuncionario(Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cadastrarFuncionario", ReplyAction="*")]
        System.Threading.Tasks.Task<Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioResponse> cadastrarFuncionarioAsync(Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class PersonalAuthentication : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string usernameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="cadastrarFuncionario", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class cadastrarFuncionarioRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Portal.ServiceReferenceEnviaFuncionario.PersonalAuthentication PersonalAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string nome;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string codigoFunc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string cpf;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string identidade;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string passaporte;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string numOutroDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string descricaoOutroDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public string perfil;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        public string cargo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=9)]
        public string dataNascimento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=10)]
        public string dataAssuncaoCargo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=11)]
        public string dataAdmissao;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=12)]
        public string codigoEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=13)]
        public string dataDemissao;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=14)]
        public string loginDestinatario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=15)]
        public string emailDestinatario;
        
        public cadastrarFuncionarioRequest() {
        }
        
        public cadastrarFuncionarioRequest(
                    Portal.ServiceReferenceEnviaFuncionario.PersonalAuthentication PersonalAuthentication, 
                    string nome, 
                    string codigoFunc, 
                    string cpf, 
                    string identidade, 
                    string passaporte, 
                    string numOutroDocumento, 
                    string descricaoOutroDocumento, 
                    string perfil, 
                    string cargo, 
                    string dataNascimento, 
                    string dataAssuncaoCargo, 
                    string dataAdmissao, 
                    string codigoEmpresa, 
                    string dataDemissao, 
                    string loginDestinatario, 
                    string emailDestinatario) {
            this.PersonalAuthentication = PersonalAuthentication;
            this.nome = nome;
            this.codigoFunc = codigoFunc;
            this.cpf = cpf;
            this.identidade = identidade;
            this.passaporte = passaporte;
            this.numOutroDocumento = numOutroDocumento;
            this.descricaoOutroDocumento = descricaoOutroDocumento;
            this.perfil = perfil;
            this.cargo = cargo;
            this.dataNascimento = dataNascimento;
            this.dataAssuncaoCargo = dataAssuncaoCargo;
            this.dataAdmissao = dataAdmissao;
            this.codigoEmpresa = codigoEmpresa;
            this.dataDemissao = dataDemissao;
            this.loginDestinatario = loginDestinatario;
            this.emailDestinatario = emailDestinatario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="cadastrarFuncionarioResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class cadastrarFuncionarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string cadastrarFuncionarioResult;
        
        public cadastrarFuncionarioResponse() {
        }
        
        public cadastrarFuncionarioResponse(string cadastrarFuncionarioResult) {
            this.cadastrarFuncionarioResult = cadastrarFuncionarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CadastroFuncionarioSoapChannel : Portal.ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CadastroFuncionarioSoapClient : System.ServiceModel.ClientBase<Portal.ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoap>, Portal.ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoap {
        
        public CadastroFuncionarioSoapClient() {
        }
        
        public CadastroFuncionarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CadastroFuncionarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CadastroFuncionarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CadastroFuncionarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioResponse Portal.ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoap.cadastrarFuncionario(Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioRequest request) {
            return base.Channel.cadastrarFuncionario(request);
        }
        
        public string cadastrarFuncionario(
                    Portal.ServiceReferenceEnviaFuncionario.PersonalAuthentication PersonalAuthentication, 
                    string nome, 
                    string codigoFunc, 
                    string cpf, 
                    string identidade, 
                    string passaporte, 
                    string numOutroDocumento, 
                    string descricaoOutroDocumento, 
                    string perfil, 
                    string cargo, 
                    string dataNascimento, 
                    string dataAssuncaoCargo, 
                    string dataAdmissao, 
                    string codigoEmpresa, 
                    string dataDemissao, 
                    string loginDestinatario, 
                    string emailDestinatario) {
            Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioRequest inValue = new Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioRequest();
            inValue.PersonalAuthentication = PersonalAuthentication;
            inValue.nome = nome;
            inValue.codigoFunc = codigoFunc;
            inValue.cpf = cpf;
            inValue.identidade = identidade;
            inValue.passaporte = passaporte;
            inValue.numOutroDocumento = numOutroDocumento;
            inValue.descricaoOutroDocumento = descricaoOutroDocumento;
            inValue.perfil = perfil;
            inValue.cargo = cargo;
            inValue.dataNascimento = dataNascimento;
            inValue.dataAssuncaoCargo = dataAssuncaoCargo;
            inValue.dataAdmissao = dataAdmissao;
            inValue.codigoEmpresa = codigoEmpresa;
            inValue.dataDemissao = dataDemissao;
            inValue.loginDestinatario = loginDestinatario;
            inValue.emailDestinatario = emailDestinatario;
            Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioResponse retVal = ((Portal.ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoap)(this)).cadastrarFuncionario(inValue);
            return retVal.cadastrarFuncionarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioResponse> Portal.ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoap.cadastrarFuncionarioAsync(Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioRequest request) {
            return base.Channel.cadastrarFuncionarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioResponse> cadastrarFuncionarioAsync(
                    Portal.ServiceReferenceEnviaFuncionario.PersonalAuthentication PersonalAuthentication, 
                    string nome, 
                    string codigoFunc, 
                    string cpf, 
                    string identidade, 
                    string passaporte, 
                    string numOutroDocumento, 
                    string descricaoOutroDocumento, 
                    string perfil, 
                    string cargo, 
                    string dataNascimento, 
                    string dataAssuncaoCargo, 
                    string dataAdmissao, 
                    string codigoEmpresa, 
                    string dataDemissao, 
                    string loginDestinatario, 
                    string emailDestinatario) {
            Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioRequest inValue = new Portal.ServiceReferenceEnviaFuncionario.cadastrarFuncionarioRequest();
            inValue.PersonalAuthentication = PersonalAuthentication;
            inValue.nome = nome;
            inValue.codigoFunc = codigoFunc;
            inValue.cpf = cpf;
            inValue.identidade = identidade;
            inValue.passaporte = passaporte;
            inValue.numOutroDocumento = numOutroDocumento;
            inValue.descricaoOutroDocumento = descricaoOutroDocumento;
            inValue.perfil = perfil;
            inValue.cargo = cargo;
            inValue.dataNascimento = dataNascimento;
            inValue.dataAssuncaoCargo = dataAssuncaoCargo;
            inValue.dataAdmissao = dataAdmissao;
            inValue.codigoEmpresa = codigoEmpresa;
            inValue.dataDemissao = dataDemissao;
            inValue.loginDestinatario = loginDestinatario;
            inValue.emailDestinatario = emailDestinatario;
            return ((Portal.ServiceReferenceEnviaFuncionario.CadastroFuncionarioSoap)(this)).cadastrarFuncionarioAsync(inValue);
        }
    }
}
