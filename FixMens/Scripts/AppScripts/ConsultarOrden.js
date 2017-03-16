(function ($) {
    $(function () {

        $(".button-collapse").sideNav();
        $(".parallax").parallax();

    });
    $("#isAdmin").click(function() {
        if($(this).is(":checked")) {
            $(".divPassword").removeClass("hide");
        } else {
            $(".divPassword").addClass("hide");
        }
    });
   
    // end of document ready
})($); // end of jQuery name space

$(".jsConsultarOrden").on("click", consultarOrden);

function alertaTemporal() {
    alert("En construcción");
}

$(document).ajaxStart(function () {
    $(".progress").show();
    $(".jsConsultarOrden").attr('disabled', 'disabled');
});

$(document).ajaxComplete(function () {
    $(".progress").hide();
    $(".jsConsultarOrden").removeAttr('disabled');
});

function consultarOrden() {
    $.validator.messages.required = ""; //ToDo hacer override para que no choque con materialize
    $("#detalleOrden").html(""); //Limpiar detalle
    if ($(".formOrden :input").valid()) {
        $.ajax({
            type: "GET",
            url: window.consultarOrdenAction,
            datatype: "html",
            data: { nombre: $("#nombre").val(), orden: $("#orden").val(), admin: $("#adminPassword").val() },
            success: function(data) {
                $("#detalleOrden").html(data);
                Materialize.updateTextFields();
				$('textarea').trigger('autoresize'); //Ajustar tamaño de textareas
            },
            error: function (response) {
                Materialize.toast(response.responseText, 4000, "red"); // I'm always get this.
            }
        });
    } else {
        $(".formOrden :input").each(function () {
            if(!($(this).valid()))
            $(this).addClass("invalid");
        });
        

    }
    return false;
}