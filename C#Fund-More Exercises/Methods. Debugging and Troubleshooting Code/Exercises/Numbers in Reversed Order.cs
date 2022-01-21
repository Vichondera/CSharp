namespace Numbers_in_Reversed_Order
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ReverseIt(input);
        }

        private static void ReverseIt(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
        
    }
}
