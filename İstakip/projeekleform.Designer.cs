
namespace İstakip
{
    partial class projeekleform
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
            this.projeEkleHeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.projeEkleCikisBtn = new System.Windows.Forms.Button();
            this.projeEkleContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firmaAdicb = new System.Windows.Forms.ComboBox();
            this.projeteslimnud = new System.Windows.Forms.NumericUpDown();
            this.projecalisannud = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.projeEkleBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projeAciklamaRtb = new System.Windows.Forms.RichTextBox();
            this.projeAdiTxt = new System.Windows.Forms.TextBox();
            this.projeEkleHeaderPanel.SuspendLayout();
            this.projeEkleContentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeteslimnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecalisannud)).BeginInit();
            this.SuspendLayout();
            // 
            // projeEkleHeaderPanel
            // 
            this.projeEkleHeaderPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.projeEkleHeaderPanel.Controls.Add(this.label1);
            this.projeEkleHeaderPanel.Controls.Add(this.projeEkleCikisBtn);
            this.projeEkleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projeEkleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.projeEkleHeaderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeEkleHeaderPanel.Name = "projeEkleHeaderPanel";
            this.projeEkleHeaderPanel.Size = new System.Drawing.Size(544, 107);
            this.projeEkleHeaderPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proje Ekle";
            // 
            // projeEkleCikisBtn
            // 
            this.projeEkleCikisBtn.BackColor = System.Drawing.Color.Red;
            this.projeEkleCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projeEkleCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.projeEkleCikisBtn.ForeColor = System.Drawing.Color.White;
            this.projeEkleCikisBtn.Location = new System.Drawing.Point(482, 37);
            this.projeEkleCikisBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeEkleCikisBtn.Name = "projeEkleCikisBtn";
            this.projeEkleCikisBtn.Size = new System.Drawing.Size(37, 41);
            this.projeEkleCikisBtn.TabIndex = 5;
            this.projeEkleCikisBtn.Text = "X";
            this.projeEkleCikisBtn.UseVisualStyleBackColor = false;
            this.projeEkleCikisBtn.Click += new System.EventHandler(this.projeEkleCikisBtn_Click);
            // 
            // projeEkleContentPanel
            // 
            this.projeEkleContentPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.projeEkleContentPanel.Controls.Add(this.groupBox1);
            this.projeEkleContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projeEkleContentPanel.Location = new System.Drawing.Point(0, 122);
            this.projeEkleContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeEkleContentPanel.Name = "projeEkleContentPanel";
            this.projeEkleContentPanel.Size = new System.Drawing.Size(544, 548);
            this.projeEkleContentPanel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firmaAdicb);
            this.groupBox1.Controls.Add(this.projeteslimnud);
            this.groupBox1.Controls.Add(this.projecalisannud);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.projeEkleBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.projeAciklamaRtb);
            this.groupBox1.Controls.Add(this.projeAdiTxt);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(511, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Bilgileri";
            // 
            // firmaAdicb
            // 
            this.firmaAdicb.FormattingEnabled = true;
            this.firmaAdicb.Location = new System.Drawing.Point(7, 127);
            this.firmaAdicb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firmaAdicb.Name = "firmaAdicb";
            this.firmaAdicb.Size = new System.Drawing.Size(114, 28);
            this.firmaAdicb.TabIndex = 23;
            // 
            // projeteslimnud
            // 
            this.projeteslimnud.Location = new System.Drawing.Point(7, 292);
            this.projeteslimnud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeteslimnud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.projeteslimnud.Name = "projeteslimnud";
            this.projeteslimnud.Size = new System.Drawing.Size(114, 27);
            this.projeteslimnud.TabIndex = 22;
            this.projeteslimnud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // projecalisannud
            // 
            this.projecalisannud.Location = new System.Drawing.Point(7, 203);
            this.projecalisannud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projecalisannud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.projecalisannud.Name = "projecalisannud";
            this.projecalisannud.Size = new System.Drawing.Size(114, 27);
            this.projecalisannud.TabIndex = 21;
            this.projecalisannud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Proje Teslim Süresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Proje Çalışan Sayısı";
            // 
            // projeEkleBtn
            // 
            this.projeEkleBtn.BackColor = System.Drawing.Color.Green;
            this.projeEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projeEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.projeEkleBtn.ForeColor = System.Drawing.Color.White;
            this.projeEkleBtn.Location = new System.Drawing.Point(317, 344);
            this.projeEkleBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeEkleBtn.Name = "projeEkleBtn";
            this.projeEkleBtn.Size = new System.Drawing.Size(160, 51);
            this.projeEkleBtn.TabIndex = 16;
            this.projeEkleBtn.Text = "Projeyi Ekle";
            this.projeEkleBtn.UseVisualStyleBackColor = false;
            this.projeEkleBtn.Click += new System.EventHandler(this.projeEkleBtn_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Proje Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Firma Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proje Adı";
            // 
            // projeAciklamaRtb
            // 
            this.projeAciklamaRtb.Location = new System.Drawing.Point(161, 53);
            this.projeAciklamaRtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeAciklamaRtb.Name = "projeAciklamaRtb";
            this.projeAciklamaRtb.Size = new System.Drawing.Size(316, 270);
            this.projeAciklamaRtb.TabIndex = 5;
            this.projeAciklamaRtb.Text = "";
            // 
            // projeAdiTxt
            // 
            this.projeAdiTxt.Location = new System.Drawing.Point(7, 53);
            this.projeAdiTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeAdiTxt.Name = "projeAdiTxt";
            this.projeAdiTxt.Size = new System.Drawing.Size(114, 27);
            this.projeAdiTxt.TabIndex = 0;
            // 
            // projeekleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 670);
            this.Controls.Add(this.projeEkleContentPanel);
            this.Controls.Add(this.projeEkleHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "projeekleform";
            this.Text = "projeekleform";
            this.Load += new System.EventHandler(this.projeekleform_Load);
            this.projeEkleHeaderPanel.ResumeLayout(false);
            this.projeEkleHeaderPanel.PerformLayout();
            this.projeEkleContentPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeteslimnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecalisannud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel projeEkleHeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button projeEkleCikisBtn;
        private System.Windows.Forms.Panel projeEkleContentPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button projeEkleBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox projedurumCb;
        private System.Windows.Forms.RichTextBox projeAciklamaRtb;
        private System.Windows.Forms.TextBox projeAdiTxt;
        private System.Windows.Forms.NumericUpDown projeteslimnud;
        private System.Windows.Forms.NumericUpDown projecalisannud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox firmaAdicb;
    }
}