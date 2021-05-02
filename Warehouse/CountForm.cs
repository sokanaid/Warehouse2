using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class CountForm : Form
    {
        public int Count { get; private set; }
        public CountForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку отмены.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Нажатие на кнопку Ok.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Count = (int)numericUpDownCount.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
