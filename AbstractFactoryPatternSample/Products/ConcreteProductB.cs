using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternSample
{
    public class ConcreteProductB : IAbstractProductB
    {
        public void ProductDescription()
        {
            Console.WriteLine("This is Product B.");
        }
    }
}
