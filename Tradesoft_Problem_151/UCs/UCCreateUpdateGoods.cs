using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP151_Repository;
using TP151_API.Utils;
using TP151_Repository.Classes;

namespace Tradesoft_Problem_151.UCs
{
    /// <summary>
    /// Контрол для создания или обновления товара
    /// </summary>
    public partial class UCCreateUpdateGoods : UserControl
    {
        private Good _goods;
        private bool _isProducerSelected;
        private List<Good> _goodsList;
        private List<UCCUGAnalog> _ucAnalogs;

        public Good Good
        {//если изменяем товар, то присваиваем его данные соответствующим полям
            set
            {
                _goods = value;
                btnAccept.Text = "Изменить";
                AssignData();
            }
        }

        public UCCreateUpdateGoods()
        {
            InitializeComponent();

            Prepare();            
        }

        private void cmbProducers_TextChanged(object sender, EventArgs e)
        {
            _isProducerSelected = (cmbProducers.SelectedIndex != -1);
            EnableButton();
        }

        private void txbVendorCode_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_goods == null) //создаем или изменяем товар, в зависимости был ли передана запись производителя в начале
                CreateGoods();
            else
                UpdateGoods();
            ((Form)TopLevelControl).Close();
        }

        private void Prepare()
        {
            _goodsList = DB.GetGoodsOutputList(); //выгружаем весь список товаров
            cmbProducers.DataSource = DB.GetProducers(); //загружаем в combobox список производителей
            _ucAnalogs = new List<UCCUGAnalog>() //список контролов для выбора аналога
            {
                new UCCUGAnalog()
                {
                    GoodsList = _goodsList,
                    Goods = _goods,
                    AnalogSelected = AnalogSelected,
                    AnalogRemoved = AnalogRemoved
                }
            };
            RefreshAnalogs(); //выводим список контролов для выбора аналогов
        }

        private void RefreshAnalogs()
        {
            pnl.Controls.Clear(); //очищаем панель для аналогов
            foreach (var ucAnalog in _ucAnalogs) //заполняем панель аналогами друг под другом
            {
                pnl.Controls.Add(ucAnalog);
                ucAnalog.Location = new Point(0, ucAnalog.Height * _ucAnalogs.IndexOf(ucAnalog));
            }
            btnAccept.Location = new Point(btnAccept.Location.X, pnl.Location.Y + pnl.Height + 8); //передвигаем кнопку
        }

        private void AnalogSelected()
        {///если был выбран аналог, добавляем пустую запись для выбора и обновляем список
            _ucAnalogs.Add(new UCCUGAnalog()
            {
                GoodsList = _goodsList,
                Goods = _goods,
                AnalogSelected = AnalogSelected,
                AnalogRemoved = AnalogRemoved
            });
            RefreshAnalogs();
        }

        private void AnalogRemoved(UCCUGAnalog ucAnalog)
        {//удаляем выбранный аналог и обновляем список
            _ucAnalogs.Remove(ucAnalog);
            RefreshAnalogs();
        }

        private void AssignData()
        {
            txbVendorCode.Text = _goods.VendorCode;
            cmbProducers.SelectedItem = DB.GetProducer(_goods.ProducerID);
            var analogs = DB.GetAnalogs(_goods.ID);
            _ucAnalogs.Clear();
            foreach (var analog in analogs)
            {
                _ucAnalogs.Add(
                new UCCUGAnalog()
                {
                    GoodsList = _goodsList,
                    Analog = analog,
                    AnalogSelected = AnalogSelected,
                    AnalogRemoved = AnalogRemoved
                });
            }
            AnalogSelected();
        }        

        private void EnableButton()
        {
            if (_isProducerSelected && txbVendorCode.TextLength > 0)
                btnAccept.Enabled = true;
            else
                btnAccept.Enabled = false;
        }        

        private void CreateGoods()
        {//создаём товар и его аналоги
            var goods = new Good()
            {
                VendorCode = txbVendorCode.Text,
                ProducerID = Convert.ToInt32(cmbProducers.SelectedValue)
            };
            Repository.CreateGoods(goods);
            foreach (var analog in _ucAnalogs.Where(x => x.Analog.AnalogGoodsID != 0))
            {
                analog.Analog.OriginalGoodslD = goods.ID;
                Repository.CreateAnalog(analog.Analog);
            }
        }

        private void UpdateGoods()
        {//обновляем товар, потом заного пересоздаём его аналоги
            _goods.VendorCode = txbVendorCode.Text;
            _goods.ProducerID = Convert.ToInt32(cmbProducers.SelectedValue);
            Repository.UpdateGoods(_goods);
            DB.RemoveAnalogs(_goods.ID);
            foreach (var analog in _ucAnalogs.Where(x => x.Analog.AnalogGoodsID != 0))
            {
                analog.Analog.OriginalGoodslD = _goods.ID;
                Repository.CreateAnalog(analog.Analog);
            }
        }
    }
}
