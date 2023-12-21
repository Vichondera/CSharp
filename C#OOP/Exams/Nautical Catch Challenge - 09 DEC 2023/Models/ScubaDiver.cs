namespace NauticalCatchChallenge.Models
{
    public class ScubaDiver : Diver
    {
        private const int oxygenDefaultLevel = 540;
        public ScubaDiver(string name) 
            : base(name, oxygenDefaultLevel)
        {
        }
    }
}
