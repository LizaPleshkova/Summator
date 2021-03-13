using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Authorization
{
    public partial class Form1 : Form
    {
        private const String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=2409;Database=planner;";
      
        public Form1()
        {
            InitializeComponent();

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 40);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new Summator.SummatorClient("NetTcpBinding_ISummator");
            List<User> users = GetUsers();
            foreach (User i in users)
            {
                Console.WriteLine(i.ID + " : " + i.Login);
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var con = new NpgsqlConnection(connectionString))
            {
                con.Open();

                var sql = "select * from users";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            User cr = new User(rdr.GetString(1), rdr.GetString(2));
                            users.Add(cr);
                        }
                    }
                }
            }
            return users;
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            var log = login.Text;
            var passw = password.Text;
            User newUser = new User(log, passw);
            int count = 0;
            var conn = new NpgsqlConnection(connectionString);
            var client = new Summator.SummatorClient("NetTcpBinding_ISummator");

            try
            {
                conn.Open();

                List<User> users = GetUsers();
                
                foreach (User user in users)
                {
                    if(user.Login == newUser.Login && user.Password == newUser.Password) count++;
                                      
                }
  
                if(count == 0) Console.WriteLine("Пользователя нет в системе ");
                else Console.WriteLine("Пользователm в системе ");
                count = 0;

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка  " + ex.Message);
            }

            client.Close();


            // ДЛЯ РЕГИСТРАЦИИ. ДОБАВЛЕНИЕ USER В БД

            //var log = login.Text;
            //var passw = password.Text;
            //var conn = new NpgsqlConnection(connectionString);
            //var client = new Summator.SummatorClient("NetTcpBinding_ISummator");

            ////User newUser = new User(log, passw);
            //try
            //{
            //    conn.Open();
            //    sql = @"select* from my_insert(@_login,@_password)";
            //    var cmd = new NpgsqlCommand(sql, conn);
            //    cmd.Parameters.AddWithValue(@"_login", log);
            //    cmd.Parameters.AddWithValue(@"_password", passw);
            //    if ((int)cmd.ExecuteScalar() == 1)
            //    {
            //        MessageBox.Show("Пользователь добавлен");

            //    }
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    conn.Close();
            //    Console.WriteLine("Ошибка" + ex.Message);
            //    MessageBox.Show("Ошибка при добавлении : " + ex.Message);
            //}

            //client.Close();
        }

        // для окна
        private void closeX_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void mainPanel_Click(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        public long ID { get; set; }
        public string Login { get; set; }

        private string password;

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;

            }
        }
        public User(long id, string login)
        {
            ID = id;
            Login = login;
        }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public override string ToString()
        {
            return $"{ID} {Login} {Password} ";
        }
    }
}
