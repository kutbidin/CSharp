namespace ScanIP
{
    partial class ipScanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_scan = new System.Windows.Forms.Button();
            this.tbx_ipFrom = new System.Windows.Forms.TextBox();
            this.tbx_ipTo = new System.Windows.Forms.TextBox();
            this.lbx_result = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_percent = new System.Windows.Forms.Label();
            this.lb_selectedIP = new System.Windows.Forms.Label();
            this.lb_scanFinish = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_scan
            // 
            this.btn_scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.Location = new System.Drawing.Point(296, 9);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_scan.Size = new System.Drawing.Size(94, 53);
            this.btn_scan.TabIndex = 0;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseMnemonic = false;
            this.btn_scan.UseVisualStyleBackColor = false;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // tbx_ipFrom
            // 
            this.tbx_ipFrom.Location = new System.Drawing.Point(17, 29);
            this.tbx_ipFrom.Name = "tbx_ipFrom";
            this.tbx_ipFrom.Size = new System.Drawing.Size(107, 20);
            this.tbx_ipFrom.TabIndex = 1;
            this.tbx_ipFrom.Text = "192.168.1.1";
            // 
            // tbx_ipTo
            // 
            this.tbx_ipTo.Location = new System.Drawing.Point(170, 29);
            this.tbx_ipTo.Name = "tbx_ipTo";
            this.tbx_ipTo.Size = new System.Drawing.Size(107, 20);
            this.tbx_ipTo.TabIndex = 2;
            this.tbx_ipTo.Text = "192.168.1.25";
            // 
            // lbx_result
            // 
            this.lbx_result.FormattingEnabled = true;
            this.lbx_result.Location = new System.Drawing.Point(12, 74);
            this.lbx_result.Name = "lbx_result";
            this.lbx_result.Size = new System.Drawing.Size(378, 303);
            this.lbx_result.TabIndex = 3;
            this.lbx_result.SelectedIndexChanged += new System.EventHandler(this.lbx_result_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "-->";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 391);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_percent
            // 
            this.lb_percent.AutoSize = true;
            this.lb_percent.Location = new System.Drawing.Point(364, 417);
            this.lb_percent.Name = "lb_percent";
            this.lb_percent.Size = new System.Drawing.Size(19, 13);
            this.lb_percent.TabIndex = 6;
            this.lb_percent.Text = "    ";
            // 
            // lb_selectedIP
            // 
            this.lb_selectedIP.AutoSize = true;
            this.lb_selectedIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_selectedIP.ForeColor = System.Drawing.Color.Indigo;
            this.lb_selectedIP.Location = new System.Drawing.Point(28, 424);
            this.lb_selectedIP.Name = "lb_selectedIP";
            this.lb_selectedIP.Size = new System.Drawing.Size(0, 16);
            this.lb_selectedIP.TabIndex = 7;
            // 
            // lb_scanFinish
            // 
            this.lb_scanFinish.AutoSize = true;
            this.lb_scanFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scanFinish.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_scanFinish.Location = new System.Drawing.Point(212, 428);
            this.lb_scanFinish.Name = "lb_scanFinish";
            this.lb_scanFinish.Size = new System.Drawing.Size(0, 20);
            this.lb_scanFinish.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ip adderess";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "host name";
            // 
            // ipScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_scanFinish);
            this.Controls.Add(this.lb_selectedIP);
            this.Controls.Add(this.lb_percent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_result);
            this.Controls.Add(this.tbx_ipTo);
            this.Controls.Add(this.tbx_ipFrom);
            this.Controls.Add(this.btn_scan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ipScanner";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ipScanner";
            this.Load += new System.EventHandler(this.ipScanner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button btn_scan;
        public System.Windows.Forms.TextBox tbx_ipFrom;
        public System.Windows.Forms.TextBox tbx_ipTo;
        public System.Windows.Forms.ListBox lbx_result;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_percent;
        private System.Windows.Forms.Label lb_selectedIP;
        private System.Windows.Forms.Label lb_scanFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

