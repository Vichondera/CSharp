namespace Reverse_Strings
{
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var st = new Stack<char>(input.Length);

            foreach (var ch in input)
            {
                st.Push(ch);
            }

            while (st.Count != 0)
            {
                Console.Write(st.Pop());
            }

            Console.WriteLine();
        }
    }
}
