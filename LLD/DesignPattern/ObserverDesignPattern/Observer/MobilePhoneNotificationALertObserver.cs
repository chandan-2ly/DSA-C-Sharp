using ObserverDesignPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    internal class MobilePhoneNotificationALertObserver : INotificationAlertObserver
    {
        IStockObservable observable;

        public MobilePhoneNotificationALertObserver(IStockObservable observable)
        {
            this.observable = observable;
        }

        public void Update()
        {
            Console.WriteLine("SMS sent, stock is uodated");
        }
    }
}
