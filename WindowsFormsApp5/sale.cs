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

namespace WindowsFormsApp5
{
    public partial class sale : Form
    {
        SqlConnection connection = Form1.connection;

        public sale()
        {
            InitializeComponent();
        }

        private void sale_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }
        void MusteriGetir()
        {
            connection.Open();
            string Select = "Select *From newcustomer";
            SqlDataAdapter da = new SqlDataAdapter(Select, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sale = new SqlCommand("insert into sale (price,name) values('" + textBox1.Text + "','" + textBox2.Text + "')", connection);
            sale.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("SUCCESSFUL!!!");
        }
    }
}
