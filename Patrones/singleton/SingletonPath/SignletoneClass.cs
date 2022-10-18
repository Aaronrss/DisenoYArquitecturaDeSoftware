    internal class Singleton
    {
        internal static Singleton? _instance;
        public static Singleton? Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                Console.WriteLine("Se creo una nueva instancia");
            }
            return _instance;
        }
    }