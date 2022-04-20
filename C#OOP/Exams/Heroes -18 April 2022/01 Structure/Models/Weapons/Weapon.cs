using Heroes.Models.Contracts;

namespace Heroes.Models.Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Weapon : IWeapon
    {

        protected Weapon(string name, int durability)
        {

        }
        // Name – string
        // If the name is null or whitespace,
        // throw new ArgumentException("Weapon type cannot be null or empty.");
        // All names are unique
        //
        // Durability – int
        // If the durability is below 0,
        // throw new ArgumentException("Durability cannot be below 0.");

        public string Name => throw new NotImplementedException();

        public int Durability => throw new NotImplementedException();

        public int DoDamage()
        {
            // The DoDamage() method returns the damage of each weapon:
           // Mace - 25 damage
           // Claymore - 20 damage

           // Whenever the DoDamage method is invoked, the weapon's durability is decreased by 1.
           // If the weapon's durability becomes 0, the method should return 0.

            throw new NotImplementedException();
        }
    }
}
