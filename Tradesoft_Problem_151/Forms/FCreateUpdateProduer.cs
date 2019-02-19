using System.Windows.Forms;
using TP151_Repository;

namespace Tradesoft_Problem_151.Forms
{
    public partial class FCreateUpdateProduer : Form
    {
        public Producer Producer {
            set
            {
                ucCreateUpdateProducer.Producer = value;
                Text = "Изменить Производителя";
            }
        }

        public FCreateUpdateProduer()
        {
            InitializeComponent();
        }
    }
}
