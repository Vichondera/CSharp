namespace PrimeNum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = GetNum();

            PrintResult(number);
        }

         static void PrintResult(int number)
        {
            if (IsPrime(number))  Console.WriteLine(IsPrime(number)); 
            else  Console.WriteLine(IsPrime(number)); 
        }

         static int GetNum()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

         static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)

                if (number % i == 0)
                    return false;

            return true;
        }

    }
}
