namespace Math_Power
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = GetResult(a, b);

            Console.WriteLine(result);
        }

         static double GetResult(double a, double b)
        {
            double result = a;
            for (int i = 1; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
        
    }
}
