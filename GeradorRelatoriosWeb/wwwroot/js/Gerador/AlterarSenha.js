$(document).ready(function ($) {
    $('#btnAlterar').click(function (e) {
        e.preventDefault();
        if ($('#txtSenha').val() === "") {
            var el = $('#txtSenha')[0];
            el.setCustomValidity('Campo obrigatório.');
            el.reportValidity();
            return false;
        }

        if ($('#txtSenha').val() !== $('#txtConfirmarSenha').val()) {
            var ele = $('#txtConfirmarSenha')[0];
            ele.setCustomValidity('As senhas devem ser iguais.');
            ele.reportValidity();
            return false;
        }

        VerificaSenhaAtual();
    });

    function VerificaSenhaAtual() {
        $.get(constCaminho + "api/ApiGerador/VerificaSenhaAtual", { idUsuario: $('#txtId').val(), senha: $('#txtSenhaAtual').val() }, function (data) {
            if (data) {
                $('#form').submit();
            }
            else {
                var ele = $('#txtSenhaAtual')[0];
                ele.setCustomValidity('A senha atual está incorreta.');
                ele.reportValidity();
                return false;
            }
        });
    }
});