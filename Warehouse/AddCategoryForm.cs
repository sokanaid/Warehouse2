using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    /// <summary>
    /// Форма для ввода названия подкатегории.
    /// </summary>
    public partial class AddCategoryForm : Form
    {
        /// <summary>
        /// Код сортировки.
        /// </summary>
        public int SortCode { get; private set; }
        private string categoryName;
        /// <summary>
        ///  Введенное имя.
        /// </summary>
        public string CategoryName
        {
            get
            {
                return categoryName;
            }
        }
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатиее на кнопку Ok.
        /// </summary>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text is null || TextBox1.Text.Length==0)
            {
                MessageBox.Show("Имя не может быть пустым.");
                return;
            }
            categoryName = TextBox1.Text;
            SortCode = (int)NumericUpDownSortCode.Value;
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Нажатиее на кнопку Cansel.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
