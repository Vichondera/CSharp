namespace Sign_of_Integer_Number
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            PrintSign(integer);
        }

         static void PrintSign(int integer)
        {
            if(integer == 0)
            {
                Console.WriteLine($"The number {integer} is zero.");
            }
            else if(integer > 0)
            {
                Console.WriteLine($"The number {integer} is possitive.");
            }
            else
            {
                Console.WriteLine($"The number {integer} is negative.");
            }
        }

    }
}
