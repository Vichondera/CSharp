namespace Gym.Models.Athletes
{
    using Gym.Models.Athletes.Contracts;
    using System;

    public abstract class Athlete : IAthlete
    {
        private string fullName;
        private string motivation;
        private int numberOfMedals;

        protected Athlete(string fullName, string motivation, int numberOfMedals, int stamina)
        {
            this.FullName = fullName;
            this.Motivation = motivation;
            this.NumberOfMedals = numberOfMedals;
            this.Stamina = stamina;
        }

        public string FullName
        {
            get => fullName;
            protected set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Athlete name cannot be null or empty.");
                }
                fullName = value;
            }
        }
       
        public string Motivation
        {
            get => motivation;
            protected set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The motivation cannot be null or empty.");
                }
                motivation = value;
            }
        }

        public int Stamina { get; protected set; }
        public int NumberOfMedals
        {
            get => numberOfMedals;
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Athlete's number of medals cannot be below 0.");
                }
                numberOfMedals = value;
            }
        }
        public abstract void Exercise();
    }
}
