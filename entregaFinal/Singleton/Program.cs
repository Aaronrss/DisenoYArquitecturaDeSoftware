// Create singleton class for a government
namespace GovernmentSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Government government1 = Government.GetInstance();
            // Read name from user
            Console.Write("Enter government name: ");
            government1.SetData(Console.ReadLine());
            Console.WriteLine(government1);
            Console.WriteLine("Esta es la primera instancia de gobierno llamandola como government2");
            Government government2 = Government.GetInstance();
            Console.WriteLine(government2);
        }
    }
}