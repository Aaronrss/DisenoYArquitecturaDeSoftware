class CrearAuto{
    
    constructor(marca, modelo){
        this.marca = marca;
        this._modelo = modelo;
    }
    //setMarca
    guardarMarca(marca){
        //
        this.marca = marca;
    }
    
    obtenerMarca(){
        return this.marca;
    }

    //setModelo
    set modelo(modelo){
        this._modelo = modelo;
    }
    //getModelo
    get modelo(){
        return this._modelo;
    }
    //setRines
    
    //setColor
}

//CrearAuto.marca = "Nissan"
var auto = new CrearAuto()
auto.marca = "Nissan"
auto.modelo = 2017

console.log(auto.obtenerMarca())

console.log(auto.modelo())