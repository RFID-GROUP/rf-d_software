using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp5
{
    public partial class changepassword : Form
    {
        string username = sendcode.to;
        public changepassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void changepassword_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void changepassword_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void changepassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newpass.Text == confimpass.Text)
            {
                SqlConnection connection = Form1.connection;
                SqlCommand command= new SqlCommand("UPDATE Marble set pass='"+confimpass.Text+"' where e_mail='"+username+"'", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("password reset sucessfully...");


            }
            else
            {
                MessageBox.Show("the new password not matched so try agaın");
            }
        }
    }
}
