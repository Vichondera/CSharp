namespace bonus
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            double bonus = 0;
            
            if (num < 100)
            {
                bonus = bonus + 5;
            }
            else if (num > 1000)
            {
                bonus = bonus + num * 10.0 / 100;
            }
            else
            {
                bonus = bonus + num * 20.0 / 100;
            }
            
            bool even = num % 2 == 0;
            
            if (even)
            {
                bonus = bonus + 1;
            }
            
            int m = num % 10;
            
            if (m == 5)
            {
                bonus = bonus + 2;
            }
            
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
            
        }
    }
}
