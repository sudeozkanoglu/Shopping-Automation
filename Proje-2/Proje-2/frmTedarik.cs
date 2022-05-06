using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_2
{
    public partial class frmTedarik : Form
    {
        public frmTedarik()
        {
            InitializeComponent();
        }

        private void btnTdrkEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTedarikciEkle tedarikciEkle = new frmTedarikciEkle();
            tedarikciEkle.ShowDialog();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Close();
            frm1.Show();
        }

        private void btnTdrkGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTdrkGüncelle tedarikGüncelle = new frmTdrkGüncelle();
            tedarikGüncelle.ShowDialog();
        }

        private void btnTdrkListSil_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTdrkListSil tedarikListSil = new frmTdrkListSil();
            tedarikListSil.ShowDialog();
        }
    }
}
