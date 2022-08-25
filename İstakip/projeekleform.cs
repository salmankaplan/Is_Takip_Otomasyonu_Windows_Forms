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
    public partial class projeekleform : Form
    {
        public int YetkiId;
        int FirmaId;
        string Aciklama;
        string ProjeAd;
        int CalisanSayisi;
        int Sure;
        public projeekleform()
        {
            InitializeComponent();
        }

        private void projeEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projeekleform_Load(object sender, EventArgs e)
        {

            projeEkleHeaderPanel.Size = new Size(this.Width, 80);
            projeEkleContentPanel.Size = new Size(this.Width, this.Height - 80);
            firmaCbDoldur();

        }

        public void firmaCbDoldur()
        {
            İstakipform frm = new İstakipform();

            frm.baglanti.Open();

            DataTable tablo = new DataTable("Firma");
            string sorgu = "select * from Firma where Durum=1";
            SqlCommand firmagetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader firmaoku = firmagetir.ExecuteReader();
            tablo.Load(firmaoku);

            firmaAdicb.DisplayMember = "Ad";
            firmaAdicb.ValueMember = "Id";
            firmaAdicb.DataSource = tablo;

            frm.baglanti.Close();
        }

        private void projeEkleBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult projeekle = new DialogResult();
            projeekle = MessageBox.Show("Proje Eklensin Mi?", "Proje Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                İstakipform yfrm = new İstakipform();
            if (projeekle == DialogResult.Yes)
            {
                
                yfrm.baglanti.Open();

                ProjeAd = projeAdiTxt.Text;
                FirmaId = Convert.ToInt32(firmaAdicb.SelectedValue);
                Aciklama = projeAciklamaRtb.Text;
                CalisanSayisi = Convert.ToInt32(projecalisannud.Value);
                Sure = Convert.ToInt32(projeteslimnud.Value);

                SqlCommand projever = new SqlCommand();
                projever.Connection = yfrm.baglanti;
                projever.CommandType = CommandType.StoredProcedure;
                projever.CommandText = "Project";
                projever.Parameters.Add("YetkiId", SqlDbType.Int).Value = YetkiId;

                projever.Parameters.Add("ProjeAd", SqlDbType.NVarChar,200).Value = ProjeAd;

                projever.Parameters.Add("FirmaId", SqlDbType.Int).Value = FirmaId;
                projever.Parameters.Add("Aciklama", SqlDbType.NVarChar,550).Value = Aciklama;
                projever.Parameters.Add("CalisanSayisi", SqlDbType.Int).Value = CalisanSayisi;
                projever.Parameters.Add("Sure", SqlDbType.Int).Value = Sure;

                projever.ExecuteNonQuery();

                MessageBox.Show("Proje Verildi ");

                projeAdiTxt.Clear();
                projeAciklamaRtb.Clear();
                YetkiId = 0;
                FirmaId = 0;

                yfrm.baglanti.Close();

                firmaCbDoldur();
            }
            else
            {
                MessageBox.Show("Proje Ekleme İşlemi İptal Edildi.");
            }
            yfrm.baglanti.InfoMessage += Baglanti_InfoMessage;

            #region

            //if (projeAdiTxt.Text != "" && firmaAdicb.SelectedIndex != -1 && projeAciklamaRtb.Text != "" && projedurumCb.SelectedIndex != -1)
            //{
            //    İstakipform frm = new İstakipform();

            //    frm.baglanti.Open();

            //    string sorgu = "insert into Proje(ProjeAd,FirmaId,CalisanSayisi,Sure,Aciklama,Durum)" +
            //        "Values('" + projeAdiTxt.Text + "'," + Convert.ToInt32(firmaAdicb.SelectedValue) + "," + projecalisannud.Value + "," + projeteslimnud.Value + ",'" + projeAciklamaRtb.Text + "'," + projedurumCb.SelectedIndex + ")";

            //    SqlCommand projeekle = new SqlCommand(sorgu, frm.baglanti);
            //    projeekle.ExecuteNonQuery();
            //    MessageBox.Show("Proje Ekleme Başarılı");

            //    frm.baglanti.Close();

            //}
            //else
            //{
            //    MessageBox.Show("Eksik bilgi girildi. Tekrar deneyiniz");
            //}
            //baglanti.InfoMessage += new SqlInfoMessageEventHandler(baglanti_ınfomessage);
            //İstakipform frm = new İstakipform();

            //
            #endregion
        }

        private void Baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

    }
}
  

