namespace ZigZag_Arrays
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var firstArr = new string[N];
            var secondArr = new string[N];

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(" ");
                var first = input[0];
                var second = input[1];

                if(i % 2 == 0)
                {
                    firstArr[i] = first;
                    secondArr[i] = second;
                }
                else
                {
                    firstArr[i] = second;
                    secondArr[i] = first;
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
