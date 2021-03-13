using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Npgsql;

namespace Summator
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ISummator" в коде и файле конфигурации.
    [ServiceContract]
    public interface ISummator
    {
        //[OperationContract]
        //List<User> GetUsers();

        [OperationContract]
        int AddToDb(string login, string pass);

        [OperationContract]
        int CheckUser(string login, string pass);
        [OperationContract]
        DataTable GetUserId(string login, string password);

        [OperationContract]
        int CheckNote(int note_id);

        [OperationContract]
        DataTable Select(int owner_id, DateTime dateStr);

        [OperationContract]
        DataTable SearchWord(int owner_id, string word);

        [OperationContract]
        DataTable SelectNote(int owner_id, string dateStr);

        [OperationContract]
        int DeleteNote(int noteId);

        [OperationContract]
        int InsertNote(int ownerId, string title, string note, string date, string color);

        [OperationContract]
        int UpdateNote(int noteId, string title, string note, string date, string color);

        [OperationContract]
        DataTable allDateUser(int owner_id);


        // for holidays 
        [OperationContract]
        DataTable GetAllUserHolidays(int owner_id);

        [OperationContract]
        DataTable GetDatesHolidays(int owner_id);
        
        [OperationContract]
        int InsertHoliday(int ownerId, string date, string holidayNote);

        [OperationContract]
        int UpdateHoliday(int holidayId, int ownerId, string dateHoliday, string holidayNote);

        [OperationContract]
        DataTable GetUserHoliday(int ownerId, string date);

        [OperationContract]
        int DeleteHoliday(int holidayId);


        //[OperationContract]
        //List<Note> GetNotes(long userId);

        //[OperationContract]
        //int SaveNotes(List<Note> notes);

        //[OperationContract]
        //int SaveNote(Note note);

        //[OperationContract]
        //void UpdateNote(Note note);

        //[OperationContract]
        //bool DeleteNote(long noteId);

    }
}
