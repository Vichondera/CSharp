namespace Elevator
{
    using System;
  
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = persons / capacity;
            //
            if (persons % capacity == 0)
            {
                Console.WriteLine(courses);
            }
            else
            {
                courses++;
                Console.WriteLine(courses);
            }
        }
    }
}
