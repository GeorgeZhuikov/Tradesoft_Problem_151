using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP151_Repository;

namespace Tradesoft_Problem_151.UCs
{
    /// <summary>
    /// Контрол для выбора аналогов и создании/редактирования товара
    /// </summary>
    public partial class UCCUGAnalog : UserControl
    {
        private Analog _analog;

        public List<Good> GoodsList
        {
            set
            {
                cmbAnalog.DataSource = value; //заполняем combobox списоком товаров
                cmbAnalog.SelectedIndex = -1;
            }
        }
        public Analog Analog
        {
            get
            {
                return _analog;
            }
            set
            {//устанавливаем аналоги при изменении товара
                _analog = new Analog()
                {
                    OriginalGoodslD = value.OriginalGoodslD,
                    AnalogGoodsID = value.AnalogGoodsID,
                    Reliance = value.Reliance
                };
                btnRemove.Visible = true;
                cmbAnalog.SelectedValue = _analog.AnalogGoodsID;
            }
        }
        public Good Goods
        {//когда у товара нет ещё аналогов, то объявляем новый класс аналога
            set
            {
                _analog = new Analog() { Reliance = chbReliance.Checked };
            }
        }
        public Action AnalogSelected { get; set; }
        public Action<UCCUGAnalog> AnalogRemoved { get; set; }

        public UCCUGAnalog()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AnalogRemoved?.Invoke(this); //удаляем из списка этот контрол
        }

        private void cmbAnalog_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Created)
            {
                if (!btnRemove.Visible) //если это последний контрол в списке, то вызываем функцию 
                {
                    btnRemove.Visible = true;
                    AnalogSelected?.Invoke();
                }
                _analog.AnalogGoodsID = Convert.ToInt32(cmbAnalog.SelectedValue); //запоминаем выбранное значение товара как аналога
            }
        }

        private void chbReliance_CheckedChanged(object sender, EventArgs e)
        {
            _analog.Reliance = chbReliance.Checked; //запоминаем выбранное значение доверия
        }
    }
}
