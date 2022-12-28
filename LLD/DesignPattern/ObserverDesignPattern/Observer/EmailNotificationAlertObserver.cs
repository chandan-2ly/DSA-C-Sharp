using ObserverDesignPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    internal class EmailNotificationAlertObserver : INotificationAlertObserver
    {
        IStockObservable stockObservable;

        public EmailNotificationAlertObserver(IStockObservable stockObservable)
        {
            this.stockObservable = stockObservable;
        }

        public void Update()
        {
            Console.WriteLine("Email sent, stock is added");
        }
    }
}
