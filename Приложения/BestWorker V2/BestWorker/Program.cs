using System;
using System.Windows.Forms;

namespace BestWorker
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
    static class Database
    {
        public static string ConnetctionString = @"Data Source=WERK.db; Integrated Security=False; MultipleActiveResultSets=True";
    }

    #region table
    static class Table_Emplues
    {
        public static string main = "Emplues";
        public static string ID = "ID";
        public static string Login = "Login";
        public static string Pass = "Pass";
        public static string Name = "Name";
        public static string Surname = "Surname";
        public static string Age = "Age";
        public static string Rolue = "Rolue";
        public static string WorkShop = "WorkShop";
    }
    static class Table_Tasks
    {
        public static string main = "Tasks";
        public static string ID = "ID";
        public static string FullNameT = "FullNameT";
        public static string Task = "Task";
        public static string Rolue = "Rolue";
        public static string Workshop = "Workshop";
    }
    static class Table_QuestionAndEvents
    {
        public static string main = "QuestionAndEvents";
        public static string ID = "ID";
        public static string FullNameQ = "FullNameQ";
        public static string Question = "Question";
        public static string Answer = "Answer";
        public static string Event = "Event";
    }
    static class Table_Tovar
    {
        public static string main = "Tovar";
        public static string ID = "ID";
        public static string NameTovar = "NameTovar";
        public static string DateOfMake = "DateOfMake";
        public static string Status = "Status";
    }
    #endregion
}