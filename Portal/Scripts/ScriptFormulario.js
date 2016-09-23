$(document).ready(function () {

    //$("#erro-login").css("color", "red");
    //$("#botao-enviar").button();
    
   /* $("#btnEnviarFuncionario").click(function () {
        enviarFuncionario();
    });
    */
    //$("#input-senha").keypress(function (event) {
    //    if (event.which == 13) {
    //        fazerLogin();
    //    }
    //});

    //$("#input-nome").keypress(function (event) {
    //    if (event.which == 13) {
    //        fazerLogin();
    //    }
    //});
});


function enviarFuncionario() {
    var strURL = "/Funcionario/EnviarFuncionario";
    $.get(strURL,

		function (response) {

		    if (!response.sucesso) {
		        $("#erro-login").show();

		    }
		    else {
		        window.location.href = response.urlDestino;
		    }
		});

}