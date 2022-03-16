using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"[#][A-Z]\w+[#][0-9]+[\/][0-9]+[\/][0-9]+[#][0-9]+[#]|[|][A-Z]\w+[|][0-9]+[\/][0-9]+[\/][0-9]+[|][0-9]+[|]|[#][A-Za-z]+[ ][A-Za-z]+[#][0-9]+[\/][0-9]+[\/][0-9]+[#][0-9]+[#]";
            Regex rg = new Regex(pattern);
            MatchCollection matches = rg.Matches(input);

            int totalCalories = 0;
            int days = 0;

            string[] output = new string[matches.Count];
            var sb = new StringBuilder();

            foreach (var item in matches)
            {
                string product = item.ToString();
                char splitter = product[0];
                var splitted = product.Split(splitter,StringSplitOptions.RemoveEmptyEntries);

                    totalCalories += int.Parse(splitted[2]);
                    sb.AppendLine($"Item: {splitted[0]}, Best before: {splitted[1]}, Nutrition: {splitted[2]}");
            }

            Console.WriteLine($"You have food to last you for: {(totalCalories / 2000)} days!");
            Console.WriteLine(sb.ToString());
        }
    }
}
