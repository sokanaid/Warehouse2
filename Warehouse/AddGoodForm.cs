using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    /// <summary>
    ///  Форма для добавления товара.
    /// </summary>
    public partial class AddGoodForm : Form
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        public string GoodName { get; private set; }
        /// <summary>
        /// Артикул.
        /// </summary>
        public string GoodCode { get;private set; }
        /// <summary>
        /// Цена.
        /// </summary>
        public double Price { get; private set; }
        /// <summary>
        /// Остаток.
        /// </summary>
        public int Count { get; private set; }
        public AddGoodForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку отмены.
        /// </summary>
        private void CanscelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Нажатие на кнопку OK.
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Price = double.Parse(PriceTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Цена должна быть десятичной дробью с разделителем \".\" ");
                return;
            }
            if (NameTextBox.Text is null ||  NameTextBox.Text.Length == 0 || CodeTextBox.Text is null || CodeTextBox.Text is null || !CodeTextBox.MaskCompleted)
            {
                MessageBox.Show("Пожалуйста заполните все поля");
                return;
            }
            GoodName = NameTextBox.Text;
            GoodCode = CodeTextBox.Text;
            Count =(int) CountTextBox.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
