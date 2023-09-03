using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Factory_Pattern
{
    internal class ShapeFactory
    {
        public IShape GetShape(string shape)
        {
            switch (shape)
            {
                case "Square":
                    return new Square();
                case "Circle":
                    return new Circle();
                default:
                    return null;
            }
        }
    }
}
