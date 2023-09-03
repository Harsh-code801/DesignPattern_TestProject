using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Factory_Pattern
{
    internal class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Square Draw");
        }
    }
}
