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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string ipAddress = "192.168.1.1";
        string ipAddress1 = "192.168.1.10";
        string ipAddress2 = "192.168.1.13";
        string ipAddress3 = "192.168.1.14";
        string ipAddress4 = "192.168.1.15";
        string ipAddress5 = "192.168.25";
        private void Form2_Load(object sender, EventArgs e)
        {


        }

        delegate string scanIpDelegate(string ipaddress);
        
private void button1_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(delegate () { scanIP(ipAddress); });
            th.Start();
            Thread th1 = new Thread(delegate () { scanIP(ipAddress1); });
            th1.Start();

            ThreadStart th2 = new ThreadStart(delegate () { scanIP(ipAddress2); });
            ThreadStart th3 = new ThreadStart(delegate () { scanIP(ipAddress3); });
            ThreadStart th4 = new ThreadStart(delegate () { scanIP(ipAddress4); });
            ThreadStart th5 = new ThreadStart(delegate () { scanIP(ipAddress5); });

            string aaa = "";
        }


        public string scanIP(string ipAdress)
        {
            scanIpDelegate rr = new scanIpDelegate(scanIP);

            string ip = ipAdress;

            Ping p = new Ping();
            PingReply reply;

            reply = p.Send(ip);
            if (reply.Status == IPStatus.Success)
                listBox1.Items.Add(ip);

            return "";
        }


    }
}




