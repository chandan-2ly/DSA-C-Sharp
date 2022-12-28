using ObserverDesignPattern.Observable;
using ObserverDesignPattern.Observer;

namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStockObservable stock = new IPhoneStockObservable();

            INotificationAlertObserver alertObserver = new EmailNotificationAlertObserver(stock);
            INotificationAlertObserver alertObserver1 = new MobilePhoneNotificationALertObserver(stock);

            stock.Add(alertObserver);
            stock.Add(alertObserver1);

            stock.UpdateStockCount(10);
        }
    }
}