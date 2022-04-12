namespace BakerySHop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var waterAmount = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            var flourAmount = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Queue<double> water = new Queue<double>(waterAmount);
            Stack<double> flour = new Stack<double>(flourAmount);

            Dictionary<string, double> readyProducts = new Dictionary<string, double>();
            double waterPerc = 0.00;
            Products(readyProducts);

            while (true)
            {
                if (water.Count == 0 || flour.Count == 0) break;

                var currWater = water.Peek();
                var currFlour = flour.Peek();

                waterPerc = PercentageCalculator(currWater, currFlour);
                if(waterPerc == 50)
                {
                    water.Dequeue();
                    flour.Pop();
                    readyProducts["Croissant"]++;
                }
                else if(waterPerc == 40)
                {
                    water.Dequeue();
                    flour.Pop();
                    readyProducts["Muffin"]++;
                }
                else if(waterPerc == 30)
                {
                    water.Dequeue();
                    flour.Pop();
                    readyProducts["Baguette"]++;
                }
                else if(waterPerc == 20)
                {
                    water.Dequeue();
                    flour.Pop();
                    readyProducts["Bagel"]++;
                }
                else
                {
                    var result = currFlour - currWater;

                    flour.Pop();
                    flour.Push(result);
                    water.Dequeue();

                    readyProducts["Croissant"]++;
                }
            }

            foreach (var item in readyProducts.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
            {
                if(item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            var flourLeft = flour.Count == 0 ? "None" : string.Join(", ", flour);
            var waterLeft = water.Count == 0 ? "None" : string.Join(", ", water);

            Console.WriteLine($"Water left: {waterLeft}");
            Console.WriteLine($"Flour left: {flourLeft}");
        }

        private static void Products(Dictionary<string, double> readyProducts)
        {
            readyProducts.Add("Baguette", 0);
            readyProducts.Add("Bagel", 0);
            readyProducts.Add("Croissant", 0);
            readyProducts.Add("Muffin", 0);
            
        }

        private static double PercentageCalculator(double currWater,double currFlour)
        {
            var currValue = currWater + currFlour;
            var waterPerc = (currWater * 100) / currValue;
          
            return waterPerc;
        }
    }
}
