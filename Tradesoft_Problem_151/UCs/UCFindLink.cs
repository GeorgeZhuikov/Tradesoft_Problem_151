using System;
using System.Windows.Forms;
using TP151_API.Utils;
using Tradesoft_Problem_151.Forms;

namespace Tradesoft_Problem_151.UCs
{
    /// <summary>
    /// Контрол для нахождения маршрута аналогов
    /// </summary>
    public partial class UCFindLink : UserControl
    {
        public UCFindLink()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {//находим аналоги по введённым артикулам и количеству шагов
            string caption = "Найти связь";
            int step = 0;
            if (txbSteps.TextLength > 0)
                step = Convert.ToInt32(txbSteps.Text);
            FindLinks fl = new FindLinks(txbOriginal.Text, txbToFind.Text, step); //ищем маршрут
            if (fl.Result) //если маршрут найден выводим информацию о нём
                new FShowLinks() { LinkDatas = fl.LinkDatas }.Show();
            else //если маршрут не найлен выводим ошибку
                MessageBox.Show(
                        fl.ErrorMessage,
                        caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }

        private void txbSteps_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)); //проаускаем только цифры и системные клавиши
        }
    }
}
