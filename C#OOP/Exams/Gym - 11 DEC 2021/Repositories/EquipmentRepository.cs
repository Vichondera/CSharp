namespace Gym.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Gym.Models.Equipment.Contracts;
    using Gym.Repositories.Contracts;
    
    public class EquipmentRepository : IRepository<IEquipment>
    {
        private List<IEquipment> models = new List<IEquipment>();
 
        public IReadOnlyCollection<IEquipment> Models => this.models;

        public void Add(IEquipment model) => this.models.Add(model);

        public IEquipment FindByType(string type) => this.models.FirstOrDefault(x => x.GetType().Name == type);

        public bool Remove(IEquipment model) => this.models.Remove(model);

    }
}
