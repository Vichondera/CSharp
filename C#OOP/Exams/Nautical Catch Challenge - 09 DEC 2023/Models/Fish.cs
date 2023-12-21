namespace NauticalCatchChallenge.Models
{
    using NauticalCatchChallenge.Models.Contracts;

    public abstract class Fish : IFish
    {
        public Fish(string name, double points, int timeToCatch)
        {
            
        }

        public string Name => throw new NotImplementedException();

        public double Points => throw new NotImplementedException();

        public int TimeToCatch => throw new NotImplementedException();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
