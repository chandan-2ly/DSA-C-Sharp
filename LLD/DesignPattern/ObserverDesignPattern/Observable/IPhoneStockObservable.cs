using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.Observer;

namespace ObserverDesignPattern.Observable
{
    internal class IPhoneStockObservable : IStockObservable
    {
        public List<INotificationAlertObserver> observers = new List<INotificationAlertObserver>();
        public int stockCount = 0;

        public void Add(INotificationAlertObserver observer)
        {
            observers.Add(observer);
        }

        public int GetStockCount()
        {
            return stockCount;
        }

        private void NotifySubscribers()
        {
            foreach(INotificationAlertObserver obs in observers)
            {
                obs.Update();
            }
        }

        public void Remove(INotificationAlertObserver observer)
        {
            observers.Remove(observer);
        }

        public void UpdateStockCount(int stockCount)
        {
            if(this.stockCount == 0)
            {
                NotifySubscribers();
            }
            this.stockCount += stockCount;
        }
    }
}
