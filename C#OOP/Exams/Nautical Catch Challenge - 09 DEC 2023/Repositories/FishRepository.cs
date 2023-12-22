namespace NauticalCatchChallenge.Repositories
{
    using NauticalCatchChallenge.Models.Contracts;
    using NauticalCatchChallenge.Repositories.Contracts;

    public class FishRepository : IRepository<IFish>
    {
        private readonly List<IFish> models;

        public FishRepository()
        {
            models = new List<IFish>();
        }

        public IReadOnlyCollection<IFish> Models => models.AsReadOnly();

        public void AddModel(IFish model) => models.Add(model);

        public IFish GetModel(string name)
        {
            return models.Where(f => f.Name == name).FirstOrDefault();
        }
    }
}
