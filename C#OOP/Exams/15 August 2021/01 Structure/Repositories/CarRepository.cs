namespace CarRacing.Repositories
{
    using System;
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Repositories.Contracts;

    public class CarRepository : IRepository<ICar>
    {
        public System.Collections.Generic.IReadOnlyCollection<ICar> Models => throw new NotImplementedException();

        public void Add(ICar model)
        {
            throw new NotImplementedException();
        }

        public ICar FindBy(string property)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ICar model)
        {
            throw new NotImplementedException();
        }
    }
}
