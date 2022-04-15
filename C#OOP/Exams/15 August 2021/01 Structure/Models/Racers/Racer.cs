namespace CarRacing.Models.Racers
{
    using System;
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Models.Racers.Contracts;

    public class Racer : IRacer
    {
        public Racer(string username, string racingBehavior, int drivingExperience, ICar car)
        {
            
        }
        public string Username => throw new NotImplementedException();

        public string RacingBehavior => throw new NotImplementedException();

        public int DrivingExperience => throw new NotImplementedException();

        public ICar Car => throw new NotImplementedException();

        public bool IsAvailable()
        {
            throw new NotImplementedException();
        }

        public void Race()
        {
            throw new NotImplementedException();
        }
    }
}
