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

    public partial class neworder : Form
    {
        SqlConnection connection = Form1.connection;

        public neworder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        void MusteriGetir()
        {
            connection.Open();
            string Select = "Select *From newproduct";
            SqlDataAdapter da = new SqlDataAdapter(Select, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        

        private void neworder_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into newcustomer (name,mail,phonenumber,degree,company,productno) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", connection);
            ekle.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("SUCCESSFUL!!!");
        }
    }
}
