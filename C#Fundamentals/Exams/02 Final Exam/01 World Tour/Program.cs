using System;
using System.Text;

namespace _01_World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var stops = new StringBuilder(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Travel") break;

                string[] cmdArgs = line.Split(":");

                if (cmdArgs[0] == "Add Stop")
                {
                    int idx = int.Parse(cmdArgs[1]);
                    string str = cmdArgs[2];
                    if (idx < stops.Length)
                    {
                        stops.Insert(idx, str);
                    }
                }

                if (cmdArgs[0] == "Remove Stop")
                {
                    int startIdx = int.Parse(cmdArgs[1]);
                    int endIdx = int.Parse(cmdArgs[2]);
                    if (startIdx >= 0 && endIdx < stops.Length)
                    {
                        stops.Remove(startIdx, (endIdx - startIdx) + 1);
                    }
                }

                if (cmdArgs[0] == "Switch")
                {
                    string temp = stops.ToString();
                    if (temp.Contains(cmdArgs[1]))
                    {
                        stops.Replace(cmdArgs[1], cmdArgs[2]);
                    }
                }
                Console.WriteLine(stops.ToString());
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops.ToString()}");
        }
    }
}
