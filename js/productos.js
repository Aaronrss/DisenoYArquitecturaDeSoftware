class Productos{
    productos = ["piña","manzana"]
    existeProducto(producto){
        // Funcion interna de js que me ayuda a buscar dentro de un arreglo
        return this.productos.indexOf(producto) !== -1;
    }

    agregar(producto){
        this.productos.push(producto)
    }
}

var p = new Productos();

console.log(p.existeProducto("sandia"))
console.log(p.existeProducto("piña"))
p.agregar("sandia", "melon")