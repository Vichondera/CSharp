namespace mile2km
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            float miles = float.Parse(Console.ReadLine());

            var output = miles * 1.60934;

            Console.WriteLine($"{output:f2}");
        }
    }
}
