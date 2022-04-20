namespace Heroes.Models.Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Barbarian : Hero
    {
        protected Barbarian(string name, int health, int armour) 
            : base(name, health, armour)
        {
        }
    }
}
