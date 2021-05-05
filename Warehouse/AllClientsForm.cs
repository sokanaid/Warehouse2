using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class AllClientsForm : Form
    {
        List<Order> Orders;
        List<Client> Clients;
        public AllClientsForm(List<Order> orders, List<Client> clients)
        {
            InitializeComponent();
            Orders = orders;
            Clients = clients;
            DataGridView1.DataSource = Clients;
            DataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                Text = "Список заказов"
            });
            DataGridView1.Columns[0].HeaderText = "E-mail";
            DataGridView1.Columns[1].HeaderText = "Имя";
            DataGridView1.Columns[2].HeaderText = "Фамилия";
            DataGridView1.Columns[3].HeaderText = "Отчество";
            DataGridView1.Columns[4].HeaderText = "Номер телефона";
        }

        /// <summary>
        /// Отображение списка заказов клиента. 
        /// </summary>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 0) return;

                List<Order> orders = Orders.Where(x => x.Client.Email == Clients[e.RowIndex].Email).ToList();
                this.Enabled = false;
                var form = new AllOrdersForm(orders);
                
                form.FormClosed += (object x, FormClosedEventArgs e) =>
                {
                    this.Enabled = true;
                };
                form.Show();
            }

            catch
            {
                MessageBox.Show("Не удалось открыть список заказов.");
            }
        }
    }
}
