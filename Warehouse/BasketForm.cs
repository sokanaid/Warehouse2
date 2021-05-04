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
        string ClientEmail;
        public BasketForm(List<Good> goods,Warehouse warehouse,string email)
        {
            InitializeComponent();
            if (goods is null || warehouse is null || email is null)
            {
                MessageBox.Show("Не удалось открыть корзину. Возможно склад не был открыт.");
                Close();
                return;
            }
            Goods = goods;
            CurrentWarehouse = warehouse;
            ClientEmail = email;
            DataGridView1.DataSource = Goods;
            DataGridView1.Columns[0].HeaderText = "Наименование";
            DataGridView1.Columns[1].HeaderText = "Артикул";
            DataGridView1.Columns[2].HeaderText = "Цена";
            DataGridView1.Columns[3].HeaderText = "На складе";
            DataGridView1.Columns[4].HeaderText = "В корзине";
        }

        /// <summary>
        /// Оформление заказа.
        /// </summary>
        private void CreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if(CurrentWarehouse.Orders is null)
                {
                    CurrentWarehouse.Orders = new List<(string CastomerName, Order Order)>();
                }
                if (Goods is null || Goods.Count == 0) 
                    throw new Exception();
                CurrentWarehouse.Orders.Add((ClientEmail, new Order(ClientEmail, CurrentWarehouse.Orders.Count+1)));
                var allGoods = Form1.AllCatigoriesGoods(CurrentWarehouse);
                for (int i = 0; i < allGoods.Count; i++)
                {
                    allGoods[i].Count -= allGoods[i].ChousenCount;
                }
                this.Close();
                MessageBox.Show($"Заказ оформлен. Заказу присвоен номер: { CurrentWarehouse.Orders.Count}");
            }
            catch
            {
                MessageBox.Show("Не удалось завершить оформление заказа. Возможно корзина пуста.");
            }
        }
    }
}
