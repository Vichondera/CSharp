namespace ExamPreparation
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int failsCounter = 0, solved = 0;
            
            double avarge = 0;
            string last = "";

            bool isFail = true;

            int failLimit = int.Parse(Console.ReadLine());

            while (failsCounter < failLimit)
            {
                string name = Console.ReadLine();
                
                if (name == "Enough")
                {
                    isFail = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                if(grade <=4)
                {
                    failsCounter++;
                }
                solved++;
                avarge += grade;
                last = name;
            }

            if (isFail)
            {
            Console.WriteLine($"You need a break, {failsCounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(avarge/solved):f2}");
                Console.WriteLine($"Number of problems: {solved}");
                Console.WriteLine($"Last problem: {last}");
            }
            
        }
    }
}
