namespace _06
{
    using System;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourhNumber = int.Parse(Console.ReadLine());

            // AntiLogic
            var firstCheck = firstNumber + secondNumber; //first + second==>
            var secondCheck = firstCheck / thirdNumber; //=> devide [third num]==>
            var thirdCheck = secondCheck * fourhNumber; //=> x [fourth num]

            // Output
            Console.WriteLine(thirdCheck);
        }
    }
}
