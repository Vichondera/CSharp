namespace race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^>>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)$");

            Dictionary<string, int> racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            Regex nameRegex = new Regex(@"[A-Za-z]+");
            Regex digitsRegex = new Regex(@"\d");

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of race")
                {
                    break;
                }
                MatchCollection letterMatches = nameRegex.Matches(line);
                MatchCollection digitsMatches = digitsRegex.Matches(line);

                string name = GetName(letterMatches);
                int sum = GetSum(digitsMatches);

                if (!racers.ContainsKey(name))
                {
                    continue;
                }

                racers[name] += sum;
            }

            string[] win = racers
                .OrderByDescending(r => r.Value)
                .Take(3)
                .Select(r => r.Key)
                .ToArray();

            Console.WriteLine($"1st place: {win[0]}");
            Console.WriteLine($"2nd place: {win[1]}");
            Console.WriteLine($"3rd place: {win[2]}");
        }

        private static int GetSum(MatchCollection digitMatches)
        {
            int sum = 0;
            foreach (Match match in digitMatches)
            {
                sum += int.Parse(match.Value);
            }
            return sum;
        }

        private static string GetName(MatchCollection matches)
        {
            StringBuilder stringB = new StringBuilder();

            foreach (Match match in matches)
            {
                stringB.Append(match.Value);
            }

            return stringB.ToString();
        }
    }
}
