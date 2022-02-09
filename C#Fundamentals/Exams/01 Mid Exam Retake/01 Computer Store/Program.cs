namespace ComputerStore
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool calculate = false;

            decimal total = 0.00M;
            decimal taxes = 0.00M;
            decimal totalPrice = 0.00M;

            while (!calculate)
            {
                string input = Console.ReadLine();
                if (input == "special" || input == "regular")
                {
                    taxes = total * 0.20M;
                    totalPrice = total + taxes;

                    if (input == "special")
                    {
                        totalPrice -= totalPrice * 0.10M;
                    }

                    calculate = true;
                    break;
                }

                decimal price = decimal.Parse(input);
                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    total += price;
                }
            }

            if (totalPrice > 0)
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
