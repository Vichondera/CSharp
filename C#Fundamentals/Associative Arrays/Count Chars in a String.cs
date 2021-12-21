namespace CountChars
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string lett = input[i];

                for (int j = 0; j < lett.Length; j++)
                {
                    if (letters.ContainsKey(lett[j]))
                    {
                        letters[lett[j]]++;
                    }
                    else
                    {
                        letters.Add(lett[j], 1);
                    }
                }
            }

            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
