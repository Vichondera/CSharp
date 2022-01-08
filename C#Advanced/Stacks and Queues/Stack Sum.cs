namespace _02_StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    

    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split(" ")
            .Select(int.Parse)
            .ToArray();

            Stack<int> stack = new Stack<int>(integers);

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if(input == "end")
                {
                    break;
                }

                var line = input.Split(" ");
                var cmd = line[0];
                var fst = line[1];

                if (cmd == "add")
                {
                    var sec = line[2];

                    stack.Push(int.Parse(fst));
                    stack.Push(int.Parse(sec));
                }
                else if (cmd == "remove")
                {
                    if (stack.Count > int.Parse(fst))
                    {
                        for (int i = 0; i < int.Parse(fst); i++)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
