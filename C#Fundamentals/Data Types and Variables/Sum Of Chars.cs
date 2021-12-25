namespace SumOfChars
{
    using System;
  
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var sum = 0;

            for (var i = 0; i < N; i++)
            {
                var ch = char.Parse(Console.ReadLine());
                sum += ch;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
