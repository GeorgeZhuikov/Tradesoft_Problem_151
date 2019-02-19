using System.Collections.Generic;
using System.Windows.Forms;
using TP151_API.DataTypes;

namespace Tradesoft_Problem_151.Forms
{
    public partial class FShowLinks : Form
    {
        public List<LinkData> LinkDatas
        {
            set
            {
                ucShowLinks.LinkDatas = value;
            }
        }

        public FShowLinks()
        {
            InitializeComponent();
        }
    }
}
