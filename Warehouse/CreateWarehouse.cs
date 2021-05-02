using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class CreateWarehouse : AddCategoryForm
    {
        public CreateWarehouse()
        {
            InitializeComponent();
            Label1.Text = "Введите название склада:";
            
        }
    }
}
