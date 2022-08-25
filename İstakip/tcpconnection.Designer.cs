
namespace İstakip
{
    partial class tcpconnection
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
            this.label4 = new System.Windows.Forms.Label();
            this.serverrtb = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serverBaglanbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.porttxt = new System.Windows.Forms.TextBox();
            this.ipadrestxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.denemeRtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Server Durum";
            // 
            // serverrtb
            // 
            this.serverrtb.Location = new System.Drawing.Point(86, 196);
            this.serverrtb.Name = "serverrtb";
            this.serverrtb.Size = new System.Drawing.Size(217, 96);
            this.serverrtb.TabIndex = 23;
            this.serverrtb.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bildirimler ";
            // 
            // serverBaglanbtn
            // 
            this.serverBaglanbtn.BackColor = System.Drawing.Color.Lime;
            this.serverBaglanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.serverBaglanbtn.Location = new System.Drawing.Point(86, 116);
            this.serverBaglanbtn.Name = "serverBaglanbtn";
            this.serverBaglanbtn.Size = new System.Drawing.Size(217, 35);
            this.serverBaglanbtn.TabIndex = 20;
            this.serverBaglanbtn.Text = "Server Bağlan";
            this.serverBaglanbtn.UseVisualStyleBackColor = false;
            this.serverBaglanbtn.Click += new System.EventHandler(this.serverBaglanbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Port Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ip Adresi:";
            // 
            // porttxt
            // 
            this.porttxt.Location = new System.Drawing.Point(202, 67);
            this.porttxt.Name = "porttxt";
            this.porttxt.Size = new System.Drawing.Size(100, 23);
            this.porttxt.TabIndex = 17;
            // 
            // ipadrestxt
            // 
            this.ipadrestxt.Location = new System.Drawing.Point(86, 67);
            this.ipadrestxt.Name = "ipadrestxt";
            this.ipadrestxt.Size = new System.Drawing.Size(100, 23);
            this.ipadrestxt.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(580, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 25;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // denemeRtb
            // 
            this.denemeRtb.Location = new System.Drawing.Point(376, 67);
            this.denemeRtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.denemeRtb.Name = "denemeRtb";
            this.denemeRtb.Size = new System.Drawing.Size(149, 226);
            this.denemeRtb.TabIndex = 27;
            this.denemeRtb.Text = "";
            // 
            // tcpconnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(608, 338);
            this.Controls.Add(this.denemeRtb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serverrtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverBaglanbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.porttxt);
            this.Controls.Add(this.ipadrestxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tcpconnection";
            this.Text = "tcpconnection";
            this.Load += new System.EventHandler(this.tcpconnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox serverrtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button serverBaglanbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox porttxt;
        private System.Windows.Forms.TextBox ipadrestxt;
        private System.Windows.Forms.Button button1;
        public  System.Windows.Forms.RichTextBox denemeRtb;
    }
}