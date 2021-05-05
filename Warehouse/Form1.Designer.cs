
namespace Warehouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreateWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainMenuItemCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainMenuItemAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainMenuItemDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainMenuItemAddGood = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGood = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteGood = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRandomCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRandomGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBasket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClients = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolHelpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMyOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemActiveOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddGood = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveReportFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.ContextMenuStripTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeView1
            // 
            this.TreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TreeView1.BackColor = System.Drawing.Color.LightCyan;
            this.TreeView1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TreeView1.LineColor = System.Drawing.Color.DarkCyan;
            this.TreeView1.Location = new System.Drawing.Point(0, 31);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(300, 407);
            this.TreeView1.TabIndex = 0;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.TreeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWarehouse,
            this.toolStripMainMenuItemCategory,
            this.toolStripMenuItemGood,
            this.toolStripMenuItemReport,
            this.toolStripMenuItemRandom,
            this.toolStripMenuItemOrder,
            this.toolStripMenuItemActiveOrders,
            this.toolStripMenuItemBasket,
            this.toolStripMenuItemMyOrders,
            this.toolStripMenuItemClients,
            this.Exit,
            this.ToolHelpButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemWarehouse
            // 
            this.toolStripMenuItemWarehouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenWarehouse,
            this.toolStripMenuItemSaveWarehouse,
            this.toolStripMenuItemCreateWarehouse});
            this.toolStripMenuItemWarehouse.Name = "toolStripMenuItemWarehouse";
            this.toolStripMenuItemWarehouse.Size = new System.Drawing.Size(63, 24);
            this.toolStripMenuItemWarehouse.Text = "Склад";
            // 
            // toolStripMenuItemOpenWarehouse
            // 
            this.toolStripMenuItemOpenWarehouse.Name = "toolStripMenuItemOpenWarehouse";
            this.toolStripMenuItemOpenWarehouse.Size = new System.Drawing.Size(207, 26);
            this.toolStripMenuItemOpenWarehouse.Text = "Открыть склад";
            this.toolStripMenuItemOpenWarehouse.Click += new System.EventHandler(this.ToolStripMenuItemOpenWarehouse_Click);
            // 
            // toolStripMenuItemSaveWarehouse
            // 
            this.toolStripMenuItemSaveWarehouse.Enabled = false;
            this.toolStripMenuItemSaveWarehouse.Name = "toolStripMenuItemSaveWarehouse";
            this.toolStripMenuItemSaveWarehouse.Size = new System.Drawing.Size(207, 26);
            this.toolStripMenuItemSaveWarehouse.Text = "Сохранить склад";
            this.toolStripMenuItemSaveWarehouse.Click += new System.EventHandler(this.ToolStripMenuItemSaveWarehouse_Click);
            // 
            // toolStripMenuItemCreateWarehouse
            // 
            this.toolStripMenuItemCreateWarehouse.Name = "toolStripMenuItemCreateWarehouse";
            this.toolStripMenuItemCreateWarehouse.Size = new System.Drawing.Size(207, 26);
            this.toolStripMenuItemCreateWarehouse.Text = "Создать ";
            this.toolStripMenuItemCreateWarehouse.Click += new System.EventHandler(this.ToolStripMenuItemCreateWarehouse_Click);
            // 
            // toolStripMainMenuItemCategory
            // 
            this.toolStripMainMenuItemCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMainMenuItemAddCategory,
            this.toolStripMainMenuItemDeleteCategory,
            this.toolStripMainMenuItemAddGood});
            this.toolStripMainMenuItemCategory.Enabled = false;
            this.toolStripMainMenuItemCategory.Name = "toolStripMainMenuItemCategory";
            this.toolStripMainMenuItemCategory.Size = new System.Drawing.Size(95, 24);
            this.toolStripMainMenuItemCategory.Text = "Категория";
            // 
            // toolStripMainMenuItemAddCategory
            // 
            this.toolStripMainMenuItemAddCategory.Name = "toolStripMainMenuItemAddCategory";
            this.toolStripMainMenuItemAddCategory.Size = new System.Drawing.Size(236, 26);
            this.toolStripMainMenuItemAddCategory.Text = "Добавить категорию";
            this.toolStripMainMenuItemAddCategory.Click += new System.EventHandler(this.ToolStripMainMenuItemAddCategory_Click);
            // 
            // toolStripMainMenuItemDeleteCategory
            // 
            this.toolStripMainMenuItemDeleteCategory.Enabled = false;
            this.toolStripMainMenuItemDeleteCategory.Name = "toolStripMainMenuItemDeleteCategory";
            this.toolStripMainMenuItemDeleteCategory.Size = new System.Drawing.Size(236, 26);
            this.toolStripMainMenuItemDeleteCategory.Text = "Удалить категорию";
            this.toolStripMainMenuItemDeleteCategory.Click += new System.EventHandler(this.ToolStripMainMenuItemDeleteCategory_Click);
            // 
            // toolStripMainMenuItemAddGood
            // 
            this.toolStripMainMenuItemAddGood.Enabled = false;
            this.toolStripMainMenuItemAddGood.Name = "toolStripMainMenuItemAddGood";
            this.toolStripMainMenuItemAddGood.Size = new System.Drawing.Size(236, 26);
            this.toolStripMainMenuItemAddGood.Text = " Добавить товар";
            this.toolStripMainMenuItemAddGood.Click += new System.EventHandler(this.ToolStripMainMenuItemAddGood_Click);
            // 
            // toolStripMenuItemGood
            // 
            this.toolStripMenuItemGood.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteGood});
            this.toolStripMenuItemGood.Enabled = false;
            this.toolStripMenuItemGood.Name = "toolStripMenuItemGood";
            this.toolStripMenuItemGood.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItemGood.Text = "Товар";
            // 
            // toolStripMenuItemDeleteGood
            // 
            this.toolStripMenuItemDeleteGood.Enabled = false;
            this.toolStripMenuItemDeleteGood.Name = "toolStripMenuItemDeleteGood";
            this.toolStripMenuItemDeleteGood.Size = new System.Drawing.Size(191, 26);
            this.toolStripMenuItemDeleteGood.Text = "Удалить товар";
            this.toolStripMenuItemDeleteGood.Click += new System.EventHandler(this.ToolStripMenuItemDeleteGood_Click);
            // 
            // toolStripMenuItemReport
            // 
            this.toolStripMenuItemReport.Enabled = false;
            this.toolStripMenuItemReport.Name = "toolStripMenuItemReport";
            this.toolStripMenuItemReport.Size = new System.Drawing.Size(119, 24);
            this.toolStripMenuItemReport.Text = "Создать отчет";
            this.toolStripMenuItemReport.Click += new System.EventHandler(this.ToolStripMenuItemReport_Click);
            // 
            // toolStripMenuItemRandom
            // 
            this.toolStripMenuItemRandom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRandomCategories,
            this.toolStripMenuItemRandomGoods});
            this.toolStripMenuItemRandom.Enabled = false;
            this.toolStripMenuItemRandom.Name = "toolStripMenuItemRandom";
            this.toolStripMenuItemRandom.Size = new System.Drawing.Size(98, 24);
            this.toolStripMenuItemRandom.Text = "Генерация";
            // 
            // toolStripMenuItemRandomCategories
            // 
            this.toolStripMenuItemRandomCategories.Name = "toolStripMenuItemRandomCategories";
            this.toolStripMenuItemRandomCategories.Size = new System.Drawing.Size(281, 26);
            this.toolStripMenuItemRandomCategories.Text = "Сгенировать подкатегории";
            this.toolStripMenuItemRandomCategories.Click += new System.EventHandler(this.ToolStripMenuItemRandomCategories_Click);
            // 
            // toolStripMenuItemRandomGoods
            // 
            this.toolStripMenuItemRandomGoods.Enabled = false;
            this.toolStripMenuItemRandomGoods.Name = "toolStripMenuItemRandomGoods";
            this.toolStripMenuItemRandomGoods.Size = new System.Drawing.Size(281, 26);
            this.toolStripMenuItemRandomGoods.Text = "Сгенерировать товары";
            this.toolStripMenuItemRandomGoods.Click += new System.EventHandler(this.toolStripMenuItemRandomGoods_Click);
            // 
            // toolStripMenuItemOrder
            // 
            this.toolStripMenuItemOrder.Name = "toolStripMenuItemOrder";
            this.toolStripMenuItemOrder.Size = new System.Drawing.Size(72, 24);
            this.toolStripMenuItemOrder.Text = "Заказы";
            this.toolStripMenuItemOrder.Click += new System.EventHandler(this.toolStripMenuItemOrder_Click);
            // 
            // toolStripMenuItemBasket
            // 
            this.toolStripMenuItemBasket.Name = "toolStripMenuItemBasket";
            this.toolStripMenuItemBasket.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItemBasket.Text = "Корзина";
            this.toolStripMenuItemBasket.Click += new System.EventHandler(this.ToolStripMenuItemBasket_Click);
            // 
            // toolStripMenuItemClients
            // 
            this.toolStripMenuItemClients.Name = "toolStripMenuItemClients";
            this.toolStripMenuItemClients.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItemClients.Text = "Клиенты";
            this.toolStripMenuItemClients.Click += new System.EventHandler(this.toolStripMenuItemClients_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(67, 24);
            this.Exit.Text = "Выйти";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ToolHelpButton
            // 
            this.ToolHelpButton.Name = "ToolHelpButton";
            this.ToolHelpButton.Size = new System.Drawing.Size(30, 24);
            this.ToolHelpButton.Text = "?";
            this.ToolHelpButton.Click += new System.EventHandler(this.ToolHelpButton_Click);
            // 
            // toolStripMenuItemMyOrders
            // 
            this.toolStripMenuItemMyOrders.Name = "toolStripMenuItemMyOrders";
            this.toolStripMenuItemMyOrders.Size = new System.Drawing.Size(106, 24);
            this.toolStripMenuItemMyOrders.Text = "Мои заказы";
            this.toolStripMenuItemMyOrders.Click += new System.EventHandler(this.toolStripMenuItemMyOrders_Click);
            // 
            // toolStripMenuItemActiveOrders
            // 
            this.toolStripMenuItemActiveOrders.Name = "toolStripMenuItemActiveOrders";
            this.toolStripMenuItemActiveOrders.Size = new System.Drawing.Size(143, 24);
            this.toolStripMenuItemActiveOrders.Text = "Активные заказы";
            this.toolStripMenuItemActiveOrders.Click += new System.EventHandler(this.toolStripMenuItemActiveOrders_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.GridColor = System.Drawing.Color.Gold;
            this.DataGridView1.Location = new System.Drawing.Point(297, 54);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 49;
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.Size = new System.Drawing.Size(762, 187);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // ContextMenuStripTreeView
            // 
            this.ContextMenuStripTreeView.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.ContextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddCategory,
            this.toolStripMenuItemAddGood,
            this.toolStripMenuItemDeleteCategory});
            this.ContextMenuStripTreeView.Name = "contextMenuStrip1";
            this.ContextMenuStripTreeView.Size = new System.Drawing.Size(250, 76);
            // 
            // toolStripMenuItemAddCategory
            // 
            this.toolStripMenuItemAddCategory.Name = "toolStripMenuItemAddCategory";
            this.toolStripMenuItemAddCategory.Size = new System.Drawing.Size(249, 24);
            this.toolStripMenuItemAddCategory.Text = "Добавить подкатегорию";
            this.toolStripMenuItemAddCategory.Click += new System.EventHandler(this.ToolStripMenuItemAddCategory_Click);
            // 
            // toolStripMenuItemAddGood
            // 
            this.toolStripMenuItemAddGood.Enabled = false;
            this.toolStripMenuItemAddGood.Name = "toolStripMenuItemAddGood";
            this.toolStripMenuItemAddGood.Size = new System.Drawing.Size(249, 24);
            this.toolStripMenuItemAddGood.Text = "Добавить товар";
            this.toolStripMenuItemAddGood.Click += new System.EventHandler(this.ToolStripMenuItemAddGood_Click);
            // 
            // toolStripMenuItemDeleteCategory
            // 
            this.toolStripMenuItemDeleteCategory.Enabled = false;
            this.toolStripMenuItemDeleteCategory.Name = "toolStripMenuItemDeleteCategory";
            this.toolStripMenuItemDeleteCategory.Size = new System.Drawing.Size(249, 24);
            this.toolStripMenuItemDeleteCategory.Text = "Удалить категорию";
            this.toolStripMenuItemDeleteCategory.Click += new System.EventHandler(this.ToolStripMenuItemDeleteCategory_Click);
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "bin|*.bin";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            this.OpenFileDialog1.Filter = "bin|*.bin";
            // 
            // SaveReportFileDialog2
            // 
            this.SaveReportFileDialog2.Filter = "csv|*.csv";
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows = false;
            this.DataGridView2.AllowUserToDeleteRows = false;
            this.DataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView2.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.GridColor = System.Drawing.Color.Yellow;
            this.DataGridView2.Location = new System.Drawing.Point(297, 267);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.ReadOnly = true;
            this.DataGridView2.RowHeadersWidth = 49;
            this.DataGridView2.RowTemplate.Height = 28;
            this.DataGridView2.Size = new System.Drawing.Size(762, 185);
            this.DataGridView2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Товары подкатегорий:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Товары категории:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.TreeView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.Text = "Склад";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ContextMenuStripTreeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMainMenuItemAddCategory;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMainMenuItemAddGood;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.SaveFileDialog SaveReportFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView DataGridView1;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStripTreeView;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouse;
        public System.Windows.Forms.DataGridView DataGridView2;
        public System.Windows.Forms.ToolStripMenuItem Exit;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddCategory;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddGood;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteCategory;
        public System.Windows.Forms.ToolStripMenuItem toolStripMainMenuItemCategory;
        public System.Windows.Forms.ToolStripMenuItem toolStripMainMenuItemDeleteCategory;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGood;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteGood;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenWarehouse;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveWarehouse;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateWarehouse;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReport;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRandom;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRandomCategories;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRandomGoods;
        public System.Windows.Forms.ToolStripMenuItem ToolHelpButton;
        public System.Windows.Forms.TreeView TreeView1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrder;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBasket;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMyOrders;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClients;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemActiveOrders;
    }
}

