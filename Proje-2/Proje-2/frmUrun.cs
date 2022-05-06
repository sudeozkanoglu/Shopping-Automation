﻿using System;
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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-VMFK0UF4\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        bool condition = true;
        private void barkodNoEngelleme()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from ürün",connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (txtUrünBarkod.Text==dataReader["barkodno"].ToString() || txtUrünBarkod.Text=="")
                {
                    condition = false;
                }
            }
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodNoEngelleme();
            if (condition==true)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into ürün(ürünadı,barkodno,kategori,alısfiyatı,satısfiyatı) values(@ürünadı,@barkodno,@kategori,@alısfiyatı,@satısfiyatı)", connection);
                command.Parameters.AddWithValue("@ürünadı", txtUrünAdi.Text);
                command.Parameters.AddWithValue("@barkodno", txtUrünBarkod.Text);
                command.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                command.Parameters.AddWithValue("@alısfiyatı", double.Parse(txtAlis.Text));
                command.Parameters.AddWithValue("@satısfiyatı", double.Parse(txtSatis.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarı İle Eklendi");
            }
            else
            {
                MessageBox.Show("Barkod Kodu Aynı Ya Da Boş Olamaz !");
            }
      
            foreach (Control controls in grpBoxUrünEkle.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text="";
                }
                if(controls is ComboBox)
                {
                    controls.Text = "";
                }
            }
            connection.Close();
        }
    }
}
