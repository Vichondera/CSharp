namespace Temperature_Conversion
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = 0;
            ConvertToCelsius(fahrenheit,celsius);
        }

         static void ConvertToCelsius(double fahrenheit, double celsius)
        {
            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{celsius:f2}");
        }
    }
}
