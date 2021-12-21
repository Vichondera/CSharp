namespace SmallShop
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            
            double price = 0;
            
            if (city == "Sofia")
            {
                if (drink == "coffee")
                {
                    price = count * 0.50;
                }
                else if (drink == "water")
                {
                    price = count * 0.80;
                }
                else if (drink == "beer")
                {
                    price = count * 1.20;
                }
                else if (drink == "sweets")
                {
                    price = count * 1.45;
                }
                else if(drink == "peanuts")
                 {
                    price = count * 1.60;
                }
            }
            else if (city == "Plovdiv")
            {
                if (drink == "coffee")
                {
                    price = count * 0.40;
                }
                else if (drink == "water")
                {
                    price = count * 0.70;
                }
                else if (drink == "beer")
                {
                    price = count * 1.15;
                }
                else if (drink == "sweets")
                {
                    price = count * 1.30;
                }
                else if (drink == "peanuts")
                  {
                    price = count * 1.50;
                }
            }
            else if (city == "Varna")
            {
                if (drink == "coffee")
                {
                    price = 0.45 * count;
                }
                else if (drink == "water")
                {
                    price = count * 0.70;
                }
                else if (drink == "beer")
                {
                    price = count * 1.10;
                }
                else if (drink == "sweets")
                {
                    price = count * 1.35;
                }
                else if (drink == "peanuts")
                {
                    price = count * 1.55;
                }
            }
            
            Console.WriteLine($"{price:F2}");
        }
    }
}
