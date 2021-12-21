namespace CinemaTicket
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            // чете ден от седмицата (текст) и принтирa цената на билетa според деня от седмицата:
            string day = Console.ReadLine();
            
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16);
                    break;
            }
            
        }
    }
}
