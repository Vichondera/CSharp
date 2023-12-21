namespace NauticalCatchChallenge.Models
{
    using NauticalCatchChallenge.Models.Contracts;

    public abstract class Diver : IDiver
    {
        public Diver(string name, int oxygenLevel)
        {
            
        }

        public string Name => throw new NotImplementedException();

        public int OxygenLevel => throw new NotImplementedException();

        public IReadOnlyCollection<string> Catch => throw new NotImplementedException();

        public double CompetitionPoints => throw new NotImplementedException();

        public bool HasHealthIssues => throw new NotImplementedException();

        public void Hit(IFish fish)
        {
            throw new NotImplementedException();
        }

        public void Miss(int TimeToCatch)
        {
            throw new NotImplementedException();
        }

        public void RenewOxy()
        {
            throw new NotImplementedException();
        }

        public void UpdateHealthStatus()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
