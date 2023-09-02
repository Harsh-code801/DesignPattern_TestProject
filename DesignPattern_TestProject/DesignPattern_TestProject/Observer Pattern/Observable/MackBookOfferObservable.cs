using DesignPattern_TestProject.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Observer_Pattern.Observable
{
    internal class MackBookOfferObservable : IOfferObservable
    {
        List<INotifyMeObserver> subscribers = new List<INotifyMeObserver>();

        public void add(INotifyMeObserver notifyMeObserver)
        {
            subscribers.Add(notifyMeObserver);
        }
        public void remove(INotifyMeObserver notifyMeObserver)
        {
            subscribers.Remove(notifyMeObserver);
        }
        public void notifyMe()
        {
            Parallel.ForEach(subscribers, s =>
            {
                s.Update("MackBook Offer");
            });
        }

        public void offerBegainBySeller()
        {
           //login of time base or anything
           notifyMe();
        }
    }
}
