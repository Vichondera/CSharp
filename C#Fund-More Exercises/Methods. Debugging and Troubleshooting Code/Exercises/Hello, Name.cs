namespace HelloName
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
           
            Console.WriteLine(PrintWelcomeMsg(name));
        }

        private static string PrintWelcomeMsg(string name)
        {
            return $"Hello, {name}!";
        }

    }
}
