using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PD
{
    // Another Concrete Decorator class
    public class ConcreteDecoratorB : Decorator
    {
        public override string Operation()
        {
            return $"ConcreteDecoratorB({component?.Operation()})";
        }
    }
}
