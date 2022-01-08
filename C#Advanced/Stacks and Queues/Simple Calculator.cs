using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            Stack<int> addToSum = new Stack<int>();
            Stack<int> SubsFromSum = new Stack<int>();

            Func<int, int, string> func = Sum;
            int num = int.Parse(input[0]);
            addToSum.Push(num);

            for (int n = 2, o = 1; o < input.Length; n += 2, o += 2)
            {
                var oper = input[o];
                num = int.Parse(input[n]);

                if (oper == "+")
                { addToSum.Push(num); }
                else { SubsFromSum.Push(num); }
            }

            int a, b;
            GetSums(addToSum, SubsFromSum, out a, out b);

            string result = func(a, b);
            Console.WriteLine(result);
        }


        public static void GetSums(Stack<int> addToSum, Stack<int> SubsFromSum, out int a, out int b)
        {
            var sumA = addToSum.ToArray();
            var sumB = SubsFromSum.ToArray();

            a = sumA.Sum();
            b = sumB.Sum();
        }


        public static string Sum(int a, int b)
        {
            int result = a - b;
            return result.ToString();
        }
    }
}
