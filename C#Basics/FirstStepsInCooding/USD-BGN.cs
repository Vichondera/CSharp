namespace USDtoBGN
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Solution 1

            // bgn = 1.79549;
            // double usd = double.Parse(Console.ReadLine());
            // Console.WriteLine(usd * 1.79549);
            
            // Solution 2

            double bgn = 1.79549;
            double usd = double.Parse(Console.ReadLine()) * bgn;
            Console.WriteLine(usd);
            // Console.WriteLine(usd * bgn);
        }
    }
}
