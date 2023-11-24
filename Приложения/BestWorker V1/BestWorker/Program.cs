using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public static string FullName = "FullName";
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
    #endregion
}