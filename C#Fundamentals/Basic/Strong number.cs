namespace StrongNumber
{
    using System;
    
    class Program
    {
        static void Main()
        {
            // Input
            var n = int.Parse(Console.ReadLine());

            // AntiLogic
            var nCopy = n;
            var sum = 0;

            while (n > 0)
            {
                var factoriel = 1;
                var number = n % 10;
                n /= 10;

                for (int i = 2; i <= number; i++)
                {
                    factoriel *= i;
                }

                sum += factoriel;
            }

            // Output
            if (sum == nCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        
        }
    }
}
