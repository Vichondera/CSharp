namespace Sum_Of_Chars
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int n = 0; n < N; n++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
