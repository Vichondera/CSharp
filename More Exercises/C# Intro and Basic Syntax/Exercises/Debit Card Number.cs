namespace DebitCardNumber
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            var output = string.Empty;

            const int len = 4;

            for (int index = 0; index < len; index++)
            {
                 input = Console.ReadLine();

                if (input.Length < len)
                {
                    int diff = len - input.Length;
                    var temp = string.Empty;

                    for (int i = 0; i < diff; i++)
                    {
                        temp += "0";
                    }

                    for (int j = 0; j < input.Length; j++)
                    {
                        temp += input[j];
                    }
                    output += temp + " ";
                }
                else
                {
                    output += input + " ";
                }
            }
       
            Console.WriteLine(output);
        }
    }
}
