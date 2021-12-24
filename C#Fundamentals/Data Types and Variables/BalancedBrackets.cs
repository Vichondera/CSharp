using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Balanced Brackets
            // You will receive n lines.
            // On those lines, you will receive one of the following:
            // Opening bracket – “(“,
            // Closing bracket – “)” or
            char openBracket = '(';
            char closeBracket = ')';
            int openCount = 0;
            int closeCOunt = 0;

            // Random string
            // Your task is to find out if the brackets are balanced.
            // That means after every closing bracket should
            // follow an opening one.Nested parentheses are not valid,
            // and if two consecutive opening brackets exist,
            // the expression should be marked as unbalanced.
            // Input
            // On the first line, you will receive n – the number of lines, which will follow
            int linesN = int.Parse(Console.ReadLine());
            // On the next n lines, you will receive "(", ")" or another string
            for (int i = 0; i < linesN; i++)
            {
                string input = Console.ReadLine();
                for (int c = 0; c < input.Length; c++)
                {
                    if(input[c] == openBracket)
                    {
                        openCount++;
                    }
                    else if(input[c] == closeBracket)
                    {
                        closeCOunt++;
                    }
                }
            }

            if(openCount == closeCOunt)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            // Output
            // You have to print "BALANCED" if the parentheses are balanced and "UNBALANCED" otherwise.
            // Constraints
            // n will be in the interval[1…20]
            // The length of the stings will be between[1…100] characters


        }
    }
}
