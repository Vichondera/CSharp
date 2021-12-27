namespace Grades
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
           
            var grade = double.Parse(Console.ReadLine());
            string output = string.Empty;
            output = GradeChecker(grade, output);

            Console.WriteLine(output);
        }

        private static string GradeChecker(double grade, string output)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                output = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                output = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                output = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                output = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                output = "Excellent";
            }

            return output;
        }

    }
}
