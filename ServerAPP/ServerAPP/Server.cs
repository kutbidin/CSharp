using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using ATM.Cacher;

namespace ServerAPP
{
    public partial class Server: Form
    {
        int _counter = 0;
        ATMInfoProvider _atmStatus;
        DataSharingObject _dataSharer;
        public Server()
        {
            InitializeComponent();
            _atmStatus = new ATMInfoProvider();
            TcpChannel listenerCh = new TcpChannel();
            ChannelServices.RegisterChannel(listenerCh,true);
            _dataSharer = (DataSharingObject)Activator.GetObject(typeof(DataSharingObject), "tcp://localhost:8090/Server");
            reportTimer.Start();

        }
        #region for cross operations
        private delegate string getTextDelegate(Form f,Control c);
        private string getControlText(Form fr, Control ctrl) {
            if (ctrl.InvokeRequired) {
                getTextDelegate dlg = new getTextDelegate(getControlText);
                this.BeginInvoke(dlg, new object[] {fr,ctrl});
            }
            return ctrl.Text;
        }

        private delegate void setTextDelegate(Form f, Control c, string s);
        private void setControlText(Form frm, Control ctrl, string str) {
            if (ctrl.InvokeRequired) {
                setTextDelegate dlg = new setTextDelegate(setControlText);
                this.BeginInvoke(dlg, new object[] { frm,ctrl,str});
            }
            ctrl.Text = str;
        }

        #endregion

        private void reportTimer_Tick(object sender, EventArgs e)
        {
            try
            {

                setAtmCurrentInfo(_atmStatus);
                _dataSharer.SetATMData(_atmStatus);
            }
            catch (Exception ex) {

            }
            _counter++;
            if (_counter > 10) _counter = 0;
        }

        private void setAtmCurrentInfo(ATMInfoProvider atmStatus) {
            atmStatus.CIM = "OK " + _counter;
            atmStatus.CDM = "OK " + _counter;
            atmStatus.IDC = "OK " + _counter;
            atmStatus.PTR = "OK " + _counter;
            atmStatus.SIU = "OK " + _counter;
          
            setControlText(this,lb_cdm,atmStatus.CDM);
            setControlText(this, lb_cim,atmStatus.CIM);
            setControlText(this, lb_ptr, atmStatus.PTR);
            setControlText(this, lb_idc, atmStatus.IDC);
            setControlText(this, lb_siu, atmStatus.SIU);

        }
    }
}
