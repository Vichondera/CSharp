namespace CarRacing.Models.Cars
{
    using System;
    using CarRacing.Models.Cars.Contracts;

    public class TunedCar : Car, ICar
    {
        protected TunedCar(string make, string model, string VIN, int horsePower)
         : base(make, model, VIN, horsePower, 65, 7.5)
        {

        }
    }
}
