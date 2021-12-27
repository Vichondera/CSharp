namespace Encrypt_Sort_and_Print_Array
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());
            string[] sequenceStrings = new string[numInputs];

            int[] valueString = new int[numInputs];

            for (int i = 0; i < numInputs; i++)
            {
                sequenceStrings[i] = Console.ReadLine();
                int sumVowels = 0;
                int sumCons = 0;

                foreach (char ch in sequenceStrings[i])
                {
                    if (ch == 'a' ||
                        ch == 'e' || ch == 'i' ||
                        ch == 'o' || ch == 'u' || ch == 'A' ||
                        ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                    {

                        sumVowels += ((int)ch * sequenceStrings[i].Length);
                    }
                    else
                    {
                        sumCons += ((int)ch / sequenceStrings[i].Length);
                    }
                }

                int stringSum = sumVowels + sumCons;

                valueString[i] = stringSum;
            }

            Array.Sort(valueString);

            foreach (int value in valueString)
            {
                Console.WriteLine(value);
            }

        }
    }
}
