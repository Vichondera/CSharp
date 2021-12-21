namespace PasswordGuess
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string cPass = "s3cr3t!P@ssw0rd";

            if (pass == cPass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
