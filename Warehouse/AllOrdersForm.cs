using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class AllOrdersForm : Form
    {
        public List<Order> Orders { get; set; }
        public AllOrdersForm(List<Order> orders)
        {
            InitializeComponent();
            Orders = orders;
            DataGridView1.DataSource = orders;

            DataGridView1.Columns[0].HeaderText = "Номер";
            DataGridView1.Columns[2].HeaderText = "Дата оформления";
            DataGridView1.Columns[1].HeaderText = "Статус";
            //DataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            DataGridView1.Columns[3].HeaderText = "e-mail покупателя";
            
            DataGridView1.Columns.Add(new DataGridViewButtonColumn());
            ((DataGridViewButtonColumn)DataGridView1.Columns[DataGridView1.Columns.Count - 1]).UseColumnTextForButtonValue = true;
            ((DataGridViewButtonColumn)DataGridView1.Columns[DataGridView1.Columns.Count - 1]).Text = "Обработан";
            DataGridView1.Columns.Add(new DataGridViewButtonColumn());
            ((DataGridViewButtonColumn)DataGridView1.Columns[DataGridView1.Columns.Count - 1]).UseColumnTextForButtonValue = true;
            ((DataGridViewButtonColumn)DataGridView1.Columns[DataGridView1.Columns.Count - 1]).Text = "Отгружен";
            DataGridView1.Columns.Add(new DataGridViewButtonColumn());
            ((DataGridViewButtonColumn)DataGridView1.Columns[DataGridView1.Columns.Count - 1]).UseColumnTextForButtonValue = true;
            ((DataGridViewButtonColumn)DataGridView1.Columns[DataGridView1.Columns.Count - 1]).Text = "Исполнен";
            DataGridView1.CellClick += DataGridView1_CellClick;
            /*for (int i = 0; i < orders.Count; i++)
            {
                DataGridView1.Rows[i].Cells[3].Value = orders[i].Client.Email;
            }*/
        }
        /// <summary>
        /// Обработка события нажатия на кнопку для изменения статуса.
        /// </summary>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    Orders[e.RowIndex].StatusButton_Click("обработан", OrderStatus.Processed);
                }
                else if (e.ColumnIndex == 1)
                {
                    Orders[e.RowIndex].StatusButton_Click("доставлен", OrderStatus.Shipped);
                }
                else if (e.ColumnIndex == 2)
                {
                    Orders[e.RowIndex].StatusButton_Click("исполнен", OrderStatus.Executed);
                }
                //DataGridView1.Rows[e.RowIndex].Cells[5].Value = Orders[e.RowIndex].Status;
                DataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Не удалось изменить стутс заказа.");
            }
        }
    }
}
