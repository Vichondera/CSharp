namespace _01
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            List<int> result = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (int.Parse(input[i]) > 0)
                {
                    result.Add(int.Parse(input[i]));
                }
            }

            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
