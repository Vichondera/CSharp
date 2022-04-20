namespace SpaceStation.Models.Astronauts
{
    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Models.Bags.Contracts;
    using System;

    public abstract class Astronaut : IAstronaut
    {
        public string Name => throw new NotImplementedException();

        public double Oxygen => throw new NotImplementedException();

        public bool CanBreath => throw new NotImplementedException();

        public IBag Bag => throw new NotImplementedException();


        protected Astronaut(string name, double oxygen)
        {
            
        }
        public void Breath()
        {

        }
    }
}
