var arrayProductos = [];


function agregarProducto(nombre) {
    
    var producto = {};
    var monto =0;
    producto.nombre = nombre;
    switch (nombre) {
        case "JUGO":
            monto = 10;
            break;
        case "PAPITAS":
            monto = 12;
            break;
        case "ATUN":
            monto = 8;
            break;
        case "COCA":
            monto = 25;
            break;
        case "GALLETAS":
            monto = 13;
            break;
        case "NACHOS":
            monto = 18;
            break;
        case "TACOS":
            monto = 25;
            break;
        case "HAMBURGESAS":
            monto = 30;
            break;
        case "HOTDOGS":
            monto = 20;
            break;
    }
    producto.monto = monto;
    
    if (arrayProductos.length == 0) {
        producto.cantidad = 1;
        arrayProductos.push(producto);
    }
    else {
        var existe = true;
        for (var i = 0; i < arrayProductos.length; i++) {
            if (arrayProductos[i].nombre == nombre) {
                arrayProductos[i].cantidad += 1;
                existe = false;
                break;
            }
        }
        if (existe) {
            producto.cantidad = 1;
            arrayProductos.push(producto);
            
        }
    }
    console.log(arrayProductos);



}

function quitarProducto(nombre) {
    for (var i = 0; i < arrayProductos.length; i++) {
        if (arrayProductos[i].nombre == nombre && arrayProductos[i].cantidad >0) {
            arrayProductos[i].cantidad -= 1;
            existe = false;
            break;
        }
    }

}

function mostrarFactura() {
    var t1 = document.getElementById("factura");
    for (var i = 0; i < t1.childNodes.length; i++) {
        t1.removeChild(t1.childNodes[0]);
    }
    for (var i = 0; i < arrayProductos.length; i++) {
        if (arrayProductos[i].cantidad > 0) {
            var d = document.createElement("li");
            d.id = "prod_" + i;
            d.innerHTML += "<input type='text' name=" + 'name_' + i + " value =" + arrayProductos[i].nombre + " />";
            d.innerHTML += "<input type='text' name=" + 'number_' + i + " value =" + (arrayProductos[i].cantidad * arrayProductos[i].monto) + " />";
            t1.appendChild(d);
        }
    }
}
