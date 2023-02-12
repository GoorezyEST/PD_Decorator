using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PD
{
    // Concrete Decorator class
    public class ConcreteDecoratorA : Decorator
    {
        public override string Operation()
        {
            return $"ConcreteDecoratorA({component?.Operation()})";
        }
    }
}
