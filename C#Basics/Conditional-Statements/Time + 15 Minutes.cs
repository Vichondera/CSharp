namespace P05
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
 
            int dop = b + 15;
            int min = dop % 60;
 
            if (dop >= 60)
            {
                hour = hour + 1;
 
                if (hour > 23)
                {
                    hour = hour - 24;
                }
            }
 
            if (min < 10)
            {
                Console.WriteLine(hour + ":0" + min);
            }
            else
            {
                Console.WriteLine(hour + ":" + min);
            }
            
        }
    }
}
