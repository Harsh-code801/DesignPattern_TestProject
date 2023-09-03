using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Decorator.Toppings
{
    internal class Mushroom : IToppings
    {
        IBasePizza pizza;
        public Mushroom(IBasePizza basePizza)
        {
            this.pizza = basePizza;
        }
        public int getCost()
        {
            return pizza.getCost() + 30;
        }
    }
}
