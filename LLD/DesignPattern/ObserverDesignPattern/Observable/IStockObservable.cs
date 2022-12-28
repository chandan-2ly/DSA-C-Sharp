using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.Observer;

namespace ObserverDesignPattern.Observable
{
    internal interface IStockObservable
    {
        public void Add(INotificationAlertObserver observer);
        public void Remove(INotificationAlertObserver observer);
        public void UpdateStockCount(int stockCount);
        public int GetStockCount();
    }
}
