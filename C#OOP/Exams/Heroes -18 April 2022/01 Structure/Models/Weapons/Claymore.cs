using Heroes.Models.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Models.Weapons
{
    public class Claymore : Weapon
    {
        protected Claymore(string name) : base(name, 20)
        {
        }
    }
}
