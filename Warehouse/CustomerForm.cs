using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class CustomerForm : Form1
    {
        Warehouse CurrentWarehouse;
        private CustomerForm()
        {
            toolStripMainMenuItemCategory.Visible = false;
            toolStripMenuItemGood.Visible = false;
            toolStripMenuItemWarehouse.Visible = false;
            toolStripMenuItemRandom.Visible = false;
            toolStripMenuItemReport.Visible = false;
            toolStripMenuItemClients.Visible = false;
            ContextMenuStripTreeView.Enabled = false;
            toolStripMenuItemActiveOrders.Visible = false;
            InitializeComponent();
        }
        public CustomerForm(string Warehousepath) : this()
        {
            try
            {
                TreeView1.Nodes.Clear();
                DeserializeWarehouse(ref CurrentWarehouse, Warehousepath);
                TreeView1.Nodes.Add(CurrentWarehouse);
            }
            catch
            {
                MessageBox.Show("Не удалось открыть склад. Зайдите в аккаунт продавца и выбирете склад.");
            }

        }
        /// <summary>
        /// Нажание на кнопку помощи в главном меню.
        /// </summary>
        public override void ToolHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Изменение склада возможно только из личного кабинета продавца." +
                Environment.NewLine + "2.Для того чтобы положить товар в корзину, измените значение \"В корзине\" для данного товара в верхней таблице");
        }
        /// <summary>
        /// Десериализация.
        /// </summary>
        /// <param name="warehouse">Склад.</param>
        /// <param name="file">Путь к складу.</param>
        private void DeserializeWarehouse(ref Warehouse warehouse, string file)
        {

            SerialiseClass sClass;
            BinaryFormatter formatter = new BinaryFormatter();
            //string h = File.ReadAllText(file);
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                sClass = (SerialiseClass)formatter.Deserialize(fs);
            }
            warehouse = sClass.ReturnWarehouse();

        }
        /// <summary>
        /// Отображение списков товаров при нажатии на категорию.
        /// </summary>
        protected override void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!IsWareHouseOpen()) return;
            try
            {

                DataGridView1.DataSource = null;
                DataGridView2.DataSource = null;
                List<Good> list = AllCatigoriesGoods((Warehouse)TreeView1.SelectedNode);
                DataGridView2.DataSource = list;
                DataGridView2.Columns[0].HeaderText = "Наименование";
                DataGridView2.Columns[1].HeaderText = "Артикул";
                DataGridView2.Columns[2].HeaderText = "Цена";
                DataGridView2.Columns[3].HeaderText = "На складе";
                DataGridView2.Columns[4].HeaderText = "В корзине";

                if (TreeView1.SelectedNode is Category category)
                {
                    toolStripMainMenuItemAddGood.Enabled = true;
                    toolStripMenuItemAddGood.Enabled = true;
                    toolStripMenuItemDeleteCategory.Enabled = true;
                    toolStripMainMenuItemDeleteCategory.Enabled = true;
                    toolStripMenuItemRandomGoods.Enabled = true;
                    DataGridView1.DataSource = category.Goods.GetRange(0,
                        category.Goods.Count);
                    DataGridView1.Columns[0].HeaderText = "Наименование";
                    DataGridView1.Columns[1].HeaderText = "Артикул";
                    DataGridView1.Columns[2].HeaderText = "Цена";
                    DataGridView1.Columns[3].HeaderText = "На складе";
                    DataGridView1.Columns[4].HeaderText = "В корзине";
                    for (int i = 0; i <= 3; i++)
                    {
                        DataGridView1.Columns[i].ReadOnly = true;
                    }
                }
                else
                {
                    toolStripMainMenuItemAddGood.Enabled = false;
                    toolStripMenuItemAddGood.Enabled = false;
                    toolStripMenuItemDeleteCategory.Enabled = false;
                    toolStripMainMenuItemDeleteCategory.Enabled = false;
                    toolStripMenuItemRandomGoods.Enabled = false;
                }
            }
            catch
            {
                return;
            }
        }
        /// <summary>
        /// Сохранение при закрытии склада.
        /// </summary>
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string file = MainForm.WarehousePath;
                SerialiseClass sClass = new SerialiseClass(CurrentWarehouse);
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                {
                    // сериализуем весь массив people
                    formatter.Serialize(fs, sClass);

                }
            }

            catch
            {
                MessageBox.Show("Не удалось сохранить изменения покупателя.");
            }
        }
    }
}
