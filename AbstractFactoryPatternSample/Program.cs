using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products created on ConcreteFactoryA:");
            Client clientA = new Client(new ConcreteFactoryA());

            Console.WriteLine();

            Console.WriteLine("Products created on ConcreteFactoryB:");
            Client clientB = new Client(new ConcreteFactoryB());

            Console.ReadKey();
        }
    }
}
