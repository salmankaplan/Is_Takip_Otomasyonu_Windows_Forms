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

    public partial class İstakipform : Form
    {
       public static SimpleTcpServer server = new SimpleTcpServer();
        string ipadres = "127.0.0.1";

        public static SimpleTcpClient client = new SimpleTcpClient ();
        public static int oran = 0;
        public SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=IsTakip;Integrated Security=True");
        string kullanıcıadi = "";
        string sifre = "";
        public static int yetkiId;
        bool durum = false;
        int kullanıcıId = 0;
        bolumekleform bolumekleform = new bolumekleform();
        public İstakipform()
        {
            InitializeComponent();
            baglanti.InfoMessage += Baglanti_InfoMessage;
        }

        private void Baglanti_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            kullanıcıadi = kullaniciaditxt.Text;
            sifre = kullanicisifretxt.Text;
            baglanti.Open();
            if (kullanıcıadi != "" && sifre != ""  )
            {
                SqlCommand giriskontrol = new SqlCommand("select * from Personel where Ad='" + kullanıcıadi + "' and Sifre='" + sifre + "'", baglanti);
                SqlDataReader verioku = giriskontrol.ExecuteReader();

                if (verioku.Read())
                {
                    yetkiId = Convert.ToInt32(verioku["YetkiId"]);
                    if (Convert.ToInt32(verioku["YetkiId"]) == 1)
                    {
                        kullanıcıId = Convert.ToInt32(verioku["Id"]);
                        durum = true;
                        bildirimbtn.Enabled = true;
                        bildirimbtn.Visible = true;
                        kullaniciaditxt.Visible = false;
                        kullanicisifretxt.Visible = false;
                        girisbtn.Visible = false;
                        cikisbtn.Visible = true;
                        kullanicilbl.Visible = true;
                        bilgitakippnl.Enabled = true;
                        bilgitakippnl.Visible = true;
                        projeisimtxt.Enabled = true;
                        firmaisimtxt.Enabled = true;
                        projeArabtn.Enabled = true;
                        aramatemizlebtn.Enabled = true;
                        projedgv.Enabled = true;
                        projedgv.Visible = true;
                        projegoruntulepnl.Enabled = true;
                        projegoruntulepnl.Visible = true;
                        projeEklebtn.Enabled = true;
                        projeEklebtn.Visible = true;
                        label3.Enabled = true;
                        label3.Visible = true;
                        label4.Enabled = true;
                        label4.Visible = true;
                        projebolumdgv.Visible = true;
                        projebolumdgv.Enabled = true;
                        projebolumpnl.Visible = true;
                        projebolumpnl.Enabled = true;
                        müdürayarbtn.Enabled = true;
                        müdürayarbtn.Visible = true;
                        kullanicilbl.Text = kullaniciaditxt.Text;
                        this.BackColor = Color.SkyBlue;

                        System.Net.IPAddress ip = System.Net.IPAddress.Parse(ipadres);
                        server.Start(ip, 3535); //0-99000'e kadar port mevcuttur biz 3535 e göre haberleşerek 3535ten veri gelecek

                        MessageBox.Show("Giriş Başarılı", "Istakip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Convert.ToInt32(verioku["YetkiId"]) == 2)
                    {
                        kullanıcıId = Convert.ToInt32(verioku["Id"]);
                        durum = true;
                        bildirimbtn.Enabled = true;
                        bildirimbtn.Visible = true;
                        kullaniciaditxt.Visible = false;
                        kullanicisifretxt.Visible = false;
                        girisbtn.Visible = false;
                        cikisbtn.Visible = true;
                        girisbtn.Visible = false;
                        bilgitakippnl.Visible = true;
                        bilgitakippnl.Enabled = true;
                        projegoruntulepnl.Enabled = true;
                        projegoruntulepnl.Visible = true;
                        projedgv.Visible = true;
                        projedgv.Enabled = true;
                        label4.Visible = true;
                        label3.Visible = true;
                        projebolumdgv.Visible = true;
                        projebolumdgv.Enabled = true;
                        projebolumpnl.Visible = true;
                        projebolumpnl.Enabled = true;
                        kullanicilbl.Text = kullaniciaditxt.Text;
                        //System.Net.IPAddress ip = System.Net.IPAddress.Parse(ipadres);
                        //server.Start(ip, 3534); //0-99000'e kadar port mevcuttur biz 3535 e göre haberleşerek 3535ten veri gelecek
                        
                        kullanicilbl.Visible = true;
                        
                        MessageBox.Show("Giriş Başarılı", "Istakip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
  
                }
                else
                {
                    MessageBox.Show("Girilen Bilgiler Uyuşmuyor.\nLütfen Tekrar Deneyiniz", "Istakip", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Giriş Bilgileri Eksik", "Istakip", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            baglanti.Close();
            ProjeTabloDoldur();
        }
        public void ProjeTabloDoldur()
        {
            baglanti.Open();
            string sorgu;
            if (yetkiId == 1)
            {
                sorgu = "Select Proje.Id,Proje.ProjeAd,Firma.Ad as 'Firma Adı ',Proje.CalisanSayisi,Proje.Sure,Proje.Aciklama from Proje inner join Firma on (Proje.FirmaId=Firma.Id)";
            }
            else
            {

                sorgu = "Select Proje.Id,Proje.ProjeAd,Firma.Ad as 'Firma Adı ',Proje.CalisanSayisi,Proje.Sure,Proje.Aciklama from Proje inner join Firma on (Proje.FirmaId=Firma.Id) inner join Bolumler on (Bolumler.ProjeId=Proje.Id) inner join Personel on (Personel.Id=Bolumler.PersonelId) where Personel.Id=" + kullanıcıId;
                
            }
            DataTable tablo = new DataTable();
            SqlDataAdapter projetablogetir = new SqlDataAdapter(sorgu, baglanti);
            projetablogetir.Fill(tablo);
            projedgv.DataSource = tablo;
            baglanti.Close();

        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            kullaniciaditxt.Clear();
            kullanicisifretxt.Clear();
            kullaniciaditxt.Focus();
            girisbtn.Visible = true;
            kullaniciaditxt.Visible = true;
            kullanicisifretxt.Visible = true;
            bilgitakippnl.Enabled = false;
            projeEklebtn.Enabled = false;
            projedgv.Enabled = false;
            projegoruntulepnl.Enabled = false;
            projeisimtxt.Enabled = false;
            firmaisimtxt.Enabled = false;
            projeArabtn.Enabled = false;
            aramatemizlebtn.Enabled = false;
            projedgv.Enabled = false;
            projegoruntulepnl.Enabled = false;
            projeEklebtn.Enabled = false;
            projebolumdgv.Enabled = false;
            projebolumpnl.Enabled = false;
            müdürayarbtn.Enabled = false;
            projebolumdgv.Visible = false;
            kullaniciaditxt.Focus();
            projebolumdgv.Columns.Clear(); // datagridviewi yenileme 
            server.Stop();//bağlantıyı tamamiyle koparmak amaçlı
            bildirimbtn.Enabled = false;
            kullanicilbl.Text = kullaniciaditxt.Text;

            MessageBox.Show("Çıkış İşlemi Başarılı", "Istakip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void projeEklebtn_Click(object sender, EventArgs e)
        {
            projeekleform pef = new projeekleform();

            pef.YetkiId = yetkiId;

            pef.ShowDialog();
        }

        private void müdürayarbtn_Click(object sender, EventArgs e)
        {
            mudurayarlarform maf = new mudurayarlarform();
            //maf.YetkiId = yetkiId;
            maf.ShowDialog();
        }

        private void projeArabtn_Click(object sender, EventArgs e)
        {
            string projead = "";
            string firmaad = "";
            if (projeisimtxt.Text == "" && firmaisimtxt.Text == "")
            {
                projeisimtxt.Clear();
                firmaisimtxt.Clear();
            }
            else
            {
                if (projeisimtxt.Text != "")
                {
                    projead = projeisimtxt.Text;
                }
                if (firmaisimtxt.Text != "")
                {
                    firmaad = firmaisimtxt.Text;
                }
                baglanti.Open();

                string sorgu = "select Proje.ProjeAd, Firma.Ad as 'Firma Adı', Proje.CalisanSayisi, Proje.Sure, Proje.Aciklama from Proje inner join Firma on (Proje.FirmaId=Firma.Id) where Proje.ProjeAd='" + projead + "' or Firma.Ad='" + firmaad + "'";
                DataTable tablo = new DataTable();
                SqlDataAdapter projeara = new SqlDataAdapter(sorgu, baglanti);
                projeara.Fill(tablo);

                projedgv.DataSource = tablo;

                baglanti.Close();
            }
        }

        private void aramatemizlebtn_Click(object sender, EventArgs e)
        {
            ProjeTabloDoldur();
            projeisimtxt.Clear();
            firmaisimtxt.Clear();
            projeisimtxt.Focus();
        }

        public void bolumTabloDoldur(int ProjeId)
        {
            baglanti.Open();

            string sorgu1;

            if (yetkiId == 1)
            {
                sorgu1 = "select Bolumler.Id, Personel.Ad as 'Personel Adı', Personel.Soyad as 'Personel Soyadı', Proje.ProjeAd as 'Proje Adı', Bolumler.Oran, Bolumler.Sure, Bolumler.Aciklama from Bolumler inner join Personel on(Bolumler.PersonelId=Personel.Id) inner join Proje on(Bolumler.ProjeId=Proje.Id) where Proje.Id=" + ProjeId;
            }
            else
            {
                sorgu1 = "select Bolumler.Id, Personel.Ad as 'Personel Adı', Personel.Soyad as 'Personel Soyadı', Proje.ProjeAd as 'Proje Adı', Bolumler.Oran, Bolumler.Sure, Bolumler.Aciklama from Bolumler inner join Personel on(Bolumler.PersonelId=Personel.Id) inner join Proje on(Bolumler.ProjeId=Proje.Id) where Proje.Id=" + ProjeId + " and Personel.Id=" + kullanıcıId;
            }

            DataTable tablo2 = new DataTable();

            SqlDataAdapter bolumgetir = new SqlDataAdapter(sorgu1, baglanti);

            bolumgetir.Fill(tablo2);

            projebolumdgv.DataSource = tablo2;

            

            for (int i = 0; i < projebolumdgv.Rows.Count; ++i)
            {
                oran = Convert.ToInt32(projebolumdgv.Rows[i].Cells[4].Value);

            }

            baglanti.Close();

        }

        private void projedgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bolumekleform bef = new bolumekleform();
            bef.ProjeId = Convert.ToInt32(projedgv.CurrentRow.Cells["Id"].Value);
            bef.YetkiId = yetkiId;
            
            bef.PersonelId = Convert.ToInt32(projedgv.CurrentRow.Cells["Id"].Value);
            bef.ShowDialog();
        }

        private void projedgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bolumTabloDoldur(Convert.ToInt32(projedgv.CurrentRow.Cells[0].Value));
        }

        private void projebolumdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BolumBitiriciForm bbf = new BolumBitiriciForm();
            BolumBitiriciForm.bolumId = Convert.ToInt32(projebolumdgv.CurrentRow.Cells["Id"].Value);

            //bbf.bolumAd = projebolumdgv.CurrentRow.Cells["BolumAd"].Value;
            bbf.ShowDialog();
        }

        private void İstakipform_Load(object sender, EventArgs e)
        {
           
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //enter komut ile gelen veriyi yakalama
            server.StringEncoder = Encoding.UTF8;
           

        }


        private void İstakipform_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Stop();//bağlantıyı tamamiyle koparmak amaçlı 
        }

        private void bildirimbtn_Click(object sender, EventArgs e)
        {
            tcpconnection tcp = new tcpconnection ();
            tcp.Show();
        }
    }
}


