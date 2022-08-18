namespace BaristaContest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> readyDrinks = new Dictionary<string, int>()
            { {"Cortado",0 },{"Espresso",0 }, {"Capuccino",0 },{"Americano",0 },{"Latte",0 } };

            var coffee = new Queue<int>(Console.ReadLine()
                   .Split(", ")
                   .Select(int.Parse)
                   .ToArray());
            var milk = new Stack<int>(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray());

            while (true)
            {
                if (coffee.Count == 0 || milk.Count == 0)
                {
                    break;
                }

                int coffeValue = coffee.Peek();
                int milkValue = milk.Peek();

                int sumOfValues = coffeValue + milkValue;
                if(sumOfValues == 50)
                {
                    readyDrinks["Cortado"]++;
                    RemoveCurrentQuantities(coffee, milk);
                }
                else if (sumOfValues == 75)
                {
                    readyDrinks["Espresso"]++;
                    RemoveCurrentQuantities(coffee, milk);
                }
                else if (sumOfValues == 100)
                {
                    readyDrinks["Capuccino"]++;
                    RemoveCurrentQuantities(coffee, milk);
                }
                else if (sumOfValues == 150)
                {
                    readyDrinks["Americano"]++;
                    RemoveCurrentQuantities(coffee, milk);
                }
                else if (sumOfValues == 200)
                {
                    readyDrinks["Latte"]++;
                    RemoveCurrentQuantities(coffee, milk);
                }
                else
                {
                    RemoveCurrentQuantities(coffee, milk);
                    int newMilkValue = milkValue - 5;
                    milk.Push(newMilkValue);
                }
                
            } // END WHILE LOOP

            // Output
            // first line
           if(coffee.Count == 0 && milk.Count == 0)
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
           else
                Console.WriteLine("Nina needs to exercise more! " +
                    "She didn't use all the coffee and milk!");

            // second line
            if(coffee.Count == 0)
                Console.WriteLine("Coffee left: none");
            else
                Console.WriteLine($"Coffee left: {string.Join(", ",coffee)}");
            
            // third line
            if(milk.Count == 0)
                Console.WriteLine("Milk left: none");
            else
                Console.WriteLine($"Milk left: {string.Join(", ",milk)}");

            // last line
            foreach (var drink in readyDrinks
                .OrderBy(d => d.Value)
                .ThenByDescending(n=>n.Key)
                .Where(a => a.Value > 0))
            {
                Console.WriteLine($"{drink.Key}: {drink.Value}");
            }
        }

        private static void RemoveCurrentQuantities(Queue<int> coffee, Stack<int> milk)
        {
            coffee.Dequeue();
            milk.Pop();
        }
    }
}
