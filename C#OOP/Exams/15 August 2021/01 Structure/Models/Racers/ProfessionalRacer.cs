namespace CarRacing.Models.Racers
{
    using System;
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Models.Racers.Contracts;

    public class ProfessionalRacer : Racer, IRacer
    {
        public ProfessionalRacer(string username, ICar car) 
        : base(username, "strict", 30, car)
        {
            
        }
    }
}
