namespace Max_Method
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int output = GetMax(a, b, c);

            Console.WriteLine(output);
        }

        private static int GetMax(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c) { return a; }
                else { return c; }
            }
            else if(a < b)
            {
                if(b>c) { return b; }
                else { return c; }
            }
            else { return 0; }
        }

    }
}
