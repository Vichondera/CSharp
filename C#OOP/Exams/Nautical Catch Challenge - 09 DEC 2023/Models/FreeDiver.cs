namespace NauticalCatchChallenge.Models
{
    public class FreeDiver : Diver
    {
        private const int oxygenDefaultLevel = 120;

        public FreeDiver(string name)
            : base(name,oxygenDefaultLevel)
        {
        }
    }
}
