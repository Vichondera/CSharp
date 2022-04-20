using System.Collections.Generic;
using SpaceStation.Models.Bags.Contracts;

namespace SpaceStation.Models.Bags
{
    using System;

    public abstract class Backpack : IBag
    {
        public ICollection<string> Items => throw new NotImplementedException();

        protected Backpack()
        {

        }
    }
}
