using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Decorator
{
    internal class Margherita : BasePizza
    {
        public override int GetCost()
        {
            return 150;
        }
    }
}
