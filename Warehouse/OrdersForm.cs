using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class OrdersForm : Form
    {
        public List<Order> Orders { get; set; }
        public OrdersForm(List<Order> orders)
        {
            InitializeComponent();
            Orders = orders;
            DataGridView1.DataSource = orders;
            DataGridView1.Columns.Add(new DataGridViewButtonColumn());
            DataGridView1.Columns[0].HeaderText = "Номер";
            DataGridView1.Columns[2].HeaderText = "Дата оформления";
            DataGridView1.Columns[1].HeaderText = "Статус";
            DataGridView1.Columns[3].Visible = false;
            ((DataGridViewButtonColumn)DataGridView1.Columns[DataGridView1.Columns.Count - 1]).UseColumnTextForButtonValue = true;
            ((DataGridViewButtonColumn)DataGridView1.Columns[DataGridView1.Columns.Count - 1]).Text = "Оплатить";
            DataGridView1.CellClick += DataGridView1_CellClick;
        }

        /// <summary>
        /// Обработка события нажатия на кнопку.
        /// </summary>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 0) return;
                Orders[e.RowIndex].PayButton_Click();
                DataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Не удалось оплатить заказ.");
            }
        }
    }
}
