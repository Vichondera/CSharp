namespace ex
{
    using System;
    
    class Program
    {
        public static void Main(string[] args)
        {

            var groupNumber = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var weekDay = Console.ReadLine();

            // AntiLogic
            var price = 0.00;

            if(weekDay == "Friday")
            {
                if(groupType == "Students")
                {
                    price = 8.45;
                }
                else if(groupType == "Business")
                {
                    price = 10.90;
                }
                else  if(groupType == "Regular")
                {
                    price = 15;
                }
            }
            else if (weekDay == "Saturday")
            {
                if (groupType == "Students")
                {
                    price = 9.80;
                }
                else if (groupType == "Business")
                {
                    price = 15.60;
                }
                else if (groupType == "Regular")
                {
                    price = 20;
                }
            }
            else if (weekDay == "Sunday")
            {
                if (groupType == "Students")
                {
                   price = 10.46;
                }
                else if (groupType == "Business")
                {
                   price = 16;
                }
                else if (groupType == "Regular")
                {
                    price = 22.50;
                }
            }

            var totalPrice = price * groupNumber;
            
            if(groupNumber >= 30 && groupType == "Students")
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if(groupNumber >= 100 && groupType == "Business")
            {
                totalPrice -= price * 10;
            }
            else if(groupNumber >= 10 && groupNumber <= 20
             && groupType == "Regular")
            {
                totalPrice -= totalPrice * 0.05;
            }
          
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
