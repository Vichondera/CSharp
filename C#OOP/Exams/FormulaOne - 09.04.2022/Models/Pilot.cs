using Formula1.Models.Contracts;
using System;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        public Pilot(string fullName)
        {

        }

        public string FullName => throw new NotImplementedException();

        public IFormulaOneCar Car => throw new NotImplementedException();

        public int NumberOfWins => throw new NotImplementedException();

        public bool CanRace => throw new NotImplementedException();

        public void AddCar(IFormulaOneCar car)
        {
            throw new NotImplementedException();
        }

        public void WinRace()
        {
            throw new NotImplementedException();
        }
    }
}
