namespace Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            var arr = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            var result = new List<int>();

            for (int i = 0; i < arr[0]; i++)
            {
                result.Add(list[i]);
            }

            for (int i = 0; i < arr[1]; i++)
            {
                result.RemoveAt(0);
            }

            bool isContainNum = false;

            foreach (var item in result)
            {
                if (arr[2] == item)
                {
                    isContainNum = true;
                }
            }

            if (isContainNum)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
