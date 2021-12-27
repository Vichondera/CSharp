namespace Rotation
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
           
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                var moveToEnd = input[0];
                
                for (var i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }
                input[input.Length - 1] = moveToEnd;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
