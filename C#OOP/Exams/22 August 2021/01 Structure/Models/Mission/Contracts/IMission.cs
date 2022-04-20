using Astronauts.Contracts;
using Planets;
using Planets.Contracts;

namespace SpaceStation.Models.Mission.Contracts
{
    using System.Collections.Generic;

    public interface IMission
    {
        void Explore(IPlanet planet, ICollection<IAstronaut> astronauts);
    }
}
