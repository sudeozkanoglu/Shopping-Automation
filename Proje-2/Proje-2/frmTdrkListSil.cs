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
    public partial class frmTdrkListSil : Form
    {
        public frmTdrkListSil()
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from tedarik where firmano='" + dataGridViewTdrk.CurrentRow.Cells["firmano"].Value.ToString() + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["tedarik"].Clear();
            TedarikciListeleme();
            MessageBox.Show("Tedarikçi Kaydı Başarıyla Silindi !");
        }

        private void TedarikciListeleme()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from tedarik", connection);
            adapter.Fill(dataSet, "tedarik");
            dataGridViewTdrk.DataSource = dataSet.Tables["tedarik"];
            connection.Close();
        }

        private void frmTdrkListSil_Load(object sender, EventArgs e)
        {
            TedarikciListeleme();
        }
    }
}
