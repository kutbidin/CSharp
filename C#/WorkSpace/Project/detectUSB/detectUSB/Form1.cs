using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace detectUSB
{
    public partial class Form1 : Form
    {
        SerialPort port=new SerialPort();
        bool sent = false;
           public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
           {
               if (port.IsOpen)
               {
                   port.Close();
               }
        }
        private void getAllPorts() {
            String[] ports = SerialPort.GetPortNames();

            Array.Sort(ports);
            comboBox1.Items.AddRange(ports);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAllPorts();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "")
                {
                    label1.Text = "Please select port and baud rate first ";
                }
                else
                {
                    //port.PortName = comboBox1.SelectedText;
                    port.PortName = "COM1";
                    port.BaudRate = Convert.ToInt32(comboBox2.Text);
                    port.Open();

                }
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            port.WriteLine(textBox1.Text);
            sent = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sent)
            {
                textBox2.Text = port.ReadLine();
            }
            else {
                textBox2.Text = "no data received";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
    }
}
