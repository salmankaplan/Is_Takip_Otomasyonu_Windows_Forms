using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstakip
{
    public partial class mudurayarlarform : Form
    {
        public int YetkiId;


        public mudurayarlarform()
        {
            InitializeComponent();
        }

        private void mudurayarlarCikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firmaeklebtn_Click(object sender, EventArgs e)
        {
            firmaekleform fef = new firmaekleform();

            fef.ShowDialog();
        }

        private void PersonelEkleBtn_Click(object sender, EventArgs e)
        {
            personelekleform pef = new personelekleform();
            pef.YetkiId = YetkiId;
            pef.ShowDialog();
        }

        private void mudurayarlarform_Load(object sender, EventArgs e)
        {

        }
    }
}
