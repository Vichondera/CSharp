namespace Integer_Numbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // -100
            Console.WriteLine(sbyte.Parse(Console.ReadLine()));
            // 128
            Console.WriteLine(byte.Parse(Console.ReadLine()));
            // - 3540
            Console.WriteLine(short.Parse(Console.ReadLine()));
            // 64876
            Console.WriteLine(long.Parse(Console.ReadLine()));
            // 2147483648
            Console.WriteLine(Int64.Parse(Console.ReadLine()));
            // - 1141583228
            Console.WriteLine(double.Parse(Console.ReadLine()));
            // - 1223372036854775808
            Console.WriteLine(decimal.Parse(Console.ReadLine()));
        }
    }
}
