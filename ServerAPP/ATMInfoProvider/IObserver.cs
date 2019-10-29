using System;


namespace ATM.Cacher
{
    public interface IObserver
    {
        void Notify(string txt);
        void Notify(ATMInfoProvider infoObj);
    }
}
