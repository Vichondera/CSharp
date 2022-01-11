namespace CharacterStats
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Name: {name}");

            int currentHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());

            string healthOutput = string.Empty;
            for (int h = 0; h < maxHP; h++)
            {
                if(h < currentHP)
                {
                    healthOutput += "|";
                }
                else
                {
                    healthOutput += ".";
                }
            }
            Console.WriteLine($"Health: |{healthOutput}|");

            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string energyOutput = string.Empty;
            for (int e = 0; e < maxEnergy; e++)
            {
                if (e < currentEnergy)
                {
                    energyOutput += "|";
                }
                else
                {
                    energyOutput += ".";
                }
            }
            Console.WriteLine($"Energy: |{energyOutput}|");
        }
    }
}
