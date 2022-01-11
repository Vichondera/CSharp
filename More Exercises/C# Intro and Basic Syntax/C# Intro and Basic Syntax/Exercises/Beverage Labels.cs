namespace BeverageLabels
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            double energy = int.Parse(Console.ReadLine());
            double sugar = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {productName}:");

            double totalEnergy = (energy * volume) / 100;
            double totalSugar = sugar * volume;
            
            Console.WriteLine($"{totalEnergy:f2}kcal," +
                $" {(totalSugar / 100):f2}g sugars");
        }
    }
}
