$(document).ready(function ($) {
    
    $.get(constCaminho + "api/Menu/MontaMenu", function (data) {
        $('#divMenu').html(data);
    });
});
