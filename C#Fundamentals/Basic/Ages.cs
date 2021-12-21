namespace Ages
{
    using System;
    
    class Program
    {
        public static void Main(string[] args)
        {
            //  Input
            int input = int.Parse(Console.ReadLine());

            // AntiLogic xD
            if (input >= 0 && input <= 2) // 0 - 2 – baby;
            {
                Console.WriteLine("baby");
            }
            else if (input >= 3 && input <= 13) // 3 - 13 – child;
            {
                Console.WriteLine("child");
            }
            else if (input >= 14 && input <= 19) //14 - 19 – teenager;
            {
                Console.WriteLine("teenager");
            }
            else if (input >= 20 && input <= 65)  //20 - 65 – adult;
            {
                Console.WriteLine("adult");
            }
            else if (input >= 66)   //>= 66 – elder;
            {
                Console.WriteLine("elder");
            }

        }
    }
}
