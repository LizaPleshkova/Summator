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
        private int holidayId;
        private DataTable dtLoad;
        private DataTable dtDate;

        public PersonalHolidays()
        {
            InitializeComponent();
        }

        private void PersonalHolidays_Load(object sender, EventArgs e)
        {
            loadTableUserHolidays(); // загружаем все данные из табицы личные приздники в DtLoad
            ArrayAllDate(); // получаем массив all дат праздничных

            date = holidays_calendar.TodayDate;
            date = holidays_calendar.SelectionStart;
            dateStr = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);

        }

        private void holiday_note_TextChanged(object sender, EventArgs e)
        {
           
        }

        
        // загружаем все данные из табицы личные приздники в DtLoad
        private DataTable loadTableUserHolidays()
        {
            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();
            try
            {
                dtDate = client.GetUserHoliday(Autorization.userId, dateStr);
                dtLoad = client.GetAllUserHolidays(Autorization.userId);
                //Console.WriteLine("from loadTableUserHolidays()");
                return dtLoad;
            }
            finally
            {
                client.Close();
            }
        }

        // проверка находится ли дата в массиве дат allDate
        private bool InAllDate(DateTime date)
        {
         
            int inAllDate = 0;
            if (allDate == null) { Console.WriteLine(1.1); return false; }
            else
            {
                for (int i = 0; i < allDate.Length; i++)
                {
                    if (allDate[i] == date) { inAllDate++; i++; }

                }
                Console.WriteLine(1.2);
                if (inAllDate > 0) { Console.WriteLine(1.3); return true; }
                else { Console.WriteLine(1.4); return false; }
            }
        }
        
        // массив из всех дат мпраздников пользователя
        private void ArrayAllDate()
        {
            Console.WriteLine("from ArrayAllDate()");

            allDate = new DateTime[dtLoad.Rows.Count];
            for (int i = 0; i < dtLoad.Rows.Count; i++)
            {
                allDate[i] = Convert.ToDateTime(dtLoad.Rows[i]["dateHoliday"]);
                Console.WriteLine(allDate[i]);
            }
            holidays_calendar.BoldedDates = allDate;
        }
       
        private void holidays_calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = holidays_calendar.SelectionStart;
            holiday_date.Text = date.ToString();
            //getHolidayId();
            dateStr = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);

            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();

            try
            {
                Console.WriteLine(InAllDate(date));
                if (!InAllDate(date)) // данных\записей о празднике еще нет 
                {
                    //MessageBox.Show("Данных нет");
                    holiday_note.Text = "wtite note about holiday";
                    return;
                }
                else
                {

                    holiday_note.Text = dtDate.Rows[0]["holidayNote"].ToString();
                    //Console.WriteLine("from calendary : ");
                    Console.WriteLine("dtDate" + dtDate.Rows[0]["holidayNote"].ToString());
                    Console.WriteLine("dtLoad " + dtLoad.Rows[0]["holidayNote"].ToString());
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке таблицы из БД : " + ex.Message);
            }
            client.Close();
        }

       private void getHolidayId()
        {
            Console.WriteLine("from ArrayAllDate()");

           
            for (int i = 0; i < dtLoad.Columns.Count; i++)
            {
                Console.WriteLine(i);
            }
            
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {

            var client = new Summator.SummatorClient("BasicHttpBinding_ISummator");
            client.Open();

            //if (!selectDate)
            //{
            //    MessageBox.Show("Сначала выберите дату на календаре");
            //    return;
            //}
            //else // insert
            //{

            if (InAllDate(date)) // если такая дата есть в массиве с датами holidays date или дат вообще еще нет у user(первая запись)
            {
                Console.WriteLine("редактирвоанием");

                //    try
                //    {
                //        Console.WriteLine("from button: date in holiday aray - >  update ");

                //        //                    
                //        //                        returns table(
                //        //    holidayId integer,
                //        //    ownerId integer,
                //        //    dateHoliday date,
                //        //    holidayNote character varying(100)
                //        //)

                //        if (client.UpdateHoliday(int.Parse(dtLoad.Rows[0]["holidayId"].ToString()), Autorization.userId, dateStr, holiday_note.Text) == 1)
                //        {
                //            MessageBox.Show("редактирование прошло успешно. ");

                //        }
                //        else
                //        {
                //            MessageBox.Show("Не отредактирован. Error : ");
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Редактирование не произошло. Error : " + ex.Message);
                //    }
                //    finally
                //    {

                //        loadTableUserHolidays();
                //        ArrayAllDate();
                //    }
            }
            else Console.WriteLine("что-то не так с редактирвоанием");

            if (!InAllDate(date)) // если такая дата ytn в массиве с датами user или дат вообще еще нет у user
            {
                Console.WriteLine("from button save: allDate == null || !InAllDate(date) - > save");

                try
                { Console.WriteLine(dateStr);
                    Console.WriteLine(Autorization.userId);

                    if (client.InsertHoliday(Autorization.userId, dateStr, holiday_note.Text) == 1)
                    {
                       
                        MessageBox.Show("Добавление прошло успешно. ");

                        //if (!GetDatesUser()) allDate[0] = date; // если массив с датами пуст\первая запись у пользователя 
                        //else allDate[allDate.Length - 1] = date;

                        //updateDataTable();
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
                    loadTableUserHolidays();
                    ArrayAllDate();
                    client.Close();
                }

            }
            else Console.WriteLine("что-то не так с добавлением");

        }

    }
}
