namespace Train
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());
            var arr = new int[numOfWagons];

            for (int i = 0; i < arr.Length; i++)
            {
                var input = int.Parse(Console.ReadLine());
                arr[i] = input;
            }
            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine(arr.Sum());
        }
    }
}
