using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags.Contracts;

namespace SpaceStation.Models.Astronauts
{
    using System;
    
    public class Biologist : Astronaut
    {
        protected Biologist(string name) : base(name, 70)
        {
        }
    }
}
