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
    public partial class frmTdrkGüncelle : Form
    {
        public frmTdrkGüncelle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-VMFK0UF4\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmTedarik frmTedarik = new frmTedarik();
            this.Close();
            frmTedarik.Show();
        }

        private void frmTdrkGüncelle_Load(object sender, EventArgs e)
        {

        }

        private void txtFirmaBul_TextChanged(object sender, EventArgs e)
        {
            if (txtFirmaBul.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            connection.Open();
            SqlCommand command = new SqlCommand("select *from tedarik where firmano like'" + txtFirmaBul.Text + "'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            while (dataRead.Read())
            {
                txtAFirmaAd.Text = dataRead["firmaadı"].ToString();
                txtFirmaTel.Text = dataRead[2].ToString();
                txtFirmaMail.Text = dataRead[3].ToString();
                txtFirmaAdres.Text = dataRead[4].ToString();
                if (dataRead["cocukgiyim"].ToString() =="1")
                {
                    chcCocuk.Checked= true;
                }
                if (dataRead["kadıngiyim"].ToString() == "1")
                {
                    chcKadin.Checked = true;
                }
                if (dataRead["erkekgiyim"].ToString() == "1")
                {
                    chcErkek.Checked = true;
                }
            }
            connection.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtFirmaBul.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            connection.Open();
            SqlCommand command = new SqlCommand("select *from tedarik where firmano ='" + txtFirmaBul.Text + "'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            while (dataRead.Read())
            {
                txtAFirmaAd.Text = dataRead["firmaadı"].ToString();
                txtFirmaTel.Text = dataRead[2].ToString();
                txtFirmaMail.Text = dataRead[3].ToString();
                txtFirmaAdres.Text = dataRead[4].ToString();
                if (dataRead["cocukgiyim"].ToString() == "1")
                {
                    chcCocuk.Checked = true;
                }
                if (dataRead["kadıngiyim"].ToString() == "1")
                {
                    chcKadin.Checked = true;
                }
                if (dataRead["erkekgiyim"].ToString() == "1")
                {
                    chcErkek.Checked = true;
                }
            }
            dataRead.Close();
            connection.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update tedarik set firmaadı=@firmaadı, firmatel=@firmatel, firmamail=@firmamail,firmaadres=@firmaadres, cocukgiyim=@cocukgiyim, kadıngiyim=@kadıngiyim, erkekgiyim=@erkekgiyim where firmano= '" + txtFirmaBul.Text + "'", connection);
            command.Parameters.AddWithValue("@firmaadı", txtAFirmaAd.Text);
            command.Parameters.AddWithValue("@firmatel", txtFirmaTel.Text);
            command.Parameters.AddWithValue("@firmamail", txtFirmaMail.Text);
            command.Parameters.AddWithValue("@firmaadres", txtFirmaAdres.Text);
            command.Parameters.AddWithValue("@cocukgiyim", chcCocuk.Checked);
            command.Parameters.AddWithValue("@kadıngiyim", chcKadin.Checked);
            command.Parameters.AddWithValue("@erkekgiyim", chcErkek.Checked);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Tedarikçi Kaydı Başarıyla Güncellendi");
            foreach (Control controls in grpBoxTedarikGüncelle.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
            }
        }
    }
}
