namespace CommonElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(" ").ToArray();
            var secondArr = Console.ReadLine().Split(" ").ToArray();

            var output = string.Empty;

            for (int i = 0; i < secondArr.Length; i++)
            {
                var current = secondArr[i];

                for (int j = 0; j < firstArr.Length; j++)
                {
                    if(current == firstArr[j])
                    {
                        output += " " + current;
                    }
                }
            }
            
            Console.WriteLine(output);
        }
    }
}
