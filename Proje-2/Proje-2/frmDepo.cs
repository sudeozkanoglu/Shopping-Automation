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
    public partial class frmDepo : Form
    {
        public frmDepo()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-VMFK0UF4\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
      
        bool cocukGiyim = true;
        bool kadinGiyim = true;
        bool erkekGiyim = true;

        private void txtBarkodNoBul_TextChanged(object sender, EventArgs e)
        {
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("select *from ürün where barkodno like'" + txtBarkodNoBul.Text + "'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            if (txtBarkodNoBul.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            while (dataRead.Read())
            {
                txtÜrünAdı.Text = dataRead["ürünadı"].ToString();
                cmbKategori.Items.Add(dataRead["kategori"].ToString());
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("select *from ürün where barkodno like'" + txtBarkodNoBul.Text + "'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            if (txtBarkodNoBul.Text == "")
            {
                foreach (Control controls in Controls)
                {
                    if (controls is TextBox)
                    {
                        controls.Text = "";
                    }
                }
            }
            while (dataRead.Read())
            {
                txtÜrünAdı.Text = dataRead["ürünadı"].ToString();
                cmbKategori.Items.Add(dataRead["kategori"].ToString());
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("select *from ürün where barkodno like'" + txtBarkodNoBul.Text + "'", connection);
            SqlDataReader dataRead = command.ExecuteReader();
            while (dataRead.Read())
            {
                double alisFiyati = double.Parse(dataRead["alısfiyatı"].ToString());
                txtTutar.Text = (alisFiyati * double.Parse(txtMiktar.Text)).ToString();
                //miktarı silince hata veriyor
                if (txtMiktar.Text == "")
                {
                    txtTutar.Text = "0";
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void txtÜrünKategori_TextChanged(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            cmbTedarik.Items.Clear();
            cmbTedarik.Text = "";

            SqlCommand command = new SqlCommand("select cocukgiyim,kadıngiyim,erkekgiyim from tedarik ", connection);
            SqlDataReader dataRead = command.ExecuteReader();

            while (dataRead.Read())
            {
                if (int.Parse(dataRead["cocukgiyim"].ToString()) == 1)
                {
                    cocukGiyim = true;
                    if (cmbKategori.SelectedItem.ToString()== "Cocuk Giyim")
                    {
                        cmbTedarik.Items.Add(dataRead["firmaadı"].ToString());
                    }
                }
                if (int.Parse(dataRead["kadıngiyim"].ToString()) == 1)
                {
                    kadinGiyim = true;
                    if (cmbKategori.SelectedItem.ToString() == "Kadin Giyim")
                    {
                        cmbTedarik.Items.Add(dataRead["firmaadı"].ToString());
                    }
                }
                if(int.Parse(dataRead["erkekgiyim"].ToString())==1)
                {
                    erkekGiyim = true;
                    if(cmbKategori.SelectedItem.ToString() == "Erkek Giyim")
                    {
                        cmbTedarik.Items.Add(dataRead["firmaadı"].ToString());
                    }
                }
            }
            dataRead.Close();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
