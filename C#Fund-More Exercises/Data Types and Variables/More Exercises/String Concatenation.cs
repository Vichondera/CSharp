namespace String_Concatenation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());

            string output = string.Empty;
            for (int n = 0; n < N; n++)
            {
                bool isEven = n  % 2 == 0;
                string input = Console.ReadLine();

                if (type == "odd")
                {
                    if(isEven)
                    {
                        output += input + delimiter;
                    }
                }
                else if (type == "even")
                {
                    if(!isEven)
                    {
                        output += input + delimiter;
                    }
                }
            }
            Console.WriteLine(output.Trim(delimiter));
        }
    }
}
