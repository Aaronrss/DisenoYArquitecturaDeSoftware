// See https://aka.ms/new-console-template for more information
namespace PatronSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            s1.SetData("Aaron", 25);
            s1.ProcessA();

            Singleton s2 = Singleton.GetInstance();
            s2.SetData("Juan", 30);
            s2.ProcessA();
        }
    }
}