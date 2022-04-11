$(document).ready(function ($) {

    if ($('#txtDataInicio').val() === '0001-01-01') {
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1;
        var yyyy = today.getFullYear();
        if (dd < 10) {
            dd = '0' + dd;
        }
        if (mm < 10) {
            mm = '0' + mm;
        }

        today = yyyy + '-' + mm + '-' + dd;
        $('#txtDataInicio').val(today);
        $('#txtDataFinal').val(today);
    }

    $('#btnVisualizar').click(function (e) {
        $("#modalProcessando").modal('show');
    });

    $(document).on("click", ".clickable", function () {
        if ($(this).hasClass("fa-plus-square-o")) {
            $(this).removeClass("fa-plus-square-o");
            $(this).addClass("fa-minus-square-o");
            var id = $(this).data('id');

            if ($("#div-" + id).html() === "") {
                mostraDetalhes(id);
            }
        }
        else {
            $(this).removeClass("fa-minus-square-o");
            $(this).addClass("fa-plus-square-o");
        }
    });

    function mostraDetalhes(numeroAit) {
        $.get(constCaminho + "api/ApiGerador/DetalheExcessoPeso", { numeroAit: numeroAit }, function (data) {
            $("#div-" + numeroAit).html(data);
        });
    }
});
