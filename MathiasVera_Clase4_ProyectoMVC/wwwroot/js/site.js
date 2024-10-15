// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function CrearAlerta() {
    alert("Crea Alerta");
}

//funcion para sumar escrito con javascript
function Sumar() {
    var numero1 = document.getElementById("numero1").value;
    var numero2 = document.getElementById("numero2").value;

    var suma = parseInt(numero1) + parseInt(numero2);

    document.getElementById("resultado").value = suma;
}

// Misma funcion utilizando Jquery, conviven juntos
$(document).ready(function () {
    $("#boton1").click(function () {
        var numero_1 = $("#numero1").val(); // Recordar que no es var es val para obtener el valor
        var numero_2 = $("#numero2").val();

        var suma = parseInt(numero_1) + parseInt(numero_2);

        $("#resultado").val(suma);
        $("#parrafo_respuesta").html("El resultado es: "+suma);
    })
});