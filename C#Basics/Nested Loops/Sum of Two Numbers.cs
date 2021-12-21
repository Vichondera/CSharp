using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            int startN = int.Parse(Console.ReadLine());
            int endN = int.Parse(Console.ReadLine());
            int magicN = int.Parse(Console.ReadLine());
            
            int combinations = 0;
            bool isFound = false;

            for (int x = startN; x <= endN; x++)
            {
                for (int y = startN; y<= endN; y++)
                {
                    combinations++;
                    if (x + y == magicN)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({x} + {y} = {magicN})");
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                    break;
            }

            if (isFound == false)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicN}");
            }
        
        }
    }
}
