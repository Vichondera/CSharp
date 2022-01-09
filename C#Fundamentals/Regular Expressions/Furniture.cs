using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^>>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)$");

            List<string> results = new List<string>();
            double total = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Purchase")
                {
                    break;
                }

                Match match = regex.Match(input);
                if(!match.Success)
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int qty = int.Parse(match.Groups["quantity"].Value);

                results.Add(name);
                total += qty * price;
            }

            Console.WriteLine("Bought furniture: ");
            foreach (var item in results)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
