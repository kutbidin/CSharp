using System;
namespace ATM.Cacher
{
    public class Cache
    {

        public static IObserver _observer;
        private static Cache _myCache;
        public ATMInfoProvider _atmInfo;

        private Cache() {
            _atmInfo = new ATMInfoProvider();
        }
        public static Cache GetInstance() {
            if (_myCache == null) {
                _myCache = new Cache();
            }
            return _myCache;
        }
        public static void Attach(IObserver observer)
        {
            _observer = observer;
        }
        public void setContext(ATMInfoProvider atmInfo)
        {
            _atmInfo = atmInfo;

        }
        public string MessageString {
            set {
                _observer.Notify(value);
            }
        }
        public ATMInfoProvider ATMCache {
            get {
                return _atmInfo;
            }
            set {
                _observer.Notify((ATMInfoProvider)value);
            }
        }

    }
}
