namespace _Count_Real_N
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
           
            var numbersAssArray = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbersAssArray.Length; i++)
            {
                if(!numbers.ContainsKey(numbersAssArray[i]))
                {
                    numbers.Add(numbersAssArray[i], 0);
                }

                numbers[numbersAssArray[i]]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
