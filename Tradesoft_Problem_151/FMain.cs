using System;
using System.Windows.Forms;
using TP151_Repository.Classes;
using Tradesoft_Problem_151.Forms;

namespace Tradesoft_Problem_151
{
    /// <summary>
    /// Основная форма
    /// </summary>
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();

            Repository.Connect(); //подключаемся к БД
            ucListGoods.ListType = 0; //выводим список товаров
        }

        private void таблицаПроизводителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FProducers().Show(); //показываем список производителей
        }

        private void найтиСвязьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FFindLink().Show(); //показываем форму "Найти связь"
        }
    }
}
