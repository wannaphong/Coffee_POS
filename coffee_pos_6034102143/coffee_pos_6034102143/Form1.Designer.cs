namespace coffee_pos_6034102143
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Payment = new System.Windows.Forms.TabPage();
            this.ok_pay = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee POS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Payment);
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Location = new System.Drawing.Point(12, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 414);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.ok_pay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(4, 22);
            this.Payment.Name = "Payment";
            this.Payment.Padding = new System.Windows.Forms.Padding(3);
            this.Payment.Size = new System.Drawing.Size(748, 166);
            this.Payment.TabIndex = 1;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // ok_pay
            // 
            this.ok_pay.Location = new System.Drawing.Point(155, 330);
            this.ok_pay.Name = "ok_pay";
            this.ok_pay.Size = new System.Drawing.Size(75, 23);
            this.ok_pay.TabIndex = 0;
            this.ok_pay.Text = "OK";
            this.ok_pay.UseVisualStyleBackColor = true;
            this.ok_pay.Click += new System.EventHandler(this.ok_pay_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(793, 388);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 546);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Coffee POS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Payment;
        private System.Windows.Forms.Button ok_pay;
        private System.Windows.Forms.TabPage About;
    }
}

