namespace PetShop
{
    using System;
    
    class Program

    {
        static void Main(string[] args)
        {
            // Solution 1
            double numDogs = double.Parse(Console.ReadLine());
            double dogPrice = numDogs * 2.5;
            
            double numOlth = double.Parse(Console.ReadLine());
            double olthPrice = numOlth * 4;
            
            double price = dogPrice + olthPrice;
            Console.WriteLine($"{price} lv.");
            
            // Solution 2
            // double dogs = double.Parse(Console.ReadLine()) * 2.5;
            // double olthers = double.Parse(Console.ReadLine()) * 4;
            
            // Console.WriteLine($"{(dogs + olthers)} lv.");
        }
    }
}
