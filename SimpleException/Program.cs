using System;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Helga", 20);
            myCar.CrankTunes(true);
            try {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error happened.");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }
            Console.ReadKey(true);
        }
    }
}
