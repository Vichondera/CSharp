namespace Employee
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            double id = double.Parse(Console.ReadLine());
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {number}");
        }

    }
}
