namespace Make_a_Word
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int n = 0; n < N; n++)
            {
                char ch = char.Parse(Console.ReadLine());

                output += ch;
            }

            Console.WriteLine($"The word is: {output}");
        }
    }
}
