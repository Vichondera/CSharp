namespace GodzillaVSKong
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int ext = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            
            double decor = budget * 0.10;
            double clothingMoney = ext * clothingPrice;
            
            if (ext > 150)
            {
                clothingMoney = clothingMoney - clothingMoney * 0.10;
            }
            
            double diff = budget - (clothingMoney + decor);
            
            if (diff >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:F2} leva left.");
            }
            else
            {
                diff = Math.Abs(diff);
                
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {diff:F2} leva more.");
            }

        }
    }
}
