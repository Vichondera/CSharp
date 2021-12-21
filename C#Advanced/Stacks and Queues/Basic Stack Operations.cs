namespace Basic_Stack_Operations
{
    using System;
    using System.Collections;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var stack = new Stack();
            var count = input[0];
            var toPop = input[1];
            var toPeak = input[2];

            for (int i = 0; i < count; i++)
            {
                stack.Push(line[i]);
            }

            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(stack.Count);
            }
            else
            {
                if (stack.Contains(toPeak))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    var nums = stack.ToArray();
                    Console.WriteLine(nums.Min());
                }
            }

        }
    }
}
