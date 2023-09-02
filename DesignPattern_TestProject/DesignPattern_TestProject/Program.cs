using DesignPattern_TestProject.Observer.Observable;
using DesignPattern_TestProject.Observer.Observer;
using DesignPattern_TestProject.Observer_Pattern.Observable;
using DesignPattern_TestProject.Strategy;

namespace DesignPattern_TestProject 
{
    internal class Program
    {
        #region Strategy Design Pattern
        static void Mainmm(string[] args)
        {
            Vehical v1 = new Vehical(new Sports());
            Vehical v2 = new Vehical(new Normal());
            v1.Drive();
            v2.Drive();
        }
        #endregion

        #region Observer Pattern
        static void Main(string[] args)
        {
            IStockObservable stockObservable = new IPhoneObservable();

            var n = new CallAlertObserver();
            stockObservable.add(n);
            stockObservable.add(new CallAlertObserver());
            stockObservable.add(new EmailAlertObserver());
            stockObservable.add(new MobileAlertObserver());
            stockObservable.add(new CallAlertObserver());

            stockObservable.remove(n);

            stockObservable.addnewStock(2);
            stockObservable.addnewStock(2);

            //===============================================================================
            IOfferObservable macbookOfferObservable = new MackBookOfferObservable();

            var n2 = new CallAlertObserver();
            macbookOfferObservable.add(n2);
            macbookOfferObservable.add(new CallAlertObserver());
            macbookOfferObservable.add(new EmailAlertObserver());
            macbookOfferObservable.add(new EmailAlertObserver());
            macbookOfferObservable.add(new MobileAlertObserver());
            macbookOfferObservable.add(new MobileAlertObserver());
            macbookOfferObservable.remove(n2);

            macbookOfferObservable.offerBegainBySeller();

            Console.Read();
        }
        #endregion
    }
}