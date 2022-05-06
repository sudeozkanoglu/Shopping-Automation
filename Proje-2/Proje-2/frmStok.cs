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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }

        private void btnUrün_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUrun ürün = new frmUrun();
            ürün.ShowDialog();
        }

        private void btnDepoTedarik_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDepo depo = new frmDepo();
            depo.ShowDialog();
        }
    }
}
