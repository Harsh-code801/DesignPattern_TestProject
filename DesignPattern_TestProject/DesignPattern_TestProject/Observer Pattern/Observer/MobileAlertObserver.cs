using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Observer.Observer
{
    internal class MobileAlertObserver : INotifyMeObserver
    {
        public void Update(string templete)
        {
            Console.WriteLine($"Mobile Alert Send {templete}");
        }
    }
}
