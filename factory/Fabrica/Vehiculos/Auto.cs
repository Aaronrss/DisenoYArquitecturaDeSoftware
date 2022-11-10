namespace MetodoFabrica
{
    internal class Auto : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("El auto esta acelerando");
        }
        public void Encender()
        {
            Console.WriteLine("El auto esta encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("El auto esta apagado");
        }
        public void Frenar()
        {
            Console.WriteLine("El auto esta frenando");
        }

    }
}