namespace SignNums
{
    using System;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int num = NumSign(input);
        }

        private static int NumSign(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if(num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }

            return num;
        }

    }
}
