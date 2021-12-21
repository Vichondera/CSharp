namespace WorldSwimmingRecord
{
   using System;
   
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double dist = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            
            double time = dist * speed;
            time += Math.Floor(dist / 15) * 12.5;
            
            double diff = record - time;
            
            if (diff <= 0)
            {
                diff = Math.Abs(diff);
                Console.WriteLine($"No, he failed! He was {diff:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
            
        }
    }
}
