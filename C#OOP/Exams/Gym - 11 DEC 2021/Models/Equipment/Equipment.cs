namespace Gym.Models.Equipment
{

    using Gym.Models.Equipment.Contracts;
    public abstract class Equipment : IEquipment
    {
        protected Equipment(double weight, decimal price)
        {
            this.Weight = weight;
            this.Price = price;
        }
        public double Weight { get; protected set; }

        public decimal Price { get; protected set; }
    }
}
