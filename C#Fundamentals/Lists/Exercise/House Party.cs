namespace HouseParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < limit; i++)
            {
                string input = Console.ReadLine();
                string[] splitted = input.Split().ToArray();
                string name = splitted[0];

                if(splitted.Length == 3)
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    
                }
                
                if(splitted.Length == 4)
                {
                    if(guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
