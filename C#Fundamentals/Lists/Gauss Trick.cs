namespace  GaussTrick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(" ").ToList().Select(int.Parse).ToList();

            int arrLenght = integers.Count;

            for (int i = 0; i < arrLenght / 2; i++)
            {
                integers[i] += integers[integers.Count - 1];
                integers.RemoveAt(integers.Count - 1);
            }
            
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
