using Heroes.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Models.Heroes
{
    public class Hero : IHero
    {
       protected Hero(string name, int health, int armour)
        {

        }
        // Name - string 
       // If the name is null or whitespace,
       // throw an ArgumentException with the message: "Hero name cannot be null or empty."
       // All names are unique

       // Health -  int
       // If the health is below 0,
       // throw an ArgumentException with the message: "Hero health cannot be below 0."
      
        // Armour -  int
        // If the armour is below 0,
        // throw an ArgumentException with the message: "Hero armour cannot be below 0."

        // IsAlive -  bool
        // Calculated property, if the health is above zero, returns true.

        // IWeapon -  Weapon
        // If the weapon is null,
        // throw an ArgumentException with the message: "Weapon cannot be null."

        public string Name => throw new NotImplementedException();

        public int Health => throw new NotImplementedException();

        public int Armour => throw new NotImplementedException();

        public IWeapon Weapon => throw new NotImplementedException();

        public bool IsAlive => throw new NotImplementedException();

        public void AddWeapon(IWeapon weapon)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int points)
        {
            throw new NotImplementedException();
        }
    }
}
