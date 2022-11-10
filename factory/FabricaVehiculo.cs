namespace MetodoFabrica
{
    internal class FabricaVehiculo
    {
        internal static IVehiculo CrearVehiculo(int dinero)
        {
            IVehiculo _vehiculo = null;
            if (dinero > 100000)
            {
                _vehiculo = new Auto();
            }
            else if (dinero > 50000)
            {
                _vehiculo = new Moto();
            }
            else
            {
                _vehiculo = new Bicicleta();
            }
            return _vehiculo;
        }
    }
}