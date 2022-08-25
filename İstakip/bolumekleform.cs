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
    public partial class bolumekleform : Form
    {
        public int ProjeId;
        public int PersonelId;
        public int YetkiId;
        public int FirmaId;
        public int Oran;
        public int OranToplam;
        string BolumAd;
        string Aciklama;
        public int Sure;
        public bolumekleform()
        {
            InitializeComponent();


        }

        private void bolumekleform_Load(object sender, EventArgs e)
        {
            projegetir(ProjeId);
            personelCbdoldur(PersonelId);
            projeisimtxt.Enabled = false;

            if (YetkiId != 1)
            {
                bölümatabtn.Enabled = false;
            }
        }

        private void bolumEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void projegetir(int Id)
        {
            İstakipform itf = new İstakipform();
            itf.baglanti.Open();

            string sorgu = "select * from Proje where Id= " + Id;
            SqlCommand pg = new SqlCommand(sorgu, itf.baglanti);
            SqlDataReader projeoku = pg.ExecuteReader();
            if (projeoku.Read())
            {
                ProjeId = Convert.ToInt32(projeoku["Id"]);
                projeisimtxt.Text = projeoku["ProjeAd"].ToString();
            }

            itf.baglanti.Close();
        }

        public static void ExecuteProcedure(string procedure, string[] parameters, SqlDbType[] dbTypes, object[] values)
        {
            İstakipform itf = new İstakipform();
            itf.baglanti.Open();

            SqlCommand command = new()
            {
                Connection = itf.baglanti,
                CommandType = CommandType.StoredProcedure,
                CommandText = procedure
            };

            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i], dbTypes[i]).Value = values[i];
            }

            command.ExecuteNonQuery();



            itf.baglanti.Close();
        }

        public void personelCbdoldur(int Id)
        {
            İstakipform itf = new İstakipform();
            itf.baglanti.Open();
            DataTable tablo = new DataTable("Personel");
            string sorgu = "select Id,(Ad+' '+Soyad)as Ad from Personel where Durum=1 ";
            SqlCommand pcd = new SqlCommand(sorgu, itf.baglanti);
            SqlDataReader personeloku = pcd.ExecuteReader();
            tablo.Load(personeloku);

            personeladsoyadcb.DisplayMember ="Ad";
            //personeladsoyadcb.DisplayMember = "Soyad";
            personeladsoyadcb.ValueMember = "Id";
            //personeladsoyadcb.DisplayMember = "Soyad";
            //personeladsoyadcb.ValueMember = "Id";
            personeladsoyadcb.DataSource = tablo;


            itf.baglanti.Close();
        }

        private void bölümatabtn_Click(object sender, EventArgs e)
        {
            DialogResult bolumekle = new DialogResult();
            bolumekle = MessageBox.Show("Bölüm Eklensin Mi?", "Bölüm Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            İstakipform itf = new İstakipform();



            if (bolumekle == DialogResult.Yes)
            {
                
                BolumAd = projebolumtxt.Text;
                Oran = Convert.ToInt32(bolumyuzdenud.Value);
                Aciklama = personelAciklamatxt.Text;
                PersonelId = Convert.ToInt32(personeladsoyadcb.SelectedValue);
                Sure = Convert.ToInt32(surenud.Value);
                //Oran += İstakipform.oran;
                Oran = Convert.ToInt32(bolumyuzdenud.Value);
             
                ExecuteProcedure("AddDuty", new string[] { "YetkiId", "ProjeId", "BolumAd", "PersonelId", "Oran", "Aciklama", "Sure" }, new SqlDbType[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.Int }, new object[] { YetkiId, ProjeId, BolumAd, PersonelId, Oran, Aciklama, Sure });

                projeisimtxt.Clear();
                projebolumtxt.Clear();
                personeladsoyadcb.SelectedIndex = -1;
                PersonelId = 0;
                    //itf.baglanti.Close();

                personelCbdoldur(PersonelId);

                projegetir(ProjeId);
                

        

            }
            else
            {
                MessageBox.Show("Bölüm Ekleme İşlemi İptal Edildi.");
            }

        }
    }
}


