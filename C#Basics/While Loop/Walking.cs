using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 10000, totalSteps = 0;
            
            var isGoingHome = false;
           
            while (totalSteps < target && !isGoingHome)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    isGoingHome = true;
                }

                int stepsToday = int.Parse(input);
                totalSteps += stepsToday;
            }

            if (totalSteps >= target)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - target} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{target - totalSteps} more steps to reach goal.");
            }
            
        }
    }
}
