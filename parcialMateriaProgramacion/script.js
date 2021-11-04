function validarForm() {
    let numCliente = document.getElementById("txtNumCliente");
    if (numCliente.value === "") {
        alert("Ingrese el número de Cliente");
        return false;
    }

    if (isNaN(numCliente.value)) {
        alert("Ingrese solamente números en el campo Número de Cliente");
        return false;
    }

    let correoCliente = document.getElementById("txtCorreo");
    if (correoCliente.value === "") {
        alert("Ingrese su correo electrónico");
        return false;
    }

    return true;
}

function enviar() {
    if (validarForm()) {
        let cliente = document.getElementById("txtNumCliente").value;
        alert("Pedido registrado correctamente para el cliente: " + cliente);
    } else {
    }
}