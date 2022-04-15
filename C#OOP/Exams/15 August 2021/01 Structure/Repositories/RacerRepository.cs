namespace CarRacing.Repositories
{
    using System;
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Repositories.Contracts;

    public class RacerRepository : IRepository<IRacer>
    {
        public System.Collections.Generic.IReadOnlyCollection<IRacer> Models => throw new NotImplementedException();

        public void Add(IRacer model)
        {
            throw new NotImplementedException();
        }

        public IRacer FindBy(string property)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IRacer model)
        {
            throw new NotImplementedException();
        }
    }
}
