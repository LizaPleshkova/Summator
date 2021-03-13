using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // для окна
        private void closeX_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void closeX_MouseEnter(object sender, EventArgs e)
        {
            closeX.ForeColor = Color.Aquamarine;
        }

        private void closeX_MouseLeave(object sender, EventArgs e)
        {
            closeX.ForeColor = Color.DarkOrchid;
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        
        private void login_Enter(object sender, EventArgs e)
        {

            if (login.Text == "Введите имя")
            {
                login.Text = " ";
                login.ForeColor = Color.Black;
            }

        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == " ")
            {
                login.Text = "Введите имя";
                login.ForeColor = Color.Gray;
            }
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            var log = login.Text;
            var passw = password.Text;

            //var conn = new NpgsqlConnection(connectionString);
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            Console.WriteLine(client.CheckUser(log, passw));
            try
            {

                if (client.CheckUser(log, passw) == 1)
                {
                    MessageBox.Show("Пользователь вошел в систему");
                  
                    return;
                }
                else
                {
                    MessageBox.Show("Пользователя с таким логином или паролем нет в системе");
                    return;
                }


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Запустилосась ошибка из формы авториз ");
                MessageBox.Show("Ошибка  = " + ex.Message);
            }

            client.Close();


            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
