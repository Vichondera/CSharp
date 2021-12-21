using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int H = 0; H <= 23; H++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{H}:{m}");
                }
            }
            
        }
    }
}
