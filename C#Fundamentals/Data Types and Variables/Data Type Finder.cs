namespace DataTypeFinder
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // You will receive input until you receive "END".
            // Find what data type is the input. Possible data types are:

            // Integer
            // Floating point
            // Characters
            // Boolean
            // Strings
            while (true)
            {
                var input = Console.ReadLine();
                if(input == "END")
                {
                    break;
                }

                int intValue;
                float floatValue;
                char charValue;
                bool boolValue;

                if (int.TryParse(input, out intValue))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out floatValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out charValue))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out boolValue))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
            // Print the result in the following format: "{input} is {data type} type"
        }
    }
}
