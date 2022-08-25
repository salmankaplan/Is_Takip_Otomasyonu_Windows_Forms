
namespace İstakip
{
    partial class mudurayarlarform
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
            this.PersonelEkleBtn = new System.Windows.Forms.Button();
            this.firmaeklebtn = new System.Windows.Forms.Button();
            this.mudurayarlarCikisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonelEkleBtn
            // 
            this.PersonelEkleBtn.BackColor = System.Drawing.Color.Green;
            this.PersonelEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PersonelEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonelEkleBtn.ForeColor = System.Drawing.Color.White;
            this.PersonelEkleBtn.Location = new System.Drawing.Point(27, 81);
            this.PersonelEkleBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonelEkleBtn.Name = "PersonelEkleBtn";
            this.PersonelEkleBtn.Size = new System.Drawing.Size(179, 107);
            this.PersonelEkleBtn.TabIndex = 18;
            this.PersonelEkleBtn.Text = "Personel Ekle";
            this.PersonelEkleBtn.UseVisualStyleBackColor = false;
            this.PersonelEkleBtn.Click += new System.EventHandler(this.PersonelEkleBtn_Click);
            // 
            // firmaeklebtn
            // 
            this.firmaeklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firmaeklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.firmaeklebtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firmaeklebtn.ForeColor = System.Drawing.Color.White;
            this.firmaeklebtn.Location = new System.Drawing.Point(27, 196);
            this.firmaeklebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firmaeklebtn.Name = "firmaeklebtn";
            this.firmaeklebtn.Size = new System.Drawing.Size(179, 107);
            this.firmaeklebtn.TabIndex = 27;
            this.firmaeklebtn.Text = "Firma Ekle";
            this.firmaeklebtn.UseVisualStyleBackColor = false;
            this.firmaeklebtn.Click += new System.EventHandler(this.firmaeklebtn_Click);
            // 
            // mudurayarlarCikisBtn
            // 
            this.mudurayarlarCikisBtn.BackColor = System.Drawing.Color.Red;
            this.mudurayarlarCikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mudurayarlarCikisBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mudurayarlarCikisBtn.ForeColor = System.Drawing.Color.White;
            this.mudurayarlarCikisBtn.Location = new System.Drawing.Point(191, 16);
            this.mudurayarlarCikisBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mudurayarlarCikisBtn.Name = "mudurayarlarCikisBtn";
            this.mudurayarlarCikisBtn.Size = new System.Drawing.Size(37, 41);
            this.mudurayarlarCikisBtn.TabIndex = 28;
            this.mudurayarlarCikisBtn.Text = "X";
            this.mudurayarlarCikisBtn.UseVisualStyleBackColor = false;
            this.mudurayarlarCikisBtn.Click += new System.EventHandler(this.mudurayarlarCikisBtn_Click);
            // 
            // mudurayarlarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(241, 520);
            this.Controls.Add(this.mudurayarlarCikisBtn);
            this.Controls.Add(this.firmaeklebtn);
            this.Controls.Add(this.PersonelEkleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mudurayarlarform";
            this.Text = "mudurayarlarform";
            this.Load += new System.EventHandler(this.mudurayarlarform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PersonelEkleBtn;
        private System.Windows.Forms.Button firmaeklebtn;
        private System.Windows.Forms.Button mudurayarlarCikisBtn;
    }
}