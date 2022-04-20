using Heroes.Models.Heroes;

namespace Heroes.Models.Weapons
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Mace : Weapon
    {
        protected Mace(string name) : base(name, 25)
        {
        }
    }
}
