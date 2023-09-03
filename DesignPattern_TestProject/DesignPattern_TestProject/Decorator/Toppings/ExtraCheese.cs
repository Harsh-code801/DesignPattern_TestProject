using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Decorator.Toppings
{
    internal class ExtraCheese : Toppingss
    {
        BasePizza pizza;
        public ExtraCheese(BasePizza basePizza)
        {
            this.pizza = basePizza;
        }

        public override int GetCost()
        {
            //return pizza.getCost() + 40;
            return 0;
        }
    }
}
