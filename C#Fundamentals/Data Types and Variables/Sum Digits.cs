namespace SumDigits
{
    using System;
    // SOLUTION I
    // int input = int.Parse(Console.ReadLine());
    // int sum = 0;

    // while (input != 0)
    // {
    //     sum += input % 10;
    //     input /= 10;
    // }
    // Console.WriteLine(sum);
    class Program
    {
        static void Main(string[] args)
        {       //  SOLUTION II
            string str = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                sum += int.Parse(str[i].ToString());
            }

            Console.WriteLine(sum);
        }
          
    }
}
