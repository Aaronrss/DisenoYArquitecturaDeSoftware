namespace PatronSingleton
{
    internal class Singleton
    {
        private static Singleton _instance;
        private string nombre;
        private int edad;
        private Singleton()
        {
            nombre = "";
            edad = 0;
        }

        internal static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                Console.WriteLine("Conectando a la base de datos...");
            }
            else
            {
                Console.WriteLine("Ya existe una instancia.");
            }
            return _instance;
        }
        internal void SetData(string _nombre, int _edad)
        {
            nombre = _nombre;
            edad = _edad;
        }
        internal void ProcessA()
        {
            Console.WriteLine("Proceso A podemos ver todos los datos de la interfaz");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Proceso A terminado");
            Console.WriteLine("------------------------------------------------");
        }
    }
}