namespace _06Solary
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabs; i++)
            {
                string https = Console.ReadLine();
                switch (https)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    break;
                }
            }
            
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
            
        }
    }
}
