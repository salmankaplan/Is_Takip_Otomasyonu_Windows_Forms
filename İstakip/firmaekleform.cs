using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İstakip
{
    public partial class firmaekleform : Form
    {
        string Ad;
        string Aciklama;
        public int YetkiId;

        public firmaekleform()
        {
            InitializeComponent();
        }

        private void kitapEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firmaekleform_Load(object sender, EventArgs e)
        {

            firmaEkleHeaderPanel.Size = new Size(this.Width, 80);
            firmaEkleHeaderPanel.Size = new Size(this.Width, this.Height - 80);
        }

        private void firmaekleBtn_Click(object sender, EventArgs e)
        {
            DialogResult firmaekle = new DialogResult();
            firmaekle = MessageBox.Show("Firma Eklensin Mi?", "Firma Ekleme Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            İstakipform yfrm = new İstakipform();

            if (firmaekle == DialogResult.Yes)
            {

                yfrm.baglanti.Open();

                Ad = FirmaAdiTxt.Text;
                Aciklama = firmaAciklamaRtb.Text;
                YetkiId= YetkiId = İstakipform.yetkiId;

                SqlCommand firmaver = new SqlCommand();

                firmaver.Connection = yfrm.baglanti;
                firmaver.CommandType = CommandType.StoredProcedure;
                firmaver.CommandText = "CompanyAdd";
                firmaver.Parameters.Add("Ad", SqlDbType.NVarChar,100).Value = Ad;
                firmaver.Parameters.Add("Aciklama", SqlDbType.NVarChar,1000).Value = Aciklama;
                firmaver.Parameters.Add("YetkiId", SqlDbType.Int).Value = YetkiId;
                firmaver.ExecuteNonQuery();

                MessageBox.Show("Firma Eklendi ");

                FirmaAdiTxt.Clear();
                firmaAciklamaRtb.Clear();
                YetkiId = 0;

                yfrm.baglanti.Close();
            }
            else
            {
                MessageBox.Show("Proje Ekleme İşlemi İptal Edildi.");
            }
            yfrm.baglanti.InfoMessage += Baglanti_InfoMessage;
        }

        private void Baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }
    }
}
