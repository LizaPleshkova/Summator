using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Registration : Form
    {
        private const String connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=2409;Database=planner;";

        public Registration()
        {
            InitializeComponent();
            
            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 40);

            login.Text = "Введите логин";
            password.Text = "Введите пароль";
            login.ForeColor = Color.Gray;
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
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if(login.Text == "Введите имя" || login.Text == "")
            {
                MessageBox.Show("Введиет имя");
                return; // выходим из функции 
               
            }
            if (password.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль ");
                return;
                
            }
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");

            string log = login.Text;
            string pass = password.Text;
            Console.WriteLine(log);
            //Console.WriteLine(client.(log));
           
            client.Close();

            //// ДЛЯ РЕГИСТРАЦИИ. ДОБАВЛЕНИЕ USER В БД

            //var log = login.Text;
            //var passw = password.Text;
            //var conn = new NpgsqlConnection(connectionString);
            //var client = new Summator.SummatorClient("NetTcpBinding_ISummator");

            ////User newUser = new User(log, passw);
            //try
            //{
            //    conn.Open();
            //    var sql = @"select* from my_insert(@_login,@_password)";
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
            if (login.Text == "")
            {
                login.Text = "Введите имя";
                login.ForeColor = Color.Gray;
            }
            }

        private void mainPanel_Click(object sender, EventArgs e)
        {

        }


        //public bool CheckUser()
        //{

        //}

        //public int AddToDB(string login, string password)
        //{
        //    using (var con = new NpgsqlConnection(connectionString))
        //    {
        //        con.Open();

        //        var sql = @"select* from my_insert(@_login,@_password)";

        //        using (var cmd = new NpgsqlCommand(sql, con))
        //        {
        //            using (NpgsqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    cmd.Parameters.AddWithValue(@"_login", login);
        //                    cmd.Parameters.AddWithValue(@"_password", password);
        //                    if ((int)cmd.ExecuteScalar() == 1)
        //                    {
        //                        return 1;

        //                    }
        //                    else return 0;
        //                }

        //            }
        //        }
        //    }

        //}
        public string GetUser(string username)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = 2409; Database = planner;");
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("select * from users where login = '" + username + "';", conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            dr.Read();
            //using (NpgsqlDataReader rdr = command.ExecuteReader())
            //{
            //    while (rdr.Read())
            //    {
            //        command.Parameters.AddWithValue(@"_login", login);
            //        command.Parameters.AddWithValue(@"_password", password);
            //        if ((int)command.ExecuteScalar() == 1)
            //        {
            //            return (string)dr[0] + ":" + (string)dr[1];

            //        }
            //        else return "User not found";
            //    }

            //}
            
            if (dr.HasRows)
                return (string)dr[0] + ":" + (string)dr[1];
            else
                return "User not found";
            conn.Close();

        }
    }

}
