namespace Histogram
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            double sumP1 = 0, sumP2 = 0, sumP3 = 0, sumP4 = 0, sumP5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int N = int.Parse(Console.ReadLine());
                {
                    if (N <= 1000)
                    {
                        if (N < 200)
                        {
                            sumP1 += 1;
                        }
                        else if (N >= 200 && N < 400)
                        {
                            sumP2 += 1;
                        }
                        else if (N >= 400 && N < 600)
                        {
                            sumP3 += 1;
                        }
                        else if (N >= 600 && N < 800)
                        {
                            sumP4 += 1;
                        }
                        else if (N >= 800)
                        {
                            sumP5 += 1;
                        }
                    }

                    p1 = sumP1 / n * 100;
                    p2 = sumP2 / n * 100;
                    p3 = sumP3 / n * 100;
                    p4 = sumP4 / n * 100;
                    p5 = sumP5 / n * 100;
                }
            }

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
