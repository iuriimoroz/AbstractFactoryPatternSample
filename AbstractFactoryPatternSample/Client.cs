using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternSample
{
    public class Client
    {
        private IAbstractProductA productA;
        private IAbstractProductB productB;

        public Client(IAbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();

            productA.ProductDescription();
            productB.ProductDescription();
        }
    }
}
