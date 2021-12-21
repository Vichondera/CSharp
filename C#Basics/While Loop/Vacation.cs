namespace Vacation
{
    using System;
    
    class Program
    {
        public static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            
            int days = 0;
            double failsCounter = 0;

            while (savedMoney < needMoney && failsCounter < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (action == "save") 
                {
                    savedMoney += money;
                    failsCounter = 0; 
                }
                
                if (action == "spend")
                {
                    savedMoney -= money;
                    failsCounter++;
                    if(savedMoney <= 0)
                    {
                        savedMoney = 0;
                    }
                }
            }

            if (savedMoney >= needMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            
        }
    }
}
