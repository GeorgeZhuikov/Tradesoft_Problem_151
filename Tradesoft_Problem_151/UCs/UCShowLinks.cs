using System.Collections.Generic;
using System.Windows.Forms;
using TP151_API.DataTypes;

namespace Tradesoft_Problem_151.UCs
{
    public partial class UCShowLinks : UserControl
    {
        /// <summary>
        /// Контрол для вывода информации о маршруте аналогов
        /// </summary>
        public List<LinkData> LinkDatas
        {
            set
            {
                dgv.DataSource = value; //выводим информацию о маршруте аналогов
            }
        }

        public UCShowLinks()
        {
            InitializeComponent();
        }
    }
}
