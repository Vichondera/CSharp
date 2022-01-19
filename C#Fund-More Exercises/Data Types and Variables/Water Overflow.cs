namespace _03_Water_Overflow
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int tankCpty = 255;

            int N = int.Parse(Console.ReadLine());

            int temp = tankCpty;
            for (int n = 0; n < N; n++)
            {
                int water = int.Parse(Console.ReadLine());
                
                if (temp - water > 0)
                {
                    temp -= water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(tankCpty - temp);
        }
    }
}
// 57 / 100
