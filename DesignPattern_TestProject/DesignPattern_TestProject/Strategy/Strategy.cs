using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Strategy
{
    public interface VehicalFeature
    {
        void drive();
    }
    public class Sports : VehicalFeature
    {
        void VehicalFeature.drive()
        {
            Console.WriteLine("Sports Car");
        }
    }
    public class Normal : VehicalFeature
    {
        void VehicalFeature.drive()
        {
            Console.WriteLine("Normal Car");
        }
    }
    public class Vehical
    {
        VehicalFeature vehicalFeature;
        public Vehical(VehicalFeature vehicalFeature)
        {
            this.vehicalFeature = vehicalFeature;
        }
        public void Drive()
        {
            vehicalFeature.drive();
        }
    }
}
