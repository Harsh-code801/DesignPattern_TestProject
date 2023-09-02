using DesignPattern_TestProject.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Observer.Observable
{
    internal interface IStockObservable
    {
        void add(INotifyMeObserver notifyMeObserver);
        void remove(INotifyMeObserver notifyMeObserver);
        void notifySubscibers();
        void addnewStock(int count);
        int getStockCount();
    }
}
