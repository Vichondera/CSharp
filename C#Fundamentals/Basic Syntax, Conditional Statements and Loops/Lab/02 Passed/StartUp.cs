namespace Passed
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            if(num >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
