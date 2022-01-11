namespace RectangleArea
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            
            Console.WriteLine($"{(a*b):f2}");
        }
    }
}
