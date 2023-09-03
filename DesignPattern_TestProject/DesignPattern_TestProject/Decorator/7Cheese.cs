using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Decorator
{
    internal class _7Cheese : IBasePizza
    {
        public int getCost()
        {
            return 200;
        }
    }
}
