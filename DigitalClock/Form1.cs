using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Clock : Form
    {
        Timer t = new Timer();
        string time="";
        public Clock()
        {
            InitializeComponent();
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }
        private string formatter(int s)
        {
            string ss = "" + s;
            if (s < 10)
                ss = "0" + s;
            return ss;
        
        }
        private void t_Tick(object sender,EventArgs e) {

            int hh=DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            time = formatter(hh) + ":" + formatter(mm) + ":" + formatter(ss);
            label1.Text = time;
        }
        

    }
}
