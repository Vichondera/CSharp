namespace EmployeeData
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Name: {0}", name);
            
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Age: {0}", age);

            var employeeID = new List<char>(Console.ReadLine());            
           if(employeeID.Count < 8)
            {
                int diff = 8 - employeeID.Count;
                for (int i = 0; i < diff; i++)
                {
                    employeeID.Insert(0, '0');
                }
            }

            string output = string.Empty;
            foreach (var item in employeeID)
            {
                output += item.ToString();
            }
            Console.WriteLine($"Employee ID: {output}");
            
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
