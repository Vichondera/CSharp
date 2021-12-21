namespace Cinema
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            double input = 0.0;
            
            if (type == "Premiere")
            {
                input = (r * c) * 12.00;
                Console.WriteLine($"{input:F2} leva");
            }
            else if (type == "Normal")
            {
                input = (r * c) * 7.50;
                Console.WriteLine($"{input:F2} leva");
            }
            else  if (type == "Discount")
            {
                input = (r * c) * 5.00;
                Console.WriteLine($"{input:F2} leva");
            }
            
        }
    }
}
