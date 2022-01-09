namespace RegEx
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+");

            string input = Console.ReadLine();

            var rx = new Dictionary<string, List<string>>();

            bool isReg = regex.IsMatch(input);
            Console.WriteLine(isReg);

            if (isReg && !rx.ContainsKey(input))
            {
                rx.Add(input, new List<string>());
                rx[input].Add(input);
            }
        }
    }
}
