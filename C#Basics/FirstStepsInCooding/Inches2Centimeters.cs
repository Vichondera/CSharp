namespace inchs
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
           double centimeters = double.Parse(Console.ReadLine());
           double output = centimeters * 2.54;
           Console.WriteLine(output);       
       }
    }
}
