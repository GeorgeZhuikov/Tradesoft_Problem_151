using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP151_API.Utils;
using TP151_Repository.Classes;
using Tradesoft_Problem_151.Forms;

namespace Tradesoft_Problem_151.UCs
{
    /// <summary>
    /// Контрол для вывода списка товаров или производителей
    /// </summary>
    public partial class UCList : UserControl
    {
        private int _listType = 0;
        private int _selectedRow = -1;
        /// <summary>
        /// Тип списка, 0 - товары, 1 - производители
        /// </summary>
        public int ListType {
            set
            {
                _listType = value;
                RefreshList();
            }
        }

        public UCList()
        {
            Dock = DockStyle.Fill;

            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (_listType)
            {
                case 0:
                    {
                        new FCreateUpdateGoods().ShowDialog(); //вызываем форму для создания товара
                        break;
                    }
                case 1:
                    {
                        new FCreateUpdateProduer().ShowDialog(); //вызываем форму для создания производителя
                        break;
                    }
                default: break;
            }
            RefreshList(); //обновляем список
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (_listType)
            {
                case 0:
                    {
                        new FCreateUpdateGoods() { Good = DB.GetGoods(GetID()) }.ShowDialog(); //вызываем форму для обновления товара 
                        break;
                    }
                case 1:
                    {
                        new FCreateUpdateProduer() { Producer = DB.GetProducer(GetID()) }.ShowDialog(); //вызываем форму для обновления производителя 
                        break;
                    }
                default: break;
            }
            RefreshList(); //обновляем список
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            switch (_listType)
            {
                case 0:
                    {
                        Repository.RemoveGoods(GetID()); //удаляем выбранный товар
                        break;
                    }
                case 1:
                    {
                        Repository.RemoveProducer(GetID()); //удаляем выбранного производителя
                        break;
                    }
                default: break;
            }
            RefreshList(); //обновляем список
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList(); //обновляем список
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            _selectedRow = (dgv.CurrentRow == null) ? -1 : dgv.CurrentRow.Index;
            EnableButtons(); //если выбрана запись активируем кнопки "Изменить" и "Удалить"
        }

        private int GetID() //извлекаем ID выбранного товара из строки таблицы
        {
            return Convert.ToInt32(dgv.Rows[_selectedRow].Cells["ID"].Value);
        }

        private void RefreshList()
        {//обновляем список в зависимости от его типа (по умолчанию 0); если тип 1, то прячем столбцы товаров и показываем столбец производителя
            switch (_listType)
            {
                case 0: //товары
                    {
                        dgv.DataSource = Fill.Goods(); //заполнение таблцы товарами
                        dgv.ClearSelection();
                        break;
                    }
                case 1: //производитель
                    {
                        ProducerName.Visible = true; //столбец производителя
                        dgv.DataSource = Fill.Producers(); //заполнение таблицы производителями
                        VendorCode.Visible = false; //столбцы товаров
                        Producer.Visible = false;
                        AnalogProducer.Visible = false;
                        AnalogVendorCode.Visible = false;
                        Reliance.Visible = false;
                        dgv.ClearSelection();
                        break;
                    }
            }
            _selectedRow = -1; //сбрасываем выбранную строку
            EnableButtons(); //деактивируем кнопки
        }

        private void EnableButtons()
        {
            if (_selectedRow > -1) //если строка выбрана, то делаем кнопки доступными
            {
                btnUpdate.Enabled = true;
                btnRemove.Enabled = true;
            }
            else //если нет, то не доступными
            {
                btnUpdate.Enabled = false;
                btnRemove.Enabled = false;
            }
        }
    }
}
