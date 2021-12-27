namespace Reverse
{
    using System;
  
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                arr[i] = input;
            }

            Console.WriteLine(string.Join(",",arr));
        }
    }
}
