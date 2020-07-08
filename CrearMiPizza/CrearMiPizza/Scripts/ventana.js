var ventanaTerminar = document.getElementById("vtn-modal-irInicio");
var ventanaCancelar = document.getElementById("vtn-modal-anularPedido");

var botonTerminar = document.getElementById("termina-pedido");
var botonCancelar = document.getElementById("cancelar-pedido");

var botonNo = document.getElementById("btn-no");
var botonCerrar = document.getElementsByClassName("close")[0];

botonCerrar.addEventListener('click', cerrarConBoton);
botonNo.addEventListener('click', cerrarConBoton);

botonTerminar.addEventListener('click', abrirVentanaTerminar);
botonCancelar.addEventListener('click', abrirVentanaCancelar);

function cerrarConBoton() {
    ventanaCancelar.style.display = "none";
}

function abrirVentanaTerminar() {
    ventanaTerminar.style.display = "block";
}

function abrirVentanaCancelar() {
    ventanaCancelar.style.display = "block";

    //Mientras este abierta la ventana, es posible cerrarla con click en ventana
    window.onclick = function (event) {
        if (event.target == ventanaCancelar) {
            ventanaCancelar.style.display = "none";
        }
    }
}