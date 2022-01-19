namespace Tourist_Information
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double units = double.Parse(Console.ReadLine());
            Converter(type, units);
        }

        public static void Converter(string type, double units)
        {
            double result;
            switch (type)
            {
                case "miles":
                    result = units * 1.6;
                    Console.WriteLine($"{units} {type} = {result:f2} kilometers");
                    break;
                case "inches":
                    result = units * 2.54;
                    Console.WriteLine($"{units} {type} = {result:f2} centimeters");
                    break;
                case "feet":
                    result = units * 30;
                    Console.WriteLine($"{units} {type} = {result:f2} centimeters");
                    break;
                case "yards":
                    result = units * 0.91;
                    Console.WriteLine($"{units} {type} = {result:f2} meters");
                    break;
                case "gallons":
                    result = units * 3.8;
                    Console.WriteLine($"{units} {type} = {result:f2} liters");
                    break;
            }
        }
    }
}
