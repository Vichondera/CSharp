using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (synonims.ContainsKey(word))
                {
                    synonims[word].Add(synonim);
                }
                else
                {
                    synonims.Add(word, new List<string>() { synonim });
                }
            }

            foreach (var item in synonims)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        
        }

    }
}
