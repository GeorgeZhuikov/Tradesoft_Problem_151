using System.Data;
using System.Data.SqlClient;

namespace TP151_API.Utils
{
    /// <summary>
    /// Функции разного назначения
    /// </summary>
    public class General
    {
        /// <summary>
        /// Создание таблицы в БД
        /// </summary>
        /// <param name="myConn"></param>
        /// <param name="script"></param>
        private static void CreateTable(SqlConnection myConn, string script)
        {//выполнение команды создания таблицы по скрипту из файла
            SqlCommand myCommand = new SqlCommand(script, myConn);
            myConn.Open();
            myCommand.ExecuteNonQuery();
            if (myConn.State == ConnectionState.Open) myConn.Close();
        }
        /// <summary>
        /// Создание таблиц в БД
        /// </summary>
        /// <param name="myConn"></param>
        private static void CreateTables(SqlConnection myConn)
        {
            CreateTable(myConn, Properties.Resources.TP151_Analogs); //создаём таблицу Аналогов
            CreateTable(myConn, Properties.Resources.TP151_Goods); //создаём таблицу Товаров
            CreateTable(myConn, Properties.Resources.TP151_Producers); //создаём таблицу Производителей
        }
        /// <summary>
        /// Убирает из строки артикула не нужные символы
        /// </summary>
        /// <param name="vendorCode"></param>
        /// <returns></returns>
        public static string ClearVendorCode(string vendorCode)
        {
            string newVendorCode = "";
            foreach (var ch in vendorCode.ToLower())
                if (char.IsLetterOrDigit(ch)) newVendorCode += ch;
            return newVendorCode;
        }
        /// <summary>
        /// Создание БД с использованием адреса подключения, логина и пароля к SQL Server
        /// </summary>
        /// <param name="address"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public static void CreateDataBase(string address, string login, string password)
        {
            string connectionString = "Server=" + address + ";Integrated security=SSPI;database=master;User ID=" + login + ";password=" + password; //строка подключения к master
            SqlConnection myConn = new SqlConnection(connectionString); //подключаемся к БД
            System.IO.Directory.CreateDirectory("C:\\TP151_DB"); //создаём папку под БД
            string str = "CREATE DATABASE TradesoftProblem151 ON PRIMARY " +
                "(NAME = TradesoftProblem151_Data, " +
                "FILENAME = 'C:\\TP151_DB\\TradesoftProblem151Data.mdf', " +
                "SIZE = 5MB, MAXSIZE = 32MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = TradesoftProblem151_Log, " +
                "FILENAME = 'C:\\TP151_DB\\TradesoftProblem151Log.ldf', " +
                "SIZE = 5MB, MAXSIZE = 16MB, FILEGROWTH = 10%)";
            SqlCommand myCommand = new SqlCommand(str, myConn); //объявляем подключение
            myConn.Open(); //открываем подключение
            myCommand.ExecuteNonQuery(); //выполнение команды создания БД
            if (myConn.State == ConnectionState.Open) myConn.Close(); //закрываем подключение

            CreateTables(myConn); //создаём таблицы

            TP151_Repository.Classes.Repository.UpdateConnectionString(connectionString.Replace("master", "TradesoftProblem151")); //меняем БД master на TradesoftProblem151 запоминаем строку подключения
        }        
    }
}
