using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;

namespace IPScanner
{
    public partial class Form1 : Form
    {
        string ipfrom= "192.168.1.1", ipto = "192.168.1.25";
        string ipOK = "";
        Stopwatch stp = new Stopwatch();
        StringBuilder ipsb = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            tbx_ipFrom.Text = "192.168.1.1";
            tbx_ipTo.Text = "192.168.1.255";
            backgroundWorker1.RunWorkerAsync();
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            try
            {
                stp = new Stopwatch();
                stp.Start();
                ipfrom = tbx_ipFrom.Text;
                ipto = tbx_ipTo.Text;
                //Thread th1 = new Thread(delegate ()
                //{
                //    scanIP(ipfrom, ipto);
                //});
                //th1.Start();

                ThreadStart th1 = new ThreadStart(delegate () { scanIP("192.168.1.1", "192.168.1.1"); });
                ThreadStart th2 = new ThreadStart(delegate () { scanIP("192.168.1.1", "192.168.1.1"); });


                ipsb.AppendLine(ipOK);
                lbx_result.DataSource = ipsb.ToString().Split('*');
                stp.Stop();
                lb_timer.Text = "Time used:" + stp.Elapsed.Seconds + "(s)";
            }
            catch (Exception exp) { Console.WriteLine("EXXXXXXE"+exp.Message); }

        }

        private void btn_scanParallel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool checkIPformat(string ip)
        {

            bool r = false;
            if (ip != null && ip.Trim() != "")
            {
                string[] ips = ip.Split('.');
                if (ips.Length == 4)
                {
                    foreach (string ipp in ips)
                        if (Convert.ToInt32(ipp) <= 255 && Convert.ToInt32(ipp) >= 0)
                        {
                            r = true;
                        }
                }
            }
            return r;
        }

        private int getIP(string ip, int index)
        {

            int ipp = 0;
            string[] ips = ip.Split('.');
            ipp = Convert.ToInt32(ips[index - 1]);
            return ipp;
        }

        private string getIPbase(string ip)
        {

            string ipBase = "";
            ipBase = ip.Substring(0, ip.LastIndexOf('.'));
            return ipBase;
        }

        private void scanIP(string ipfrom, string ipto)
        {
            string ipOK = "";
            try
            {
                bool r1 = checkIPformat(ipfrom);
                bool r2 = checkIPformat(ipto);
                if (r1 && r2)
                {
                    Ping p = new Ping();
            PingReply reply;
                    string ipn;
                    int ipStart = getIP(ipfrom, 4);
                    int ipEnd = getIP(ipto, 4);
                    //pb_result.Maximum = ipEnd;
                    for (int i = ipStart; i <= ipEnd; i++)
                    {
                        ipn = getIPbase(ipfrom) + "." + i;
                        reply = p.Send(ipn);
                        if (reply.Status == IPStatus.Success)
                        {

                           lbx_result.Items.Add(ipn);
                           //ipsb.AppendLine(ipn+"*");
                            //ipOK = ipn;
                            
                        }
                       // backgroundWorker1.ReportProgress(i);                      
                    }

                }
                else
                {
                    MessageBox.Show("Please input the ip correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
               
            }
            catch (Exception exp) { }
           //  return ipOK; 

        }

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    lbx_result.DataSource = ipsb.ToString().Split('*');

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> ipList = new List<string>();

            int ipStart = getIP(ipfrom, 4);
            int ipEnd = getIP(ipto, 4);
            //pb_result.Maximum = ipEnd;
            for (int i = ipStart; i <= ipEnd; i++)
            {
                ipList.Add( getIPbase(ipfrom) +"." + i);
            }

            foreach (string ipNo in ipList)
            {
                Thread newThread = new Thread(() => { scanIP(ipfrom, ipto); });
                newThread.Start();

            }


        }

 List<Thread> scanIpThreads = new List<Thread>();

        public void CreateThreads()
        {
            Thread th = new Thread(() => { scanIP(ipfrom,ipto); });
            scanIpThreads.Add(th);
        }

      

        //private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    lbx_result.DataSource = ipsb.ToString().Split('*');
        //    pb_result.Value = e.ProgressPercentage;
        //    this.Text = e.ProgressPercentage.ToString();
        //    pb_result.Show();
        //}
    }
}
