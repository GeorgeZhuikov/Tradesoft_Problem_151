using System.Windows.Forms;
using TP151_Repository;
using TP151_Repository.Classes;

namespace Tradesoft_Problem_151.UCs
{
    /// <summary>
    /// Контрол для создания или изменения производителя
    /// </summary>
    public partial class UCCreateUpdateProducer : UserControl
    {
        private Producer _producer;

        public Producer Producer
        {//если изменяем производителя, то присваиваем его данные соответствующим полям
            set
            {
                _producer = value;
                btnAccept.Text = "Изменить";
                txbName.Text = value.Name;
            }
        }

        public UCCreateUpdateProducer()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            if (_producer == null) //создаем или изменяем производителя, в зависимости был ли передана запись производителя в начале
                Repository.CreateProducer(new Producer() { Name = txbName.Text });
            else
            {
                _producer.Name = txbName.Text;
                Repository.UpdateProducer(_producer);
            }
            ((Form)TopLevelControl).Close(); //закрываем форму
        }
    }
}
