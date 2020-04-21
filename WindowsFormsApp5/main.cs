using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void main_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            newproduct np = new newproduct();
            np.TopLevel = false;
            panel1.Controls.Add(np);
            np.Show();
            np.Dock = DockStyle.Fill;
            np.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            allproduct ap = new allproduct();
            ap.TopLevel = false;
            panel1.Controls.Add(ap);
            ap.Show();
            ap.Dock = DockStyle.Fill;
            ap.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            neworder no = new neworder();
            no.TopLevel = false;
            panel1.Controls.Add(no);
            no.Show();
            no.Dock = DockStyle.Fill;
            no.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            sale sale = new sale();
            sale.TopLevel = false;
            panel1.Controls.Add(sale);
            sale.Show();
            sale.Dock = DockStyle.Fill;
            sale.BringToFront();
        }
    }
}
