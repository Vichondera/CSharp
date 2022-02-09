using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int waiting = int.Parse(Console.ReadLine());

            var currStatus = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToList();
           
            int limit = 4;
            int total = currStatus.Sum(x => Convert.ToInt32(x));

            var busySpots = 0;

            for (int i = 0; i < currStatus.Count; i++)
            {
                busySpots = currStatus[i];
                var freeSpots = 0;
                if (busySpots < limit)
                {
                    freeSpots = limit - busySpots;
                    if (freeSpots > waiting)
                    {
                        currStatus.RemoveAt(i);
                        currStatus.Insert(i, (busySpots + waiting));
                    }
                    else
                    {
                        currStatus.RemoveAt(i);
                        currStatus.Insert(i, limit);
                        waiting -= freeSpots;
                    }
                }

            }

            if (currStatus[currStatus.Count - 1] < limit)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine($"{string.Join(" ", currStatus)}");
            }
            else 
            {
                Console.WriteLine($"There isn't enough space! {waiting} people in a queue!");
                Console.WriteLine($"{string.Join(" ", currStatus)}");
            }

            Console.WriteLine();
        }
    }
}
