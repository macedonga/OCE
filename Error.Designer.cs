namespace OCE
{
    partial class Error
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
            this.errLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorDesc = new System.Windows.Forms.RichTextBox();
            this.exc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errLBL
            // 
            this.errLBL.AutoSize = true;
            this.errLBL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLBL.Location = new System.Drawing.Point(12, 9);
            this.errLBL.Name = "errLBL";
            this.errLBL.Size = new System.Drawing.Size(179, 30);
            this.errLBL.TabIndex = 0;
            this.errLBL.Text = "An error occured";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // errorDesc
            // 
            this.errorDesc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDesc.Location = new System.Drawing.Point(17, 63);
            this.errorDesc.Name = "errorDesc";
            this.errorDesc.ReadOnly = true;
            this.errorDesc.Size = new System.Drawing.Size(255, 90);
            this.errorDesc.TabIndex = 2;
            this.errorDesc.Text = "";
            // 
            // exc
            // 
            this.exc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exc.Location = new System.Drawing.Point(17, 181);
            this.exc.Name = "exc";
            this.exc.ReadOnly = true;
            this.exc.Size = new System.Drawing.Size(255, 142);
            this.exc.TabIndex = 4;
            this.exc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exception";
            // 
            // cont
            // 
            this.cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cont.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.Location = new System.Drawing.Point(196, 328);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(75, 23);
            this.cont.TabIndex = 5;
            this.cont.Text = "Continue";
            this.cont.UseVisualStyleBackColor = true;
            this.cont.Click += new System.EventHandler(this.Cont_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.exc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errLBL);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Error";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox errorDesc;
        private System.Windows.Forms.RichTextBox exc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cont;
    }
}