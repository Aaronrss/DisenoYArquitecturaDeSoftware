// See https://aka.ms/new-console-template for more information

namespace Patrones
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /* 
            Singleton? s1 = Singleton.Instance();
            Singleton? s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Son la misma instancia");
            }
            else
            {
                Console.WriteLine("Son diferentes instancias");
            }
            */
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Son la misma instancia");
            }

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Request: " + server);
            }
        }
    }
}