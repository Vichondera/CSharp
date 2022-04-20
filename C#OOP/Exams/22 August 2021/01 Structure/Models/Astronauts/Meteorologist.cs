using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags.Contracts;

namespace SpaceStation.Models.Astronauts
{
    using System;

    public class Meteorologist : Astronaut
    {
        protected Meteorologist(string name)  : base(name, 90)
        {
        }
    }
}
