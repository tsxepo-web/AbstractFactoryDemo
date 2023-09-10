using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class AnimalWorld
    {
        private IHerbivore _herbivore;
        private ICarnivore _carnivore;

        public AnimalWorld(IContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
