using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class ReportForm : Form
    {
        public uint Count { get; private set; }
        public ReportForm()
        {
            InitializeComponent();
            label1.Text = "Введите колличество товара. " + Environment.NewLine + "(Товары с меньшим количеством или таким же попадут"+ 
                Environment.NewLine+"в отчет)";
        }

        /// <summary>
        /// Обработка события нажатия на кнопку отмены.
        /// </summary>
        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Count =(uint)numericUpDown1.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
