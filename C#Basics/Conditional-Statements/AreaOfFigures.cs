namespace AreaOfFigures
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            
            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
                
                Console.WriteLine(area);
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                
                double area2 = sideA * sideB;
                
                Console.WriteLine(area2);
            }
            else if (shape == "triangle")
            {
                double sideAA = double.Parse(Console.ReadLine());
                double sideBB = double.Parse(Console.ReadLine());
                
                double areaa = (sideAA * sideBB) / 2;
                double area3 = Math.Round(areaa, 2);
                
                Console.WriteLine(area3);
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                
                double area4 = Math.PI * r * r;
                
                Console.WriteLine(area4);
            }
            
        }
    }
}
