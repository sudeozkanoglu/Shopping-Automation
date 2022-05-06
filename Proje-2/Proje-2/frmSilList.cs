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
    public partial class frmSilList : Form
    {
        public frmSilList()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-VMFK0UF4\\SQLEXPRESS;Initial Catalog=Proje_2;Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from musteri_ekle where tc='"+dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'",connection);
            command.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["musteri_ekle"].Clear();
            Kayıt_Listeleme();
            MessageBox.Show("Müşteri Kaydı Başarıyla Silindi !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri();
            this.Close();
            frmMusteri.Show();
        }

        private void frmSilList_Load(object sender, EventArgs e)
        {
            Kayıt_Listeleme();
        }

        private void Kayıt_Listeleme()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from musteri_ekle", connection);
            adapter.Fill(dataSet, "musteri_ekle");
            dataGridView1.DataSource = dataSet.Tables["musteri_ekle"];
            connection.Close();
        }
    }
}
