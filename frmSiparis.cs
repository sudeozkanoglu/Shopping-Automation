﻿using System;
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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void btnSiparisEt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSiparisOlusturma siparisEt = new frmSiparisOlusturma();
            siparisEt.ShowDialog();
        }
    }
}
