$(document).ready(function ($) {
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.load('current', { 'packages': ['bar'] });
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

    $(document).on("click", ".linha", function () {
        //$("#modalProcessando").modal('show');
        var data = $(this).data('data');
        montaGraficoTotal($(this).data('validas'), $(this).data('invalidas'));
        montaGraficoDia(data);
        montaGraficoOperadora(data);
        //$("#modalProcessando").modal('hide');
    });

    $(document).on("click", ".total", function () {
        montaGraficoTotal($("#hdnValidas").val(), $("#hdnInvalidas").val());
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

    function montaGraficoDia(dia) {
        try {
            //$("#modalProcessando").modal('show');
            $.get(constCaminho + "api/ApiGerador/ValidasPorHora", { dia: dia }, function (dados) {
                var data = new google.visualization.DataTable();
                data.addColumn('string', 'Hora');
                data.addColumn('number', 'Válidas');
                data.addColumn('number', 'Inválidas');

                for (i in dados) {
                    data.addRows([['' + dados[i].hora + '', dados[i].quantidadeValida, dados[i].quantidadeInvalida]]);
                }

                var options = {
                    title: 'Por horário - ' + dia,
                    curveType: 'function',
                    width: '600px',
                    legend: { position: 'bottom' }
                };

                var chart = new google.visualization.LineChart(document.getElementById('divGrafPorHora'));
                $("#modalProcessando").modal('hide');
                chart.draw(data, options);
            });
        } catch (e) {
            $("#modalProcessando").modal('hide');
        }
    }

    function montaGraficoOperadora(dia) {
        try {
            
            $.get(constCaminho + "api/ApiGerador/ValidasPorOperadora", { dia: dia }, function (dados) {
                var data = new google.visualization.DataTable();
                data.addColumn('string', 'Operadora');
                data.addColumn('number', 'Válidas');
                data.addColumn('number', 'Inválidas');

                for (i in dados) {
                    data.addRows([['' + dados[i].operadora + '', dados[i].quantidadeValida, dados[i].quantidadeInvalida]]);
                }

                var options = {
                    chart: {
                        title: 'Por Operadora - ' + dia,
                        width: '600px'
                    }
                };

                var chart = new google.charts.Bar(document.getElementById('divGrafPorOperadora'));
                chart.draw(data, google.charts.Bar.convertOptions(options));
                $("#modalProcessando").modal('hide');
            });
        } catch (e) {
            $("#modalProcessando").modal('hide');
        }
    }
});

