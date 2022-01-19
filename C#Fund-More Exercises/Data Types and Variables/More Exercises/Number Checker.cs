namespace Number_Checker
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            bool isFloatingPointNum = false;

            foreach (var item in input)
            {
                if(item == '.')
                {
                    isFloatingPointNum = true;
                }
            }

            if(isFloatingPointNum)
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}
