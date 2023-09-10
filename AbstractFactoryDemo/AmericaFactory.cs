using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class AmericaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
