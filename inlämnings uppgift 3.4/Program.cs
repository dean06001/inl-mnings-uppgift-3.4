using System;
namespace inlämnings_uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter lång är din låt");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("hur många sekunder lång är din låt");
            int sekunder = int.Parse(Console.ReadLine());
            if ((minuter >= 2 && sekunder >= 45) || (minuter <= 4 && sekunder <= 20))
            {
                Console.WriteLine("Din kan spelas på radion");
            }
            else if ((minuter >= 4 && sekunder >= 20) || (minuter > 4 && sekunder <= 20))
            {
                Console.WriteLine("din låt får inte spelas");
            }
            else
            {
                Console.WriteLine("din låt är för kort");
            }
            Console.ReadKey();
        }
    }
}