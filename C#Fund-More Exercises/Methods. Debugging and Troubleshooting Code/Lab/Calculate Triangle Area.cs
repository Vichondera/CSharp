namespace Calculate_Triangle_Area
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double result = GetArea(width, heigth);

            Console.WriteLine(result);
        }

         static double GetArea(double width, double heigth)
        {
            return width * heigth / 2;
        }
        
    }
}
