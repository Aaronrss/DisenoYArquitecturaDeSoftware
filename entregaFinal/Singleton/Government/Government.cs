namespace GovernmentSpace
{
    class Government
    {
        private static Government instance;
        private string name;
        private Government()
        {
            name = "--";
        }
        public static Government GetInstance()
        {
            if (instance == null)
            {
                instance = new Government();
                Console.WriteLine("Government created without name");
            }
            else
            {
                Console.WriteLine("Government already created");
            }
            return instance;
        }
        public override string ToString()
        {
            return string.Format("El gobierno de {0}, tiene duración de seis años.", name);
        }
        public void SetData(string name)
        {
            this.name = name;
        }
    }
}