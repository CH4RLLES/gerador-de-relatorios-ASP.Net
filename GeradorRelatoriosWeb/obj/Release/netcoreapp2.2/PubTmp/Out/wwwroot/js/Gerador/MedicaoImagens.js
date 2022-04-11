$(document).ready(function ($) {
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(montaGraficoCallback);

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

    function montaGraficoCallback() {
        montaGraficoTotal($("#hdnValidas").val(), $("#hdnInvalidas").val());
    }

    function montaGraficoTotal(validas, invalidas) {
        if (validas === "0" && invalidas === "0")
            return;

        var data = google.visualization.arrayToDataTable([
            ['Task', 'Imagens'],
            ['Válidas', parseInt(validas)],
            ['Inválidas', parseInt(invalidas)]
        ]);

        var options = {
            title: 'Imagens Válidas / Inválidas',
            is3D: true
        };

        var chart = new google.visualization.PieChart(document.getElementById('divGrafTotal'));

        chart.draw(data, options);
    }
});

