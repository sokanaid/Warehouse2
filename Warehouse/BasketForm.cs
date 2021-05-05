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
        Client CurentClient;
        public BasketForm(List<Good> goods,Warehouse warehouse,Client client)
        {
            InitializeComponent();
            if (goods is null || warehouse is null || client is null)
            {
                MessageBox.Show("Не удалось открыть корзину. Возможно склад не был открыт.");
                Close();
                return;
            }
            Goods = goods;
            CurrentWarehouse = warehouse;
            CurentClient = client;
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
                // Добавление заказа в список заказов склада.
                CurrentWarehouse.Orders.Add((CurentClient.Email, new Order(OrderStatus.Procesing, CurrentWarehouse.Orders.Count+1,
                    CurentClient,DateTime.Now,Goods)));
                // Уменьшение колличество оставшихся товаров на складе на колличество заказанных.
                var allGoods = Form1.AllCatigoriesGoods(CurrentWarehouse);
                for (int i = 0; i < allGoods.Count; i++)
                {
                    allGoods[i].Count -= allGoods[i].ChousenCount;
                    allGoods[i].ChousenCount = 0;
                }
                this.Close();
                MessageBox.Show($"Заказ оформлен. Заказу присвоен номер: { CurrentWarehouse.Orders.Count}");
            }
            catch//(Exception ex)
            {
                MessageBox.Show("Не удалось завершить оформление заказа. Возможно корзина пуста.");// +ex.Message);
            }
        }
    }
}
