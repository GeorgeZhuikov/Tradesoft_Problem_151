namespace TP151_Repository.Classes
{
    public partial class Repository
    {
        private static DCTradesoftProblem151DataContext DC { get; set; }
        /// <summary>
        /// Подключение к БД, возвращает true - если подключение прошло успешно, false - если подключение не удалосб
        /// </summary>
        /// <returns></returns>
        public static bool Connect()
        {
            bool connected = false;
            try
            {
                DC = new DCTradesoftProblem151DataContext(Properties.Settings.Default.ConnectionString);
                connected = DC.DatabaseExists();
            }
            catch { }
            return connected;
        }
        /// <summary>
        /// Обновление строки подключения к БД
        /// </summary>
        /// <param name="connectionString"></param>
        public static void UpdateConnectionString(string connectionString)
        {
            Properties.Settings.Default.ConnectionString = connectionString;
            Properties.Settings.Default.Save();
        }
    }
}
