namespace ServerAPP
{
     partial class Server
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
            this.components = new System.ComponentModel.Container();
            this.reportTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_cim = new System.Windows.Forms.Label();
            this.lb_cdm = new System.Windows.Forms.Label();
            this.lb_idc = new System.Windows.Forms.Label();
            this.lb_ptr = new System.Windows.Forms.Label();
            this.lb_siu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportTimer
            // 
            this.reportTimer.Interval = 3000;
            this.reportTimer.Tick += new System.EventHandler(this.reportTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIM: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CDM: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "PTR: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "IDC: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "SIU: ";
            // 
            // lb_cim
            // 
            this.lb_cim.AutoSize = true;
            this.lb_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cim.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_cim.Location = new System.Drawing.Point(86, 23);
            this.lb_cim.Name = "lb_cim";
            this.lb_cim.Size = new System.Drawing.Size(60, 24);
            this.lb_cim.TabIndex = 5;
            this.lb_cim.Text = "label6";
            // 
            // lb_cdm
            // 
            this.lb_cdm.AutoSize = true;
            this.lb_cdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cdm.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_cdm.Location = new System.Drawing.Point(86, 71);
            this.lb_cdm.Name = "lb_cdm";
            this.lb_cdm.Size = new System.Drawing.Size(60, 24);
            this.lb_cdm.TabIndex = 6;
            this.lb_cdm.Text = "label7";
            // 
            // lb_idc
            // 
            this.lb_idc.AutoSize = true;
            this.lb_idc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idc.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_idc.Location = new System.Drawing.Point(86, 121);
            this.lb_idc.Name = "lb_idc";
            this.lb_idc.Size = new System.Drawing.Size(60, 24);
            this.lb_idc.TabIndex = 7;
            this.lb_idc.Text = "label8";
            // 
            // lb_ptr
            // 
            this.lb_ptr.AutoSize = true;
            this.lb_ptr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ptr.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_ptr.Location = new System.Drawing.Point(86, 166);
            this.lb_ptr.Name = "lb_ptr";
            this.lb_ptr.Size = new System.Drawing.Size(60, 24);
            this.lb_ptr.TabIndex = 8;
            this.lb_ptr.Text = "label9";
            // 
            // lb_siu
            // 
            this.lb_siu.AutoSize = true;
            this.lb_siu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_siu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_siu.Location = new System.Drawing.Point(86, 211);
            this.lb_siu.Name = "lb_siu";
            this.lb_siu.Size = new System.Drawing.Size(70, 24);
            this.lb_siu.TabIndex = 9;
            this.lb_siu.Text = "label10";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.lb_siu);
            this.Controls.Add(this.lb_ptr);
            this.Controls.Add(this.lb_idc);
            this.Controls.Add(this.lb_cdm);
            this.Controls.Add(this.lb_cim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer reportTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_cim;
        private System.Windows.Forms.Label lb_cdm;
        private System.Windows.Forms.Label lb_idc;
        private System.Windows.Forms.Label lb_ptr;
        private System.Windows.Forms.Label lb_siu;
    }
}

