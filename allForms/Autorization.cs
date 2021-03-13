using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace allForms
{
    public partial class Autorization : Form
    {
        private DataTable dtLoad;
        public static int userId;
        Point lastPoint;
        public Regex reg;
        public Autorization()
        {
            InitializeComponent();

            this.login.AutoSize = false;
            this.login.Size = new Size(this.login.Size.Width, 35);
            login.TextAlign = HorizontalAlignment.Center;
         
            password.TextAlign = HorizontalAlignment.Center;

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 35);

            login.Tag = login.Text = "Введите логин";
            password.Tag = password.Text = "Введите пароль";
            login.ForeColor = Color.Gray;
            password.ForeColor = Color.Gray;

        }

        // для окна
        private void closeX_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeX_MouseEnter(object sender, EventArgs e)
        {
            closeX.ForeColor = Color.FromArgb(123, 99, 107);
        }

        private void closeX_MouseLeave(object sender, EventArgs e)
        {
            closeX.ForeColor = Color.FromArgb(58, 22, 34);
        }


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


        private void regLabel_Click(object sender, EventArgs e)
        {
            this.Hide(); // прячем  окно 
            Registration registration = new Registration();
            registration.Show();
        }


        private void login_Enter(object sender, EventArgs e)
        {

            if (login.Text == "Введите логин")
            {
                login.Text = "";
                login.ForeColor = Color.FromArgb(58, 22, 34);
            }

        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Введите логин";
                login.ForeColor = Color.Gray;
            }
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {

            var log = login.Text;
            var passw = password.Text;
                    
            //проверки 
            if (login.Text == "Введите логин" || login.Text == "" || !Regex.IsMatch(log, @"^[a-zа-яA-ZА-Я0-9]{4,20}$"))
            {
                MessageBox.Show("Введите логин в корректном виде. Логин может содержать строчные, заглавные буквы аглийского или русского алфвафита, а также цифры. Содержать от 4 до 20 символов");
                return; // выходим из функции 
            }
            if (password.Text == "Введите пароль" || password.Text == " " || !Regex.IsMatch(passw, @"^[a-zа-яA-ZА-Я0-9]{8,16}$"))
            {
                MessageBox.Show("Введите пароль в корректном виде. Пароль может содержать строчные, заглавные буквы аглийского или русского алфвафита, а также цифры. Содержать от 8 до 16 символов");
                return;
            }
            
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator"); client.Open();
            try
            {
                if (client.CheckUser(log, passw) == 1)
                {
                    dtLoad = client.GetUserId(log, passw);
                    userId = int.Parse(dtLoad.Rows[0]["userId"].ToString());
                    MessageBox.Show("Пользователь вошел в систему");

                    this.Hide(); // прячем  окно 
                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                    return;
                }
                else
                {
                    MessageBox.Show("Пользователя с таким логином или паролем нет в системе. Попробуйте еще раз");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка  = " + ex.Message);
            }

            client.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
                password.ForeColor = Color.FromArgb(58, 22, 34);
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.UseSystemPasswordChar = false;
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
            }
        }
    }
}

