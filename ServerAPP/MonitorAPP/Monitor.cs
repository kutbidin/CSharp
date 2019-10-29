using System;
using System.Windows.Forms;
using ATM.Cacher;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace MonitorAPP
{
    public partial class Monitor : Form,IObserver
    {
        public ATMInfoProvider _atmInfo;
        public DataSharingObject _dataSharer;
        public Monitor()
        {
            InitializeComponent();
            _dataSharer = new DataSharingObject();
            _atmInfo = Cache.GetInstance()._atmInfo;
            TcpChannel channel = new TcpChannel(8090);
            ChannelServices.RegisterChannel(channel,true);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(DataSharingObject), "Server", WellKnownObjectMode.SingleCall);
            Cache.Attach(this);
        }

        public void Notify(string txt)
        {
           // throw new NotImplementedException();
        }

        public void Notify(ATMInfoProvider infoObj)
        {
            Action action = delegate ()
            {
                if (infoObj != null) {
                    lb_cim.Text = infoObj.CIM;
                    lb_cdm.Text = infoObj.CDM;
                    lb_idc.Text = infoObj.IDC;
                    lb_ptr.Text = infoObj.PTR;
                    lb_siu.Text = infoObj.SIU;

                }
            };
            this.BeginInvoke(action);
            Console.Beep(865,44);
        }
    }
}
