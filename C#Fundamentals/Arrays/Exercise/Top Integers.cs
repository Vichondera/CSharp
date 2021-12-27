namespace TopInteger
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ')
               .Select(int.Parse)
               .ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                bool isBigger = true;
                for (long j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] <= inputArr[j])
                    {
                        isBigger = false;
                    }
                }

                if (isBigger)
                {
                    Console.Write(inputArr[i] + " ");
                }
            }

        }
    }
}
