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
        public SellerForm(string warehousePath):base()
        {
            InitializeComponent();
            try
            {
                Warehouse warehouse;
                TreeView1.Nodes.Clear();
                DeserializeWarehouse(out warehouse, warehousePath);
                if (warehouse is null) throw new Exception();
                TreeView1.Nodes.Add(warehouse);
                ActivateWarehouseButtons();

            }
            catch
            {
                MessageBox.Show("Не удалось открыть склад.");
            }
        }

        private void SellerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("При закрытии несохраненные изменения могут быть утерены. Закрыть программу?", "Предупреждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                MainForm.WarehousePath = this.WarehousePath;
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
    }
}
