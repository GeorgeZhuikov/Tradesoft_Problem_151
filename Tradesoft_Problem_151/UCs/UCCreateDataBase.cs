using System;
using System.Windows.Forms;
using TP151_API.Utils;

namespace Tradesoft_Problem_151.UCs
{
    /// <summary>
    /// Контрол для создания БД в случае её отсутствия
    /// </summary>
    public partial class UCCreateDataBase : UserControl
    {
        public UCCreateDataBase()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool created = false; //переманная отвечающая за результат создания БД
            try
            {
                btnAccept.Enabled = false; //делам кнопку недоступной
                General.CreateDataBase(txbAddress.Text, txbLogin.Text, txbPassword.Text); //создаем БД по введённым параметрам
                System.Threading.Thread.Sleep(5000); //ждём некоторое время, пока на SQL сервере создаётся БД
                ((Form)TopLevelControl).Hide(); //прячем эту форму
                created = true; //помечаем успешный результат
            }
            catch (Exception ex)
            { //если создать БД не удалось, выводится сообщение с текстом ошибки
                MessageBox.Show(string.Format("Не удалось создать БД.{0}{1}", Environment.NewLine, ex.Message),
                    "Создать",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            btnAccept.Enabled = true; //делаем кнопку доступной
            if (created) //если БД создана, показываем основную форму
            {
                new FMain().ShowDialog();
                ((Form)TopLevelControl).Close(); //закрываем приложение после завершения работы с основной формой
            }
        }
    }
}
