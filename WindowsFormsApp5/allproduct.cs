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
    public partial class allproduct : Form
    {
        SqlConnection connection = Form1.connection;

        public allproduct()
        {
            InitializeComponent();
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

        private void allproduct_Load(object sender, EventArgs e)
        {

            MusteriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE newproduct SET color=@color,edgeprocessing=@edgeprocessing,stoneform=@stoneform,productsize=@productsize,thickness=@thickness,registerdate=@registerdate WHERE productno=@productno";
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@productno", textBox1.Text);
            command.Parameters.AddWithValue("@color", comboBox1.Text);
            command.Parameters.AddWithValue("@edgeprocessing", comboBox2.Text);
            command.Parameters.AddWithValue("@stoneform", comboBox3.Text);
            command.Parameters.AddWithValue("@productsize", comboBox4.Text);
            command.Parameters.AddWithValue("@thickness", comboBox5.Text);
            command.Parameters.AddWithValue("@registerdate", dateTimePicker1.Value);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MusteriGetir();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM newproduct WHERE productno=@productno";
            SqlCommand command = new SqlCommand(sorgu , connection);
            command.Parameters.AddWithValue("@productno",textBox1.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MusteriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
