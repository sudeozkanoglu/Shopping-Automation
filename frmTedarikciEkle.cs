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
namespace Proje_2
{
    public partial class frmTedarikciEkle : Form
    {
        public frmTedarikciEkle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-VMFK0UF4\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTedarik frmTedarik = new frmTedarik();
            this.Close();
            frmTedarik.Show();
        }

        private void frmTedarikciEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tedarik(firmano,firmaadı,firmatel,firmamail,firmaadres,cocukgiyim,kadıngiyim,erkekgiyim) values(@firmano,@firmaadı,@firmatel,@firmamail,@firmaadres,@cocukgiyim,@kadıngiyim,@erkekgiyim) " , connection);
            command.Parameters.AddWithValue("@firmano", txtFirmaNo.Text);
            command.Parameters.AddWithValue("@firmaadı",txtFirmaAd.Text);
            command.Parameters.AddWithValue("@firmatel", txtFirmaTel.Text);
            command.Parameters.AddWithValue("@firmamail", txtFirmaMail.Text);
            command.Parameters.AddWithValue("@firmaadres", txtFirmaAdres.Text);
            command.Parameters.AddWithValue("@cocukgiyim", chcCocuk.Checked);
            command.Parameters.AddWithValue("@kadıngiyim", chcKadin.Checked);
            command.Parameters.AddWithValue("@erkekgiyim", chcErkek.Checked);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Tedarikçi Başarıyla Eklendi !");
            foreach (Control controls in groupBox1.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
            }
        }
    }
}
