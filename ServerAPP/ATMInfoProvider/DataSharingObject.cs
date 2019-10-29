using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace ATM.Cacher
{
    public class DataSharingObject: MarshalByRefObject
    {
        public DataSharingObject() {

        }
        public void SetMessage(string msg) {
            Cache.GetInstance().MessageString = msg;
        }
        public void SetATMData(ATMInfoProvider atmInfo) {
            Cache.GetInstance().ATMCache = atmInfo;
        }
    }
}
