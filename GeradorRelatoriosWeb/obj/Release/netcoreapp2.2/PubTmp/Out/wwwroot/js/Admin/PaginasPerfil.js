$(document).ready(function ($) {
    ListaPaginasPorPerfil($('#cmbPerfil').val());

    $('#cmbPerfil').change(function (e) {
        ListaPaginasPorPerfil($('#cmbPerfil').val());
    });

    if ($(".alert").text() !== "") {
        $(".alert").fadeTo(4000, 500).slideUp(500, function () {
            $(".alert").slideUp(500);
        });
    }

    function ListaPaginasPorPerfil(perfil) {
        $.get(constCaminho + "api/ApiGerador/ListaPaginasPorPerfil", { perfil: perfil }, function (data) {
            $('.chkBox').each(function () {
                if ($.inArray($(this).val(), data) > -1) {
                    $(this).prop("checked", true);
                }
                else {
                    $(this).prop("checked", false);
                }
            });
        });
    }
});