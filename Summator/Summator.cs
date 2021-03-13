using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
using Npgsql;
using System.Data;

namespace Summator
{

    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Summator" в коде и файле конфигурации.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Summator : ISummator
    {
        private NpgsqlConnection conn;
        string connectionString = String.Format("Server={0};Port={1};" + "User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres", "2409", "planner");

        private NpgsqlCommand command;
        private string sql = null;

        public int CheckUser(string login, string pass)
        {

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select* from check_user('{0}', '{1}')", login, pass);
                    command = new NpgsqlCommand(sql, connection);
                    using (var dataReader = command.ExecuteReader())
                    {
                        dataReader.Read();
                        return dataReader.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибка  " + ex.Message);
                    return 1;
                }

            }

        }
        public int CheckNote(int note_id)
        {

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select* from check_note_id('{0}')", note_id);
                    command = new NpgsqlCommand(sql, connection);
                    using (var dataReader = command.ExecuteReader())
                    {
                        dataReader.Read();
                        return dataReader.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибка  " + ex.Message);
                    return 1;
                }

            }

        }

        // для работы в main form
        public DataTable GetUserId(string login, string password)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select * from get_user_id('{0}','{1}')", login, password);
                    command = new NpgsqlCommand(sql, connection);
                    DataTable result = new DataTable("result");
                    DataSet dataSet = new DataSet();
                    using (NpgsqlDataAdapter tab = new NpgsqlDataAdapter(sql, connection))
                    {
                        dataSet.Reset();
                        tab.Fill(dataSet);
                        result = dataSet.Tables[0];
                    }
                    return result;
                }

                finally
                {
                    connection.Close();
                }

            }
        }

        public int AddToDb(string login, string pass)
        {
            if (CheckUser(login, pass) == 0) //такого пользователя еще нет -> можно создать
            {

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        sql = String.Format("select* from my_insert('{0}', '{1}')", login, pass);
                        command = new NpgsqlCommand(sql, connection);
                        using (var dataReader = command.ExecuteReader())
                        {
                            dataReader.Read();
                            return dataReader.GetInt32(0);
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Ошибка  " + ex.Message);
                        return 1;
                    }

                    finally
                    {
                        connection.Close();
                    }

                }
            }
            else
            {
                return 0;
            }

        }


        public DataTable Select(int owner_id, DateTime dateStr)
        {

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select * from return_note('{0}','{1}')", owner_id, dateStr);
                    command = new NpgsqlCommand(sql, connection);
                    DataTable result = new DataTable("result");
                    DataSet dataSet = new DataSet();
                    using (NpgsqlDataAdapter tab = new NpgsqlDataAdapter(sql, connection))
                    {
                        dataSet.Reset();
                        tab.Fill(dataSet);
                        result = dataSet.Tables[0];
                    }
                    return result;

                }
                finally
                {
                    connection.Close();
                }

            }

        }

        public int DeleteNote(int noteId)
        {

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select* from note_delete('{0}')", noteId);
                    command = new NpgsqlCommand(sql, connection);
                    if ((int)command.ExecuteScalar() == 1) return 1;
                    else return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Удаление не произошло. Error : " + ex.Message);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }

            }

        }

        public int InsertNote(int ownerId, string title, string note, string date, string color)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    sql = String.Format("select* from insert_note('{0}','{1}','{2}','{3}', '{4}')", ownerId, title, note, date, color);

                    command = new NpgsqlCommand(sql, connection);

                    if ((int)command.ExecuteScalar() == 1)
                    {
                        return 1;
                    }
                    else return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Добавление не произошло. Error : " + ex.Message);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }

            }

        }

        public int UpdateNote(int noteId, string title, string note, string date, string color)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    sql = String.Format("select* from  update_note('{0}','{1}','{2}','{3}', '{4}')", noteId, title, note, date, color);
                    command = new NpgsqlCommand(sql, connection);

                    if ((int)command.ExecuteScalar() == 1)
                    {
                        return 1;
                    }
                    else return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Редактирование не произошло. Error : " + ex.Message);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }

            }

        }

        public DataTable SelectNote(int owner_id, string dateStr)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select * from ret_note('{0}', '{1}')", owner_id, dateStr);
                    command = new NpgsqlCommand(sql, connection);
                    DataTable result = new DataTable("result");
                    DataSet dataSet = new DataSet();
                    using (NpgsqlDataAdapter tab = new NpgsqlDataAdapter(sql, connection))
                    {
                        dataSet.Reset();
                        tab.Fill(dataSet);
                        result = dataSet.Tables[0];
                    }
                    return result;
                }

                finally
                {
                    connection.Close();
                }

            }
        }


        public DataTable SearchWord(int owner_id, string word)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select* from search_in_note('{0}','{1}')", owner_id, word);
                    command = new NpgsqlCommand(sql, connection);
                    DataTable result = new DataTable("result");
                    DataSet dataSet = new DataSet();
                    using (NpgsqlDataAdapter tab = new NpgsqlDataAdapter(sql, connection))
                    {
                        dataSet.Reset();
                        tab.Fill(dataSet);
                        result = dataSet.Tables[0];
                    }
                    return result;
                }

                finally
                {
                    connection.Close();
                }

            }
        }


        //        holidays 


        public int InsertHoliday(int ownerId, string date, string holidayNote)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    sql = String.Format("select * from insert_user_holiday('{0}','{1}', '{2}')", ownerId, date, holidayNote);

                    command = new NpgsqlCommand(sql, connection);

                    if ((int)command.ExecuteScalar() == 1)
                    {
                        return 1;
                    }
                    else return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Добавление не произошло. Error : " + ex.Message);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }

            }

        }


        public int UpdateHoliday(int holidayId, int ownerId, string date, string holidayNote)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    sql = String.Format("select* from update_user_holiday('{0}','{1}','{2}','{3}')", holidayId, ownerId, date, holidayNote);
                    command = new NpgsqlCommand(sql, connection);

                    if ((int)command.ExecuteScalar() == 1)
                    {
                        return 1;
                    }
                    else return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Редактирование не произошло. Error : " + ex.Message);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }

            }

        }


        public int DeleteHoliday(int holidayId)
        {
           
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select * from delete_user_holiday('{0}')", holidayId);
                    command = new NpgsqlCommand(sql, connection);
                    if ((int)command.ExecuteScalar() == 1) return 1;
                    else return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Удаление не произошло. Error : " + ex.Message);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }

            }

        }

        public DataTable GetDatesHolidays(int ownerId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select * from get_all_holidays('{0}')", ownerId);
                    command = new NpgsqlCommand(sql, connection);
                    DataTable result_holidays = new DataTable("all_user_holidays");
                    DataSet dataSet = new DataSet();
                    using (NpgsqlDataAdapter tab = new NpgsqlDataAdapter(sql, connection))
                    {
                        dataSet.Reset();
                        tab.Fill(dataSet);
                        result_holidays = dataSet.Tables[0];
                    }
                    return result_holidays;
                }

                finally
                {
                    connection.Close();
                }

            }
        }

        public DataTable GetAllUserHolidays(int ownerId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select * from get_user_holidays('{0}')", ownerId);
                    command = new NpgsqlCommand(sql, connection);
                    DataTable result_holidays = new DataTable("all_user_holidays");
                    DataSet dataSet = new DataSet();
                    using (NpgsqlDataAdapter tab = new NpgsqlDataAdapter(sql, connection))
                    {
                        dataSet.Reset();
                        tab.Fill(dataSet);
                        result_holidays = dataSet.Tables[0];
                    }
                    return result_holidays;
                }

                finally
                {
                    connection.Close();
                }

            }
        }
        public DataTable GetUserHoliday(int ownerId, string date)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select* from get_holiday('{0}', '{1}')", ownerId, date);
                    command = new NpgsqlCommand(sql, connection);
                    DataTable result_holidays = new DataTable("all_user_holidays");
                    DataSet dataSet = new DataSet();
                    using (NpgsqlDataAdapter tab = new NpgsqlDataAdapter(sql, connection))
                    {
                        dataSet.Reset();
                        tab.Fill(dataSet);
                        result_holidays = dataSet.Tables[0];
                    }
                    return result_holidays;
                }

                finally
                {
                    connection.Close();
                }

            }
            
        }

        public DataTable allDateUser(int owner_id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sql = String.Format("select * from date_user('{0}')", owner_id);
                    command = new NpgsqlCommand(sql, connection);
                    DataTable result = new DataTable("result");
                    DataSet dataSet = new DataSet();
                    using (NpgsqlDataAdapter tab = new NpgsqlDataAdapter(sql, connection))
                    {
                        dataSet.Reset();
                        tab.Fill(dataSet);
                        result = dataSet.Tables[0];
                    }
                    return result;
                }

                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
