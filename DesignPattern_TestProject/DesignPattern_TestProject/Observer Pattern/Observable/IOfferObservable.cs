﻿using DesignPattern_TestProject.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestProject.Observer_Pattern.Observable
{
    internal interface IOfferObservable
    {
        void add(INotifyMeObserver notifyMeObserver);
        void remove(INotifyMeObserver notifyMeObserver);
        void notifyMe();
        void offerBegainBySeller();
    }
}
