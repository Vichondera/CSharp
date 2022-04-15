namespace CarRacing.Models.Cars
{
    using System;
    using CarRacing.Models.Cars.Contracts;

    public class SuperCar : Car, ICar
    {
        protected SuperCar(string make, string model, string VIN, int horsePower)
         : base(make, model, VIN, horsePower, 80, 10)
        {

        }
    }
}
