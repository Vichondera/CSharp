namespace Calculations
{
    using System;

    class Program
    {
               static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (input)
            {
                case "add":
                    Console.WriteLine(Added(a, b));
                    break;
                case "multiply":
                    Console.WriteLine(Multiplied(a, b));
                    break;
                case "subtract":
                    Console.WriteLine(Subtracted(a, b));
                    break;
                case "divide":
                    Console.WriteLine(Divided(a, b));
                    break;
            }
        }

        private static int Added(int a, int b)
        {
            return a + b;
        }

        private static int Multiplied(int a, int b)
        {
            return a * b;
        }

        private static int Subtracted(int a, int b)
        {
            return a - b;
        }

        private static int Divided(int a, int b)
        {
            return a / b;
        }
    
    }
}
