namespace IntegerOperations
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var firstInt = int.Parse(Console.ReadLine());
            var secondInt = int.Parse(Console.ReadLine());
            var thrdInt = int.Parse(Console.ReadLine());
            var fourthInt = int.Parse(Console.ReadLine());

            var result = ((firstInt + secondInt) / thrdInt) * fourthInt;

            Console.WriteLine(result);
        }
    }
}
