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
    public partial class personelekleform : Form
    {
        İstakipform yfrm = new İstakipform();
        string Ad;
        string Soyad;
        string Email;
        string Telefon;
        public int YetkiId;
        string Sifre;
        int PersonelYetkiId;
        public personelekleform()
        {
            InitializeComponent();
        }

        private void PersonelEkleCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void yetkidoldur()
        {
            İstakipform frm = new İstakipform();

            frm.baglanti.Open();

            DataTable tablo = new DataTable("Yetki");
            string sorgu = "select * from Yetki where Durum=1";
            SqlCommand yetkigetir = new SqlCommand(sorgu, frm.baglanti);
            SqlDataReader yetkioku = yetkigetir.ExecuteReader();
            tablo.Load(yetkioku);
            personelYetkiCb.DisplayMember = "Yetki";
            personelYetkiCb.ValueMember = "Id";
            personelYetkiCb.DataSource = tablo;
            frm.baglanti.Close();

        }

        private void PersonelEkleBtn_Click(object sender, EventArgs e)
        {
            DialogResult PersonelEkle = new DialogResult();
            PersonelEkle = MessageBox.Show("Personel Eklensin Mi?", "Personel Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //İstakipform yfrm = new İstakipform();

            if (PersonelEkle == DialogResult.Yes)
            {
                yfrm.baglanti.Open();

                Ad = personelAdiTxt.Text;
                Soyad = personelSoyadiTxt.Text;
                Email = personelEmailtxt.Text;
                Telefon = personelTelefontxt.Text;
                YetkiId = İstakipform.yetkiId;
                Sifre = personelSifreTxt.Text;
                PersonelYetkiId = Convert.ToInt32(personelYetkiCb.SelectedValue);

                SqlCommand personelekle = new SqlCommand();

                personelekle.Connection = yfrm.baglanti;

                personelekle.CommandType = CommandType.StoredProcedure;

                personelekle.CommandText = "AddEmployee";

                personelekle.Parameters.Add("Ad", SqlDbType.NVarChar, 100).Value = Ad;
                personelekle.Parameters.Add("Soyad", SqlDbType.NVarChar, 100).Value = Soyad;
                personelekle.Parameters.Add("Email", SqlDbType.NVarChar, 200).Value = Email;
                personelekle.Parameters.Add("Telefon", SqlDbType.NVarChar, 11).Value = Telefon;
                personelekle.Parameters.Add("YetkiId", SqlDbType.Int).Value = YetkiId;
                personelekle.Parameters.Add("Sifre", SqlDbType.NVarChar, 50).Value = Sifre;
                personelekle.Parameters.Add("PersonelYetkiId", SqlDbType.Int).Value = PersonelYetkiId;
                personelekle.ExecuteNonQuery();

                MessageBox.Show("PPersonel Ekleme İşlemi Tamamlandı");


                personelAdiTxt.Clear();
                personelSoyadiTxt.Clear();
                personelEmailtxt.Clear();
                personelTelefontxt.Clear();

                YetkiId = 0;

                yfrm.baglanti.Close();

                

                yetkidoldur();
            }
            else
            {

                MessageBox.Show("Projeye Sadece Müdür Personel Ekleyebilir ");

            }
            

        }

        private void personelekleform_Load(object sender, EventArgs e)
        {
            yetkidoldur();
            personelYetkiCb.SelectedIndex = -1;
        }
    }
}






