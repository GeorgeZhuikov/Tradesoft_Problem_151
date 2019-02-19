using System.Windows.Forms;
using TP151_Repository;

namespace Tradesoft_Problem_151.Forms
{
    public partial class FCreateUpdateGoods : Form
    {
        public Good Good
        {
            set
            {
                ucCreateUpdateGoods.Good = value;
                Text = "Изменить Товар";
            }
        }

        public FCreateUpdateGoods()
        {
            InitializeComponent();
        }
    }
}
