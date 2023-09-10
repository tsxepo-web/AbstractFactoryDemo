using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class AfricaFactory : IContinentFactory
    {
        ICarnivore IContinentFactory.CreateCarnivore()
        {
            return new Lion();
        }

        IHerbivore IContinentFactory.CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
