using SpaceStation.Models.Planets.Contracts;

namespace SpaceStation.Models.Planets
{
    using System;
    using System.Collections.Generic;

    public abstract class Planet : IPlanet
    {
        public ICollection<string> Items => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        protected Planet(string name)
        {

        }
    }
}
