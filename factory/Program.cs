namespace MetodoFabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la fabrica!");
            string dato;
            int dinero;
            IVehiculo vehiculo;
            Console.WriteLine("Ingrese el dinero que tiene");
            //dato = Console.ReadLine();
            dato = "100000";
            dinero = Convert.ToInt32(dato);
            vehiculo = FabricaVehiculo.CrearVehiculo(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Apagar();
        }
    }
}