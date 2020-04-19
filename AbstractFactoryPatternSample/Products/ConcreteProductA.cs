using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternSample
{
    public class ConcreteProductA : IAbstractProductA
    {
        public void ProductDescription()
        {
            Console.WriteLine("This is Product A.");
        }
    }
}
