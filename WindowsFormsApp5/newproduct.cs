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
using Impinj.OctaneSdk;


namespace WindowsFormsApp5
{
    public partial class newproduct : Form
    {
        SqlConnection connection = Form1.connection;
        public newproduct()
        {
            InitializeComponent();
            
        }

        static ImpinjReader reader = new ImpinjReader();

        

        private void newproduct_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            
            reader.TagsReported += etiketoku;

        }
       
        private void epc_oku_Click(object sender, EventArgs e)
        {
            if (reader.IsConnected)
            {
                reader.Start();
            }
            
            
        }
        public void etiketoku(ImpinjReader sender, TagReport report)
        {
            foreach(Tag tag in report)
            {
                string Epc = tag.Epc.ToString();
                if (!EpcList.Items.Contains(Epc))
                {
                    EpcList.Items.Add(Epc);
                }
                reader.Stop();

            }
        }

        private void sql_kaydet_Click(object sender, EventArgs e)
        {
            
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            SqlCommand checkepc = new SqlCommand("SELECT *FROM newproduct where productno=@pno", connection);
            checkepc.Parameters.AddWithValue("@pno", textBox1.Text);

            SqlDataReader dreader = checkepc.ExecuteReader();
            if (dreader.Read())
            {
                MessageBox.Show("This Product NO has already been registered!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
            }
            else {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
            SqlCommand komutt = new SqlCommand("insert into newproduct (productno,color,edgeprocessing,stoneform,productsize,thickness) values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "')", connection);
            komutt.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("SUCCESSFUL!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!reader.IsConnected)
            {
                try
                {
                    reader.Connect(textBox2.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata:" + ex.Message, "Hata!");
                }
                button1.Text = "Disconnect";
                Settings settings = reader.QueryDefaultSettings();
                settings.Report.Mode = ReportMode.Individual;
                reader.ApplySettings(settings);





            }
            else if (reader.IsConnected)
            {
                reader.Disconnect();
                button1.Text = "Connect";


            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EpcList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
