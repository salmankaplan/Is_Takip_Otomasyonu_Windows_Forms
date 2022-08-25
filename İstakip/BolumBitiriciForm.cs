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
using SimpleTCP;

namespace İstakip
{
    public partial class BolumBitiriciForm : Form
    {
        
        public static int bolumId = 0;
        
        public static string personeladsoyad;

        public static string projebolum;

        public static int yuzdeDilimi, sure;
        public static string projeBolumAdi, personelAdSoyad, aciklama;

        

        public BolumBitiriciForm()
        {
            InitializeComponent();
        }

        private void BolumBitiriciForm_Load(object sender, EventArgs e)
        {

            
            bitenbolumHeaderPanel.Size = new Size(this.Width, 80);
            bitenbolumcontpnl.Size = new Size(this.Width, this.Height - 80);
            
            personelCbdoldur();
           
            bolumgetir(bolumId);
            groupBox1.Enabled = false;
          
        }


        public void personelCbdoldur()
        {
            İstakipform itf = new İstakipform();
            itf.baglanti.Open();
            personeladsoyadcb.SelectedIndex = -1;
            DataTable tablo = new DataTable("Personel");
            string sorgu = "select * from Personel where Durum=1 ";
            SqlCommand pcd = new SqlCommand(sorgu, itf.baglanti);
            SqlDataReader personeloku = pcd.ExecuteReader();
            tablo.Load(personeloku);
            personeladsoyadcb.DisplayMember = "Ad";
            personeladsoyadcb.ValueMember = "Id";
            personeladsoyadcb.DataSource = tablo;
            itf.baglanti.Close();
        }

        public void bolumgetir(int Id)
        {
            //personeladsoyadcb.SelectedIndex = -1;

            İstakipform itf = new İstakipform();
            itf.baglanti.Open();
            string sorgu = "select * from Bolumler inner join Proje on(Proje.Id=Bolumler.ProjeId) where Bolumler.Id=" + Id + "";

            SqlCommand bg = new SqlCommand(sorgu, itf.baglanti);
            SqlDataReader bolumoku = bg.ExecuteReader();

            if (bolumoku.Read())
            {
                projeismitxt.Text = bolumoku["ProjeAd"].ToString();
                projebolumtxt.Text = bolumoku["BolumAd"].ToString();
                personeladsoyadcb.SelectedValue = bolumoku["PersonelId"].ToString();
               
                
                bolumyuzdenud.Value = Convert.ToInt32(bolumoku["Oran"]);
                surenud.Value = Convert.ToInt32(bolumoku["Sure"]);
                bolumaciklamatxt.Text = bolumoku["Aciklama"].ToString();
                
            }
            itf.baglanti.Close();
        }

        private void bolumbitiCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public static int yuzdeDilimi, sure;
        //public static string projeBolumAdi, personelAdSoyad, aciklama;

        private void bölümbitirbtn_Click(object sender, EventArgs e)
        {
            projeBolumAdi = projebolumtxt.Text;
            personelAdSoyad = personeladsoyadcb.Text;
            yuzdeDilimi = Convert.ToInt32(bolumyuzdenud.Value);
            sure = Convert.ToInt32(surenud.Value);
            aciklama = bolumaciklamatxt.Text;

            İstakipform.client.WriteLineAndGetReply(personelAdSoyad + " adlı personel " + bolumId + " numaralı projenin " + projeBolumAdi + " bölümünü " + yuzdeDilimi + " 'lik kısmını tamamladı.\nAçıklama: " + aciklama, TimeSpan.FromSeconds(3));

             bölümbitirbtn.BackColor = Color.Green;

            
        }
    }
}
