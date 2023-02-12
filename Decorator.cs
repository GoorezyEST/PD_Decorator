using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_PD
{
    // Decorator abstract class
    public abstract class Decorator : Component
    {
        protected Component? component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override string Operation()
        {
            if (component != null)
            {
                return component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
