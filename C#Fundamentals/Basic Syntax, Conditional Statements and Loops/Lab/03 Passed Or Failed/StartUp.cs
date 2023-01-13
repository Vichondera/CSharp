namespace PassedOrFailed
{
  using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());

            if (num >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
/*
 float grade = float.Parse(Console.ReadLine());

            if(grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
 */
