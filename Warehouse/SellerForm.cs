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
    public partial class SellerForm : Form1
    {
        Warehouse CurrentWarehouse;
        public SellerForm(string warehousePath):base()
        {
            InitializeComponent();
            try
            {
                
                TreeView1.Nodes.Clear();
                DeserializeWarehouse(out CurrentWarehouse, warehousePath);
                if (CurrentWarehouse is null) throw new Exception();
                TreeView1.Nodes.Add(CurrentWarehouse);
                ActivateWarehouseButtons();
                toolStripMenuItemBasket.Visible = false;
                toolStripMenuItemMyOrders.Visible = false;
            }
            catch
            {
                MessageBox.Show("Не удалось открыть склад.");
            }
        }

       
        /// <summary>
        /// Десериализация.
        /// </summary>
        /// <param name="warehouse">Склад.</param>
        /// <param name="file">Путь к складу.</param>
        private void DeserializeWarehouse(out Warehouse warehouse, string file)
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
        ///  Отображение таблиц с товарами.
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
                DataGridView2.Columns[3].HeaderText = "Колличество";
                DataGridView2.Columns[4].Visible = false;

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
                    DataGridView1.Columns[3].HeaderText = "Колличество";
                    DataGridView1.Columns[4].Visible = false;
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
            catch//(Exception ex)
            {
                //MessageBox.Show("Что-то пошлоex.Message);
                return;
            }
        }

        /// <summary>
        /// Сохранение при закрытии склада.
        /// </summary>
        private void SellerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("При закрытии несохраненные изменения могут быть утерены. Закрыть программу?", "Предупреждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                string file = MainForm.WarehousePath;
                SerialiseClass sClass = new SerialiseClass(CurrentWarehouse);
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, sClass);
                }
                
            }

            catch
            {
                MessageBox.Show("Не удалось сохранить изменения продавца.");
            }
        }
    }

}
