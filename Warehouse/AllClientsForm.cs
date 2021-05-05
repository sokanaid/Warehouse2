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

            DataGridView1.Columns[0].HeaderText = "E-mail";
            DataGridView1.Columns[1].HeaderText = "Имя";
            DataGridView1.Columns[2].HeaderText = "Фамилия";
            DataGridView1.Columns[3].HeaderText = "Отчество";
            DataGridView1.Columns[4].HeaderText = "Номер телефона";
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Суммарная стоимость заказов"
            });

            DataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                Text = "Список заказов"
            });
            
        }

        /// <summary>
        /// Отображение списка заказов клиента. 
        /// </summary>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 1) return;

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
        /// <summary>
        /// Дополнение таблицы при загрузке формы.
        /// </summary>
        private void AllClientsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                double sum = 0;
                foreach (var j in Orders)
                {
                    if (j.Client.Email == Clients[i].Email)
                    {
                        sum += j.GetSum();
                    }
                }
                DataGridView1.Rows[i].Cells[0].Value = $"{sum:f2}";
            }
            DataGridView1.Refresh();
        }
    }
}
