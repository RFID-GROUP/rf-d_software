using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp5
{
    public partial class sendcode : Form
    {
        string OTPCode;
        public static string to;
        public sendcode()
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
        private void sendcode_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void sendcode_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void sendcode_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string from, pass, messageBody;
            Random rand = new Random();
            OTPCode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            to = (textBox1.Text).ToString();
            from = "huzeyfe216@gmail.com";
            pass = "12234";
            messageBody = "your reset code is" + OTPCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Forgot Password  code";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("code send successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OTPCode == (txtvercode.Text).ToString()) 
            {
                to = textBox1.Text;
                changepassword cp = new changepassword();
                this.Hide();
                cp.Show();
            }

          else
            {
                MessageBox.Show("Wrong Code!!!");
            }
        }
    }
}
