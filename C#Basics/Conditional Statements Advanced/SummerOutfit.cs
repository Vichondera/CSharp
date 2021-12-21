namespace SummerOutfit
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int deg = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            
            string outfit = "";
            string shoes = "";
            
            if (deg >= 10 && deg <=18)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (deg >= 18 && deg <= 24)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (deg >= 25)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
                }
            }
            
        }
    }
}
