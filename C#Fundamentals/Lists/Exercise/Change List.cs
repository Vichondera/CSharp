namespace ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] splitted = command.Split();
                string action = splitted[0];
                int element = int.Parse(splitted[1]);
                
                if (action == "Delete")
                {
                    elements.RemoveAll(x => x == element);
                }

                if (action == "Insert")
                {
                    int position = int.Parse(splitted[2]);
                    elements.Insert(position, element);
                }

                command = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
