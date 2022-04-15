namespace CarRacing.Models.Racers
{
    using System;
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Models.Racers.Contracts;

    public class StreetRacer : Racer, IRacer
    {
        public StreetRacer(string username,  ICar car)
         : base(username,"aggressive",10, car)
        {
            
        }
    }
}
