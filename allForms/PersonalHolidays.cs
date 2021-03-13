using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allForms
{
    public partial class PersonalHolidays : Form
    {
        private string dateStr;
        private DateTime date;
        private DateTime[] allDate;
        private DataTable dtLoad;
        private DataTable dtDate;
        private bool selectDate = false;

        public PersonalHolidays()
        {
            InitializeComponent();
        }

        private void PersonalHolidays_Load(object sender, EventArgs e)
        {


            date = holidays_calendar.TodayDate;
            date = holidays_calendar.SelectionStart;
            dateStr = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);
            selectDate = true;

            loadTableUserHolidays(); // загружаем все данные из табицы личные приздники в DtLoad
            loadTableHoliday();// information about specific holiday ---- write to the dtDate
            ArrayAllDate(); // получаем массив all дат праздничных
        }

        private void holiday_note_TextChanged(object sender, EventArgs e)
        {

        }


        // загружаем все данные из табицы личные приздники в DtLoad
        private void loadTableUserHolidays()
        {
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();
            try
            {
                dtLoad = client.GetAllUserHolidays(Autorization.userId);
            }
            finally
            {
                client.Close();
            }
        }

        private void loadTableHoliday()
        {
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();
            try
            {
                dtDate = client.GetUserHoliday(Autorization.userId, dateStr);
            }
            finally
            {
                client.Close();
            }
        }

        // массив из всех дат мпраздников пользователя
        private void ArrayAllDate()
        {
            allDate = new DateTime[dtLoad.Rows.Count];
            for (int i = 0; i < dtLoad.Rows.Count; i++)
            {
                allDate[i] = Convert.ToDateTime(dtLoad.Rows[i]["dateHoliday"]);
                Console.WriteLine(allDate[i]);
            }
            holidays_calendar.BoldedDates = allDate;
        }



        // проверка находится ли дата в массиве дат allDate
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
               
                if (inAllDate > 0) return true;
                else return false;
            }
        }


        private void holidays_calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = holidays_calendar.SelectionStart;
            holiday_date.Text = date.ToString();
            dateStr = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);
            selectDate = true;

            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();

            try
            {
                if (!InAllDate(date)) // данных\записей о празднике еще нет 
                {
                    holiday_note.Text = "wtite note about holiday";
                    return;
                }
                else
                {
                    loadTableHoliday();
                    holiday_note.Text = dtDate.Rows[0]["holidayNote"].ToString();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке таблицы из БД : " + ex.Message);
            }
            client.Close();
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();

            if (!selectDate)
            {
                MessageBox.Show("Сначала выберите дату на календаре");
                return;
            }
            else // insert
            {
                if (InAllDate(date)) // если такая дата есть в массиве с датами holidays date или дат вообще еще нет у user(первая запись)
                {
                    try
                    {
                        if (client.UpdateHoliday(int.Parse(dtDate.Rows[0]["holidayId"].ToString()), Autorization.userId, dateStr, holiday_note.Text) == 1) MessageBox.Show("редактирование прошло успешно. ");
                        else MessageBox.Show("Не отредактирован. Error : ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Редактирование не произошло. Error : " + ex.Message);
                    }
                    finally
                    {
                        loadTableUserHolidays();
                        loadTableHoliday();
                        ArrayAllDate();
                    }
                }
                else Console.WriteLine("что-то не так с редактирвоанием");

                if (!InAllDate(date)) // если такая дата ytn в массиве с датами user или дат вообще еще нет у user
                {
                    try
                    {
                        if (client.InsertHoliday(Autorization.userId, dateStr, holiday_note.Text) == 1)  MessageBox.Show("Добавление прошло успешно. ");
                        else MessageBox.Show("Не добавлен. Error : ");
                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Добавление не произошло. Error : " + ex.Message);
                    }
                    finally
                    {
                        loadTableUserHolidays();
                        ArrayAllDate();
                        client.Close();
                    }
                }
                else Console.WriteLine("что-то не так с добавлением");
            }
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
                if (dtLoad.Rows.Count == 0) { MessageBox.Show("Для того чтобы удалить запись, сначала создайте ее :)"); return; }

                var client = new Summator.SummatorClient("BasicHttpBinding_ISummator"); client.Open();
                try
                {
                    if (client.DeleteHoliday(int.Parse(dtDate.Rows[0]["holidayId"].ToString())) == 1)
                    {
                        MessageBox.Show("Запись удалена");
                    }
                    else MessageBox.Show("Удаление не произошло.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Удаление не произошло. Error : " + ex.Message);
                }
                finally
                {
                    loadTableUserHolidays();
                    ArrayAllDate();
                    client.Close();
                }
            }
        }
    }
}
