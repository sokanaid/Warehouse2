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
            MessageBox.Show("1.Изменение склада возможно только из личного кабинета продавца.");
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
    }
}
