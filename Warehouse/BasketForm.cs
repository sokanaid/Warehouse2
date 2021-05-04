using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class BasketForm : Form
    {
        List<Good> Goods;
        Warehouse CurrentWarehouse;
        public BasketForm(List<Good> goods,Warehouse warehouse)
        {
            InitializeComponent();
            if (goods is null || warehouse is null)
            {
                MessageBox.Show("Не удалось открыть корзину. Возможно склад не был открыт.");
                Close();
                return;
            }
            Goods = goods;
            CurrentWarehouse = warehouse;
            DataGridView1.DataSource = Goods;
            DataGridView1.Columns[0].HeaderText = "Наименование";
            DataGridView1.Columns[1].HeaderText = "Артикул";
            DataGridView1.Columns[2].HeaderText = "Цена";
            DataGridView1.Columns[3].HeaderText = "На складе";
            DataGridView1.Columns[4].HeaderText = "В корзине";
        }
    }
}
