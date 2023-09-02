using DesignPattern_TestProject.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Observer.Observable
{
    internal class IPhoneObservable : IStockObservable
    {
        List<INotifyMeObserver> subscribers = new List<INotifyMeObserver>();
        int iPhoneStock = 0;
        public void add(INotifyMeObserver notifyMeObserver)
        {
            subscribers.Add(notifyMeObserver);
        }
        public void remove(INotifyMeObserver notifyMeObserver)
        {
            subscribers.Remove(notifyMeObserver);
        }
        public void notifySubscibers()
        {
            Parallel.ForEach(subscribers, s =>
            {
                s.Update("Iphone In Stock");
            });
        }

        public void addnewStock(int stock)
        {
            if(iPhoneStock == 0)
                notifySubscibers();
            iPhoneStock += stock;
        }

        public int getStockCount()
        {
            return iPhoneStock;
        }

        

        
    }
}
