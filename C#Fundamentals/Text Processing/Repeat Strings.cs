namespace RepeatStrs
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            StringBuilder overAndOver = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var counts = input[i].Length;

                for (int j = 0; j < counts; j++)
                {
                    overAndOver.Append(input[i]);
                }
            }

            Console.WriteLine(overAndOver);
        }
    }
}
