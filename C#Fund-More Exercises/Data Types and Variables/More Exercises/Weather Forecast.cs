namespace Weather_Forecast
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());

            string output = string.Empty;

            if(!(Math.Floor(N) == N))
            {
                output = "Rainy";
            }
            else if (N >= sbyte.MinValue && N <= sbyte.MaxValue)
            {
                output = "Sunny";
            }
            else if (N >= int.MinValue && N <= int.MaxValue)
            {
                output = "Cloudy";
            }
            else if (N >= long.MinValue && N <= long.MaxValue)
            {
                output = "Windy";
            }
          
            Console.WriteLine(output);
        }
    }
}
