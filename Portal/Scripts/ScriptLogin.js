$(document).ready(function () {

    $("#erro-login").css("color", "red");
    $("#botao-enviar").button();


    $("#botao-enviar").click(function () {
        fazerLogin();
    });

    $("#input-senha").keypress(function (event) {
        if (event.which == 13) {
            fazerLogin();
        }
    });

    $("#input-nome").keypress(function (event) {
        if (event.which == 13) {
            fazerLogin();
        }
    });
});


function fazerLogin() {
    var login = $("#input-nome").val();
    var senha = $("#input-senha").val();
    var strURL = "/Login/AutorizarLogin?login=" + login + "&senha=" + senha;
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