using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags.Contracts;

namespace SpaceStation.Models.Astronauts
{
    using System;

    public class Geodesist : Astronaut
    {
        protected Geodesist(string name)  : base(name, 50)
        {
        }
    }
}
