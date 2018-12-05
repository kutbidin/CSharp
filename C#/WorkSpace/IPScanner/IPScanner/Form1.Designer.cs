namespace IPScanner
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.tbx_ipFrom = new System.Windows.Forms.TextBox();
            this.lb_startip = new System.Windows.Forms.Label();
            this.tbx_ipTo = new System.Windows.Forms.TextBox();
            this.lb_endip = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_result = new System.Windows.Forms.ListBox();
            this.lb_timer = new System.Windows.Forms.Label();
            this.btn_scanParallel = new System.Windows.Forms.Button();
            this.pb_result = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tbx_ipFrom
            // 
            this.tbx_ipFrom.Location = new System.Drawing.Point(12, 24);
            this.tbx_ipFrom.Name = "tbx_ipFrom";
            this.tbx_ipFrom.Size = new System.Drawing.Size(138, 20);
            this.tbx_ipFrom.TabIndex = 0;
            // 
            // lb_startip
            // 
            this.lb_startip.AutoSize = true;
            this.lb_startip.Location = new System.Drawing.Point(53, 3);
            this.lb_startip.Name = "lb_startip";
            this.lb_startip.Size = new System.Drawing.Size(38, 13);
            this.lb_startip.TabIndex = 1;
            this.lb_startip.Text = "start ip";
            // 
            // tbx_ipTo
            // 
            this.tbx_ipTo.Location = new System.Drawing.Point(188, 24);
            this.tbx_ipTo.Name = "tbx_ipTo";
            this.tbx_ipTo.Size = new System.Drawing.Size(142, 20);
            this.tbx_ipTo.TabIndex = 2;
            // 
            // lb_endip
            // 
            this.lb_endip.AutoSize = true;
            this.lb_endip.Location = new System.Drawing.Point(230, 3);
            this.lb_endip.Name = "lb_endip";
            this.lb_endip.Size = new System.Drawing.Size(36, 13);
            this.lb_endip.TabIndex = 3;
            this.lb_endip.Text = "end ip";
            // 
            // btn_scan
            // 
            this.btn_scan.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_scan.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_scan.Location = new System.Drawing.Point(336, 10);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(110, 89);
            this.btn_scan.TabIndex = 4;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = false;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "to";
            // 
            // lbx_result
            // 
            this.lbx_result.FormattingEnabled = true;
            this.lbx_result.Location = new System.Drawing.Point(12, 105);
            this.lbx_result.Name = "lbx_result";
            this.lbx_result.Size = new System.Drawing.Size(373, 407);
            this.lbx_result.TabIndex = 6;
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_timer.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_timer.Location = new System.Drawing.Point(13, 77);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(143, 16);
            this.lb_timer.TabIndex = 7;
            this.lb_timer.Text = "Time used:0 (s)";
            // 
            // btn_scanParallel
            // 
            this.btn_scanParallel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_scanParallel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scanParallel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_scanParallel.Location = new System.Drawing.Point(188, 51);
            this.btn_scanParallel.Name = "btn_scanParallel";
            this.btn_scanParallel.Size = new System.Drawing.Size(139, 52);
            this.btn_scanParallel.TabIndex = 8;
            this.btn_scanParallel.Text = "Scan MnltiThread";
            this.btn_scanParallel.UseVisualStyleBackColor = false;
            this.btn_scanParallel.Click += new System.EventHandler(this.btn_scanParallel_Click);
            // 
            // pb_result
            // 
            this.pb_result.Location = new System.Drawing.Point(12, 523);
            this.pb_result.Name = "pb_result";
            this.pb_result.Size = new System.Drawing.Size(373, 39);
            this.pb_result.Step = 5;
            this.pb_result.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
           // this.backgroundWorker1.WorkerReportsProgress = true;
           // this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
           /// this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 584);
            this.Controls.Add(this.pb_result);
            this.Controls.Add(this.btn_scanParallel);
            this.Controls.Add(this.lb_timer);
            this.Controls.Add(this.lbx_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.lb_endip);
            this.Controls.Add(this.tbx_ipTo);
            this.Controls.Add(this.lb_startip);
            this.Controls.Add(this.tbx_ipFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_ipFrom;
        private System.Windows.Forms.Label lb_startip;
        private System.Windows.Forms.TextBox tbx_ipTo;
        private System.Windows.Forms.Label lb_endip;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_result;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Button btn_scanParallel;
        private System.Windows.Forms.ProgressBar pb_result;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

