using System;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that:
            // Reads an array of integers and adds them to a queue
            int[] input = Console.ReadLine().Split(" ")
                .Select(int.Parse).Where(x => x % 2 == 0).ToArray();

            // Prints the even numbers separated by ", "
            Console.WriteLine(string.Join(", ", input));

        }
    }
}
