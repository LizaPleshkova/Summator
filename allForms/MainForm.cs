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
    public partial class MainForm : Form
    {
        private DataTable dtLoad;
        private DataTable dtDate;

        private DataTable dtDateHoliday;
        private DataTable dtDatesHolidays;
        private DataTable AllDatesHolidays;

        public static DataTable dtSearch;
        
        private string dateStr;
        private bool selectDate = false;

        private string colString;
        private int colAlpha;
        private int colRed;
        private int colGreen;
        private int colBlue;
        private Color col = Color.FromArgb(255, 255, 255, 255);

        private DateTime date;
        private DateTime[] allDate;

        Point lastPoint;
        public MainForm()
        {
            InitializeComponent();

            this.textBoxDateSearch.AutoSize = false;
            this.textSearch.AutoSize = false;
            this.textBoxDateSearch.Size = new Size(this.textBoxDateSearch.Size.Width, 25);
            this.textSearch.Size = new Size(this.textSearch.Size.Width, 25);
            textBoxDateSearch.TextAlign = HorizontalAlignment.Center;
            textSearch.TextAlign = HorizontalAlignment.Center;

            textBoxTitle.Tag = textBoxTitle.Text = "Введите текст заголовка";
            textBoxNote.Tag = textBoxNote.Text = "Введите текст заметки";
            textBoxDateSearch.Tag = textBoxDateSearch.Text = "Введите дату для поиска";
            textSearch.Tag = textSearch.Text = "Введите слово для поиска";

            //textBoxDateSearch.ForeColor = Color.Gray;
            //textSearch.ForeColor = Color.Gray;
            //textBoxTitle.ForeColor = Color.Gray;
            //textBoxNote.ForeColor = Color.Gray;
        }

        // подсказки для пользователя
        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "Введите текст заголовка";
                textBoxTitle.ForeColor = Color.Gray;
            }
        }

        private void textBoxTitle_Enter(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "Введите текст заголовка")
            {
                textBoxTitle.Text = "";
                textBoxTitle.ForeColor = Color.FromArgb(58, 22, 34);
            }
        }

        private void textBoxNote_Leave(object sender, EventArgs e)
        {
            if (textBoxNote.Text == "")
            {
                textBoxNote.Text = "Введите текст заметки";
                //textBoxNote.ForeColor = Color.Gray;
            }
        }

        private void textBoxNote_Enter(object sender, EventArgs e)
        {
            if (textBoxNote.Text == "Введите текст заметки")
            {
                textBoxNote.Text = "";
                textBoxNote.ForeColor = Color.FromArgb(58, 22, 34);
            }
        }

        private void textBoxDateSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxDateSearch.Text == "")
            {
                textBoxDateSearch.Text = "Введите дату для поиска";
                //textBoxDateSearch.ForeColor = Color.Gray;
            }

        }

        private void textBoxDateSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxDateSearch.Text == "Введите дату для поиска")
            {
                textBoxDateSearch.Text = "";
                textBoxDateSearch.ForeColor = Color.FromArgb(58, 22, 34);
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if (textSearch.Text == "")
            {
                textSearch.Text = "Введите слово для поиска";
                // textSearch.ForeColor = Color.Gray;
            }
        }

        private void textSearch_Enter(object sender, EventArgs e)
        {
            if (textSearch.Text == "Введите слово для поиска")
            {
                textSearch.Text = "";
                textSearch.ForeColor = Color.FromArgb(58, 22, 34);
            }
        }

        // перемещение формы
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
        private void closeX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateDataTable();
            GetDatesUser();
            date = monthCalendar1.TodayDate;
            date = monthCalendar1.SelectionStart;
            dateStr = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);

            selectDate = true;

            loadTableHoliday();// load dtDateHoliday and dtDatesHolidays

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            //toolTip1.SetToolTip(this.button1, "My button1");
            toolTip1.SetToolTip(this.textBoxDateSearch, "Search date");


            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Purple;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!selectDate)
            {
                MessageBox.Show("Сначала выберите дату на календаре ");
                return;
            }
            else
            {
                updateDataTable();
                if (dtLoad.Rows.Count == 0) { MessageBox.Show("Для того чтобы удалить запись, сначала создайте ее :)"); return; }

                var client = new Summator.SummatorClient("BasicHttpBinding_ISummator"); client.Open();
                try
                {
                    if (client.DeleteNote(int.Parse(dtLoad.Rows[0]["noteId"].ToString())) == 1)
                    {
                        MessageBox.Show("Запись удалена");
                    }
                    else MessageBox.Show("Удаление не произошло.");
                    updateDataTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Удаление не произошло. Error : " + ex.Message);
                }
                finally
                {
                    updateAllDateUser();
                    GetDatesUser();
                    client.Close();
                }
            }
        }

        // сохранение при добавлении или изменении записи
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();

            if (!selectDate)
            {
                MessageBox.Show("Сначала выберите дату на календаре");
                return;
            }
            if (textBoxNote.Text == "Введите текст заметки" || textBoxTitle.Text == "Введите текст заголовка")
            {
                MessageBox.Show("Сначала запишите что-нибудь в заметки"); return;
            }
            else // insert
            {

                if (InAllDate(date)) // если такая дата есть в массиве с датами user или дат вообще еще нет у user(первая запись)
                {
                    try
                    {
                        ColorToDb();
                        if (client.UpdateNote(int.Parse(dtLoad.Rows[0]["noteId"].ToString()), textBoxTitle.Text, textBoxNote.Text, dateStr, colString) == 1)
                        {
                            Console.WriteLine(colString);
                            MessageBox.Show("редактирование прошло успешно. ");
                            updateDataTable();
                        }
                        else
                        {
                            MessageBox.Show("Не отредактирован. Error : ");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Редактирование не произошло. Error : " + ex.Message);
                    }
                    finally
                    {
                        updateAllDateUser();
                        GetDatesUser();
                    }
                }
                else Console.WriteLine("что-то не так с редактирвоанием");
                if (allDate == null || !InAllDate(date)) // если такая дата есть в массиве с датами user или дат вообще еще нет у user
                {
                    try
                    {
                        ColorToDb();
                        if (client.InsertNote(Autorization.userId, textBoxTitle.Text, textBoxNote.Text, dateStr, colString) == 1)
                        {
                            Console.WriteLine(colString);
                            Console.WriteLine(date);
                            MessageBox.Show("Добавление прошло успешно. ");
                            if (!GetDatesUser()) allDate[0] = date; // если массив с датами пуст\первая запись у пользователя 
                            else allDate[allDate.Length - 1] = date;

                            updateDataTable();
                        }
                        else
                        {
                            MessageBox.Show("Не добавлен. Error : ");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Добавление не произошло. Error : " + ex.Message);
                    }
                    finally
                    {
                        updateAllDateUser();
                        GetDatesUser();
                        client.Close();
                    }

                }
                else Console.WriteLine("что-то не так с добавлением");
            }
        }

        //выход из аккаунта
        private void ExitAcount_Click(object sender, EventArgs e)
        {
            Autorization.userId = -1;
            this.Hide(); // прячем  окно 
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        // обновление таблицы -> используеься после каждого изменения записей


        private void Search_Click(object sender, EventArgs e)
        {
            string word = "%" + textSearch.Text + "%";
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();
            try
            {
                dtSearch = client.SearchWord(Autorization.userId, word);
            }
            finally
            {
                client.Close();
            }
            if (dtSearch.Rows.Count == 0) { MessageBox.Show("Совпадений по \'" + textSearch.Text + "\' не найдено"); textSearch.Text = "Введите слово для поиска"; return; }
            else
            {
                //this.Hide(); // прячем  окно 
                FormSearch search = new FormSearch();
                search.Show();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            date = monthCalendar1.SelectionStart;
            
            textBoxDateSearch.Text = String.Format("{0}.{1}.{2}", date.Day, date.Month, date.Year);

            dateStr = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);
            selectDate = true;

            dtLoad = updateDataTable();
            loadTableHoliday();
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();
            
            try
            {
                if (dtLoad.Rows.Count == 0 || client.CheckNote(int.Parse(dtLoad.Rows[0]["noteId"].ToString())) == 0)
                {
                    //MessageBox.Show("Данных нет");
                    textBoxTitle.Text = "Введите текст заголовка";
                    textBoxNote.Text = "Введите текст заметки";

                    col = Color.FromArgb(255, 255, 255, 255);
                    GetColorfrom(col);

                    textBoxNote.BackColor = col;
                    textBoxTitle.BackColor = col;

                    if (InHoliday(date)) toolTip1.Show(dtDateHoliday.Rows[0]["holidayNote"].ToString(), this.monthCalendar1);
                    else toolTip1.SetToolTip(this.monthCalendar1, "Doesn't have a holiday");
                    return;
                }
                else
                {

                    if (InHoliday(date)) toolTip1.Show(dtDateHoliday.Rows[0]["holidayNote"].ToString(), this.monthCalendar1);
                    else toolTip1.SetToolTip(this.monthCalendar1, "Doesn't have a holiday");

                    textBoxNote.Text = dtLoad.Rows[0]["noteText"].ToString();
                    textBoxTitle.Text = dtLoad.Rows[0]["noteTitle"].ToString();
                    colString = dtLoad.Rows[0]["backColor"].ToString(); // получаем из бд сточку в виде -> 255;255;255;255
                    var title_holidays = dtLoad.Rows[0]["noteTitle"].ToString();
                  
                    if (Regex.IsMatch(colString, "^[A-zА-яЁё]+$"))//если цвет состоит только из букв -> цвет системный 
                    {

                    }
                    else//иначе цвет из rgb-> цвет пользовательский
                    {
                        // из строки colString получить оттуенки 
                        FromStringToColor(colString); //из строки получаем значения colAlpha \ colRed \ colGreen \ colBlue 
                        textBoxNote.BackColor = Color.FromArgb(colAlpha, colRed, colGreen, colBlue);
                        textBoxTitle.BackColor = Color.FromArgb(colAlpha, colRed, colGreen, colBlue);
                    }
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке таблицы из БД : " + ex.Message);
            }
            client.Close();
        }

        private void ColorToDb()
        {
            colString = colAlpha.ToString() + ";" + colRed.ToString() + ";" + colGreen.ToString() + ";" + colBlue.ToString();
        }
        // из Color получаем значения 
        private void FromStringToColor(string color)
        {
            string[] colors = color.Split(new char[] { ';' });
            colAlpha = Int32.Parse(colors[0]);
            colRed = Int32.Parse(colors[1]);
            colGreen = Int32.Parse(colors[2]);
            colBlue = Int32.Parse(colors[3]);
        }

        // из Color получаем значения colAlpha \ colRed \ colGreen \ colBlue 
        private void GetColorfrom(Color col)
        {
            string colorFromDB = col.ToString();

            MatchCollection p = Regex.Matches(colorFromDB, @"(?<=[ARGB]\=)(\d+)");

            colAlpha = int.Parse(p[0].Value);
            colRed = int.Parse(p[1].Value);
            colGreen = int.Parse(p[2].Value);
            colBlue = int.Parse(p[3].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            colorDialog1.AllowFullOpen = true;
            colorDialog1.ShowHelp = true;


            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                col = colorDialog1.Color;
            }

            if (col.IsKnownColor) { MessageBox.Show("Попробуйте выбрать другой цвет"); Console.WriteLine("Это системный цвет"); return; }
            else
            {
                Console.WriteLine("Это ARGB цвет");
                GetColorfrom(col); //из Color получаем значения colAlpha \ colRed \ colGreen \ colBlue 
                textBoxNote.BackColor = Color.FromArgb(colAlpha, colRed, colGreen, colBlue);
                textBoxTitle.BackColor = Color.FromArgb(colAlpha, colRed, colGreen, colBlue);
                //onsole.WriteLine(" цветаа  " + colAlpha.ToString() + colRed.ToString() + colGreen.ToString() + colBlue.ToString());
                return;
            }

        }

        private void DateSearch_Click(object sender, EventArgs e)
        {
            dateStr = textBoxDateSearch.Text;

            if (textBoxDateSearch.Text == "Введите дату для поиска" || textBoxDateSearch.Text == "" || !Regex.IsMatch(dateStr, @"(0?[1-9]|[12][0-9]|3[01]).(0?[1-9]|1[012]).((19|20)\d\d)"))
            {
                MessageBox.Show("Введите дату в формате ДД.ММ.ГГГГ ЧЧ:ММ:СС");
            }
            else
            {
                date = Convert.ToDateTime(dateStr);
                groupBox1.Show();
                MainForm main = new MainForm();
                main.Hide();
                monthCalendar1.SelectionStart = date;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private bool InAllDate(DateTime date)
        {
            int inAllDate = 0;
            if (allDate == null) return false;
            else
            {
                for (int i = 0; i < allDate.Length; i++)
                {
                    if (allDate[i] == date) { inAllDate++; i++; }

                }
                Console.WriteLine(inAllDate);
                if (inAllDate > 0) return true;
                else return false;
            }
        }
        //
        private bool GetDatesUser()
        {
            updateAllDateUser();

            if (dtDate.Rows.Count == 0)
            {
                allDate = null;
                return false;
            }
            else
            {
                allDate = new DateTime[dtDate.Rows.Count];
                for (int j = 0; j < dtDate.Rows.Count; j++)
                {
                    allDate[j] = Convert.ToDateTime(dtDate.Rows[j]["creationDate"]);

                }
                monthCalendar1.BoldedDates = allDate;
                return true;
            }

        }

        // получаем значение 
        private DataTable updateDataTable()
        {
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();
            try
            {
                dtLoad = client.Select(Autorization.userId, date);
                return dtLoad;
            }
            finally
            {
                client.Close();
            }
        }

        // таблица с датами пользователя
        private DataTable updateAllDateUser()
        {
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();
            try
            {
                dtDate = client.allDateUser(Autorization.userId);
                Console.WriteLine(dtDate.Rows.Count);
                return dtDate;
            }
            finally
            {
                client.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalHolidays holidays = new PersonalHolidays();
            holidays.Show();
        }

        private void loadTableHoliday()
        {
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();
            try
            {
                dtDatesHolidays = client.GetDatesHolidays(Autorization.userId); // table of all holidays user (only their dates)
                dtDateHoliday = client.GetUserHoliday(Autorization.userId, dateStr); // table with full information about one holiday
            }
            finally
            {
                client.Close();
            }
        }
        private bool InHoliday(DateTime date)
        {
            int inAllDate = 0;
            if (dtDatesHolidays.Rows.Count == 0) return false;
            else
            {
                for (int j = 0; j < dtDatesHolidays.Rows.Count; j++)
                {
                    if (Convert.ToDateTime(dtDatesHolidays.Rows[j]["dateHoliday"]) == date) { inAllDate++; j++; }

                }
                if (inAllDate > 0) return true;
                else return false;
            }
        }


        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
