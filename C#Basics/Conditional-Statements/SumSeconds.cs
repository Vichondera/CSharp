namespace SumSeconds
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int frst = int.Parse(Console.ReadLine());
            int scnd = int.Parse(Console.ReadLine());
            int thrd = int.Parse(Console.ReadLine());

            int sum = frst + scnd + thrd;

            int min = sum / 60;
            int sec = sum % 60;

            Console.Write(min);

            if (sec < 10)
            {
                Console.WriteLine(":0"+sec);
            }
            else
            {
                Console.WriteLine(":"+sec);
            }
            
        }
    }
}
