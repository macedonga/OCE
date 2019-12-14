namespace OCE
{
    partial class Main
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
            this.exBTN = new System.Windows.Forms.Button();
            this.cmdBTN = new System.Windows.Forms.Button();
            this.panelBTN = new System.Windows.Forms.Button();
            this.programs = new System.Windows.Forms.ListBox();
            this.shutdown = new System.Windows.Forms.Button();
            this.reboot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpuTim = new System.Windows.Forms.Timer(this.components);
            this.cpuPB = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ramPercentage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ramPB = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datatest = new System.Windows.Forms.Label();
            this.ramTim = new System.Windows.Forms.Timer(this.components);
            this.data = new System.Windows.Forms.Timer(this.components);
            this.website = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exBTN
            // 
            this.exBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exBTN.Location = new System.Drawing.Point(12, 279);
            this.exBTN.Name = "exBTN";
            this.exBTN.Size = new System.Drawing.Size(100, 100);
            this.exBTN.TabIndex = 0;
            this.exBTN.TabStop = false;
            this.exBTN.Text = "Explorer";
            this.exBTN.UseVisualStyleBackColor = true;
            this.exBTN.Click += new System.EventHandler(this.ExBTN_Click);
            // 
            // cmdBTN
            // 
            this.cmdBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBTN.Location = new System.Drawing.Point(118, 279);
            this.cmdBTN.Name = "cmdBTN";
            this.cmdBTN.Size = new System.Drawing.Size(100, 100);
            this.cmdBTN.TabIndex = 1;
            this.cmdBTN.TabStop = false;
            this.cmdBTN.Text = "CMD";
            this.cmdBTN.UseVisualStyleBackColor = true;
            this.cmdBTN.Click += new System.EventHandler(this.CmdBTN_Click);
            // 
            // panelBTN
            // 
            this.panelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelBTN.Location = new System.Drawing.Point(224, 279);
            this.panelBTN.Name = "panelBTN";
            this.panelBTN.Size = new System.Drawing.Size(100, 100);
            this.panelBTN.TabIndex = 3;
            this.panelBTN.TabStop = false;
            this.panelBTN.Text = "Control Panel";
            this.panelBTN.UseVisualStyleBackColor = true;
            this.panelBTN.Click += new System.EventHandler(this.PanelBTN_Click);
            // 
            // programs
            // 
            this.programs.BackColor = System.Drawing.Color.White;
            this.programs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.programs.FormattingEnabled = true;
            this.programs.Location = new System.Drawing.Point(6, 23);
            this.programs.Name = "programs";
            this.programs.Size = new System.Drawing.Size(420, 342);
            this.programs.TabIndex = 4;
            this.programs.TabStop = false;
            this.programs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Runprogram);
            // 
            // shutdown
            // 
            this.shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdown.Location = new System.Drawing.Point(12, 234);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(150, 40);
            this.shutdown.TabIndex = 5;
            this.shutdown.TabStop = false;
            this.shutdown.Text = "Shutdown";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // reboot
            // 
            this.reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reboot.Location = new System.Drawing.Point(174, 234);
            this.reboot.Name = "reboot";
            this.reboot.Size = new System.Drawing.Size(150, 40);
            this.reboot.TabIndex = 7;
            this.reboot.TabStop = false;
            this.reboot.Text = "Reboot";
            this.reboot.UseVisualStyleBackColor = true;
            this.reboot.Click += new System.EventHandler(this.Reboot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.programs);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(334, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 370);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programs";
            // 
            // cpuTim
            // 
            this.cpuTim.Tick += new System.EventHandler(this.CpuTim_Tick);
            // 
            // cpuPB
            // 
            this.cpuPB.Location = new System.Drawing.Point(86, 19);
            this.cpuPB.Maximum = 50;
            this.cpuPB.Name = "cpuPB";
            this.cpuPB.Size = new System.Drawing.Size(216, 23);
            this.cpuPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpuPB.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ramPercentage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ramPB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cpuPB);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 82);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // ramPercentage
            // 
            this.ramPercentage.Location = new System.Drawing.Point(269, 48);
            this.ramPercentage.Name = "ramPercentage";
            this.ramPercentage.Size = new System.Drawing.Size(33, 23);
            this.ramPercentage.TabIndex = 15;
            this.ramPercentage.Text = "100%";
            this.ramPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "RAM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramPB
            // 
            this.ramPB.Location = new System.Drawing.Point(86, 48);
            this.ramPB.Name = "ramPB";
            this.ramPB.Size = new System.Drawing.Size(179, 23);
            this.ramPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ramPB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "CPU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // h
            // 
            this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(136, 67);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(30, 23);
            this.h.TabIndex = 12;
            this.h.Text = "24";
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(169, 67);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(30, 23);
            this.min.TabIndex = 13;
            this.min.Text = "59";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = ":";
            // 
            // datatest
            // 
            this.datatest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatest.Location = new System.Drawing.Point(12, 89);
            this.datatest.Name = "datatest";
            this.datatest.Size = new System.Drawing.Size(312, 23);
            this.datatest.TabIndex = 15;
            this.datatest.Text = "24";
            this.datatest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramTim
            // 
            this.ramTim.Interval = 50;
            this.ramTim.Tick += new System.EventHandler(this.RamTim_Tick);
            // 
            // data
            // 
            this.data.Interval = 50;
            this.data.Tick += new System.EventHandler(this.Data_Tick);
            // 
            // website
            // 
            this.website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.website.Location = new System.Drawing.Point(155, 12);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(169, 23);
            this.website.TabIndex = 16;
            this.website.TabStop = false;
            this.website.Text = "My website";
            this.website.UseVisualStyleBackColor = true;
            this.website.Click += new System.EventHandler(this.Website_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Created by Marco Ceccon";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.website);
            this.Controls.Add(this.datatest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.min);
            this.Controls.Add(this.h);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reboot);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.panelBTN);
            this.Controls.Add(this.cmdBTN);
            this.Controls.Add(this.exBTN);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(791, 434);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(791, 434);
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProgramSelection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exBTN;
        private System.Windows.Forms.Button cmdBTN;
        private System.Windows.Forms.Button panelBTN;
        private System.Windows.Forms.ListBox programs;
        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.Button reboot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer cpuTim;
        private System.Windows.Forms.ProgressBar cpuPB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ramPB;
        private System.Windows.Forms.Label ramPercentage;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label datatest;
        private System.Windows.Forms.Timer ramTim;
        private System.Windows.Forms.Timer data;
        private System.Windows.Forms.Button website;
        private System.Windows.Forms.Label label3;
    }
}