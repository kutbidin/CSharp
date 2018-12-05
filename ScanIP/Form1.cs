using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;

namespace ScanIP
{
    public partial class ipScanner : Form
    {
        public string ipfrom,ipto,ipn;
        int startIP, endIP;
        float step;
        public Ping pinger;
        public List<string> ipList=new List<string>();
        public PingReply reply;
        
        
        public ipScanner()
        {
            InitializeComponent();
            
        }

        public void btn_scan_Click(object sender, EventArgs e)
        {
            ipfrom = tbx_ipFrom.Text;
            ipto = tbx_ipTo.Text;
            startIP = getIP(ipfrom, 4);
            endIP = getIP(ipto, 4);
            progressBar1.Maximum = endIP;
            progressBar1.Minimum = startIP - 1;
            btn_scan.Enabled = false;
            lbx_result.Items.Clear();
            progressBar1.Value = startIP - 1;
            Thread th1=new Thread(new ThreadStart(scanIP));
            th1.Start();
            timer1.Start();
            //Thread th2 = new Thread(showPbrPercentage);
            //th2.Start();
           
        }

        private void scanIP(){
           ipfrom=tbx_ipFrom.Text;
            ipto=tbx_ipTo.Text;
            step = 100 /(float) (endIP - startIP + 1);
            pinger = new Ping();
            string baseIP=ipfrom.Substring(0,ipfrom.LastIndexOf('.'));
            ThreadHelperClass.setScanStatus(this,lb_scanFinish,"Scanning started...");
            for(int i=startIP;i<=endIP;i++){
                ipn=baseIP+"."+i;
               ThreadHelperClass.setProgressBar(this, progressBar1);
               reply = pinger.Send(ipn, 50);
              if(reply.Status==IPStatus.Success){
                  string hostname = Dns.GetHostEntry(ipn).HostName;
                  ThreadHelperClass.setText(this,lbx_result,ipn+"                "+hostname);
                }
            }
            ThreadHelperClass.setScanStatus(this, lb_scanFinish, "Scanning finished!");
            ThreadHelperClass.setButtonStatus(this,btn_scan,true);
        }
        
      public int getIP(string ipt, int index)
        {
            return Convert.ToInt32(ipt.Split('.')[index - 1]);
        }

        private void lbx_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_selectedIP.Text = lbx_result.SelectedItem.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            lb_percent.Text = Math.Round(step*progressBar1.Value)+"%";
        }

        private void ipScanner_Load(object sender, EventArgs e)
        {

        }

     }
    /// <summary>
    /// threadhelperclass is to do the work in the background , so that the main thread does not wait for work thread
    /// </summary>
    public  class ThreadHelperClass{
        delegate void setTextDelegate(Form fr,Control ctrl, string t1);
        delegate void setProgressDelegate(Form f,ProgressBar pbr);
        delegate void setButtonStatusDelegate(Form form, Button btn, bool state);
        delegate void setScanStateDelegate(Form f,Label lb,string txt);
        public static void setText(Form form,Control ctrl,string content) {
            if(ctrl.InvokeRequired){
                setTextDelegate textSetter = new setTextDelegate(setText);
                form.Invoke(textSetter, new object[] { form,ctrl, content });
            }
            else{
               ((ListBox)ctrl).Items.Add(content);

            }
        }

        public static void setProgressBar(Form form, ProgressBar pbr) {
            
           if(pbr.InvokeRequired){
               setProgressDelegate pbRunner = new setProgressDelegate(setProgressBar);

               form.Invoke(pbRunner,new object[]{form,pbr});
              
           }
            else{
                pbr.Refresh();
                pbr.Value +=1;
                
                
            }
           
        }

        public static void setButtonStatus(Form form, Button btn, bool state) {
            if (btn.InvokeRequired)
            {
                setButtonStatusDelegate btnSetter = new setButtonStatusDelegate(setButtonStatus);
                form.Invoke(btnSetter, new object[] { form, btn, state });
            }
            else {
                btn.Enabled = state;
            }
        }
        public static void setScanStatus(Form f, Label lb, string text) {
            if (lb.InvokeRequired)
            {
                setScanStateDelegate scanState = new setScanStateDelegate(setScanStatus);
                f.Invoke(scanState,new object[]{f,lb,text});
            }
            else {
                lb.Text = text;
            }

        }

    }
    }
