using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Warehouse
{
    public partial class Form1 : Form
    {
        Random Rnd = new Random();
        /// <summary>
        /// Стартовая форма.
        /// </summary>
        public StartForm MainForm;
        //public string WarehousePath { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Происходит при двойном нажатии на категорию.
        /// </summary>
        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!IsWareHouseOpen()) return;
            ContextMenuStripTreeView.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        /// <summary>
        /// Добавление категории из контекстного меню.
        /// </summary>
        private void ToolStripMenuItemAddCategory_Click(object sender, EventArgs e)
        {
            if (!IsWareHouseOpen()) return;
            AddCategory((Warehouse)TreeView1.SelectedNode);
        }

        /// <summary>
        /// Добавление подкатегории.
        /// </summary>
        /// <param name="category">Текущая категория.</param>
        private void AddCategory(Warehouse category)
        {

            AddCategoryForm addCategoryForm = new AddCategoryForm();
            if (addCategoryForm.ShowDialog() == DialogResult.OK)
            {
                string name = addCategoryForm.CategoryName;
                int sortCode = addCategoryForm.SortCode;
                if (category.Catigories.ContainsKey(name))
                {
                    MessageBox.Show("Подкатегория с таким названием уже существует");
                    return;
                }
                var newCategory = new Category(name, sortCode);
                category.Catigories[name] = newCategory;
                TreeView1.BeginUpdate();
                category.Nodes.Add(newCategory);
                SortNodes(category);
                TreeView1.EndUpdate();
                TreeView1_AfterSelect(new object(), new TreeViewEventArgs(category));
            }
        }
        /// <summary>
        /// Сортировка узлов дерева.
        /// </summary>
        /// <param name="category"></param>
        private void SortNodes(Warehouse category)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (TreeNode i in category.Nodes)
            {
                nodes.Add(i);
            }
            nodes.Sort(new Warehouse());
            category.Nodes.Clear();
            category.Nodes.AddRange(nodes.ToArray());
        }

        /// <summary>
        /// Добавление категории из главного меню.
        /// </summary>
        private void ToolStripMainMenuItemAddCategory_Click(object sender, EventArgs e)
        {
            if (!IsWareHouseOpen()) return;
            try
            {
                AddCategory((Warehouse)TreeView1.SelectedNode);
            }
            catch
            {
                MessageBox.Show("Сначала выберите узел текущей категории");
            }
        }

        /// <summary>
        /// Добавление товара из контекстного меню.
        /// </summary>
        private void ToolStripMenuItemAddGood_Click(object sender, EventArgs e)
        {
            if (!IsWareHouseOpen()) return;
            if (!(TreeView1.SelectedNode is Category))
            {
                MessageBox.Show("Не возможно добавить товар на склад. Выберете одну из категорий склада и добавьте товар в нее.");
                return;
            }
            AddGood((Category)TreeView1.SelectedNode);
        }
        /// <summary>
        /// Добавление товара.
        /// </summary>
        /// <param name="category"> Категория, в которую добавляется товар.</param>
        private void AddGood(Category category)
        {
            AddGoodForm addGoodForm = new AddGoodForm();
            if (addGoodForm.ShowDialog() != DialogResult.Cancel)
            {
                Good newGood = new Good(addGoodForm.GoodName, addGoodForm.GoodCode, addGoodForm.Price, addGoodForm.Count);

                category.Goods.Add(newGood);
                TreeView1_AfterSelect(new object(), new TreeViewEventArgs(category));
            }
        }

        /// <summary>
        /// Добавление товара из главного меню.
        /// </summary>
        private void ToolStripMainMenuItemAddGood_Click(object sender, EventArgs e)
        {
            if (!IsWareHouseOpen()) return;
            if (!(TreeView1.SelectedNode is Category))
            {
                MessageBox.Show("Не возможно добавить товар на склад. Выберете одну из категорий склада и добавьте товар в нее.");
                return;
            }
            try
            {
                AddGood((Category)TreeView1.SelectedNode);
            }
            catch
            {
                MessageBox.Show("Сначала выберите узел текущей категории");
            }
        }

        /// <summary>
        /// Удаление категории из контекстного меню.
        /// </summary>
        private void ToolStripMenuItemDeleteCategory_Click(object sender, EventArgs e)
        {
            if (!IsWareHouseOpen()) return;
            if (!(TreeView1.SelectedNode is Category))
            {
                MessageBox.Show("Не возможно удалить склад.");
                return;
            }
            DeleteCategory((Category)TreeView1.SelectedNode);
        }

        /// <summary>
        /// Удаление категории.
        /// </summary>
        /// <param name="category">Категория.</param>
        private void DeleteCategory(Category category)
        {
            if (!IsWareHouseOpen()) return;
            if (category.Goods.Count != 0 || category.Catigories.Count != 0)
            {
                MessageBox.Show("Невозможно удалить эту подкатегорию, так как она содержит склады или подкатегории.");
                return;
            }
            Warehouse ParentCategory = (Warehouse)category.Parent;
            ParentCategory.Catigories.Remove(category.Name);
            TreeView1.BeginUpdate();
            category.Remove();
            TreeView1.EndUpdate();
            TreeView1_AfterSelect(new object(), new TreeViewEventArgs(category));
        }

        /// <summary>
        ///  Удаление категории из главного меню.
        /// </summary>
        private void ToolStripMainMenuItemDeleteCategory_Click(object sender, EventArgs e)
        {
            if (!IsWareHouseOpen()) return;
            if (!(TreeView1.SelectedNode is Category))
            {
                MessageBox.Show("Не возможно удалить склад.");
                return;
            }
            try
            {
                DeleteCategory((Category)TreeView1.SelectedNode);
            }
            catch
            {
                MessageBox.Show("Сначала выберите узел текущей категории");
            }
        }

        /// <summary>
        /// Обработка ошибок в таблице товаров.
        /// </summary>А
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введенное значение не корректно. Колличество - это целое положительное число или 0. Цена - десятичная дробь" +
                "с разделителем \".\"");
        }

        /// <summary>
        /// Отображение списков товаров при нажатии на категорию.
        /// </summary>
        protected virtual void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
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
        /// Список товаров всех подкатегорий
        /// </summary>
        /// <returns></returns>
        public static List<Good> AllCatigoriesGoods(Warehouse category)
        {
            List<Good> ans = new List<Good>();

            foreach (var i in category.Nodes)
            {
                ans.AddRange(((Category)i).Goods);
                ans.AddRange(AllCatigoriesGoods((Warehouse)i));
            }
            return ans;
        }

        /// <summary>
        ///  Сохранение склада.
        /// </summary>
        /// <param name="warehouse">Склад</param>
        private void SerializeWarehouse(Warehouse warehouse)
        {
            //if (!IsWareHouseOpen()) return;
            try
            {
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string file = SaveFileDialog1.FileName;
                    SerialiseClass sClass = new SerialiseClass(warehouse);
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        // сериализуем весь массив people
                        formatter.Serialize(fs, sClass);

                    }
                    MainForm.WarehousePath = file;
                }

            }
            catch
            {
                MessageBox.Show("Не удалось сохранить склад.");
            }
        }

        /// <summary>
        ///  Открытие склада.
        /// </summary>
        /// <param name="warehouse">Склад</param>
        private void DeserializeWarehouse(ref Warehouse warehouse)
        {
            try
            {
                //if (!IsWareHouseOpen()) return;
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string file = OpenFileDialog1.FileName;
                    SerialiseClass sClass;
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        // сериализуем весь массив people
                        sClass = (SerialiseClass)formatter.Deserialize(fs);

                    }
                    warehouse = sClass.ReturnWarehouse();
                    MainForm.WarehousePath = file;
                }
                else warehouse = null;



            }
            catch
            {
                MessageBox.Show("Не удалось сохранить склад.");
            }
        }
        /// <summary>
        /// Удаление товара.
        /// </summary>
        private void ToolStripMenuItemDeleteGood_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsWareHouseOpen()) return;
                if (DataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Сначала выберете строки с товарами которые нужно удалить. Для этого кликните на заголовок строки." +
                        "Для выбора несольких строк зажмите CTRL.");
                }
                Category category = (Category)TreeView1.SelectedNode;
                foreach (DataGridViewRow i in DataGridView1.SelectedRows)
                {
                    var good = new Good((string)i.Cells[0].Value, (string)i.Cells[1].Value, (double)i.Cells[2].Value, (int)((uint)i.Cells[3].Value));
                    category.Goods.Remove(category.Goods.Find(x => x == good));
                }
                TreeView1_AfterSelect(new object(), new TreeViewEventArgs(category));
            }
            catch
            {
                MessageBox.Show("Не удалось удалить товар.");
            }
        }
        protected bool IsWareHouseOpen()
        {
            if (TreeView1.Nodes.Count == 0)
            {
                MessageBox.Show("Сначала откройте или создайте склад.");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Активирует кнопки при открытии или создании склада.
        /// </summary>
        /// <param name="ind">Индикатор.</param>
        protected void ActivateWarehouseButtons(bool ind = true)
        {

            toolStripMainMenuItemCategory.Enabled = ind;
            toolStripMenuItemGood.Enabled = ind;
            toolStripMenuItemReport.Enabled = ind;
            toolStripMenuItemSaveWarehouse.Enabled = ind;
            toolStripMenuItemRandom.Enabled = ind;

        }

        /// <summary>
        /// Открытие склада.
        /// </summary>
        private void ToolStripMenuItemOpenWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                Warehouse warehouse = new Warehouse();
                DeserializeWarehouse(ref warehouse);
                if (warehouse is null) return;
                TreeView1.Nodes.Clear();
                TreeView1.Nodes.Add(warehouse);
                ActivateWarehouseButtons();
            }
            catch
            {
                MessageBox.Show("Не удалось открыть склад.");
            }
        }
        /// <summary>
        /// Сохранение склада.
        /// </summary>
        private void ToolStripMenuItemSaveWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsWareHouseOpen()) return;
                TreeView1.BeginUpdate();
                SerializeWarehouse((Warehouse)TreeView1.Nodes[0]);
                TreeView1.EndUpdate();
            }
            catch
            {
                MessageBox.Show("Не удалось открыть склад.");
            }
        }

        /// <summary>
        /// Создание склада.
        /// </summary>
        private void ToolStripMenuItemCreateWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                CreateWarehouse createWarehouse = new CreateWarehouse();
                if (createWarehouse.ShowDialog() == DialogResult.OK)
                {
                    Warehouse warehouse = new Warehouse(createWarehouse.CategoryName, createWarehouse.SortCode);
                    TreeView1.Nodes.Clear();
                    TreeView1.Nodes.Add(warehouse);
                    ActivateWarehouseButtons();
                }

            }
            catch
            {
                MessageBox.Show("Не удалось создать склад.");
            }
        }

        /// <summary>
        /// Создание отчета из главного меню.
        /// </summary>
        private void ToolStripMenuItemReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsWareHouseOpen()) return;
                ReportForm reportForm = new ReportForm();
                uint count;
                if (reportForm.ShowDialog() != DialogResult.Cancel)
                {
                    count = reportForm.Count;

                    List<List<string>> list = FindAllGoods(count);
                    if (SaveReportFileDialog2.ShowDialog() != DialogResult.Cancel)
                    {
                        string filePath = SaveReportFileDialog2.FileName;
                        using (StreamWriter fin = new StreamWriter(filePath, false, Encoding.UTF8))
                        {
                            fin.WriteLine("Путь классификатора;Артикул;Наименование;Остаток");
                            foreach (var item in list)
                            {
                                string str = "";
                                for (int i = 0; i < 4; i++)
                                {
                                    if (i != 0) str += ';';
                                    str += item[i];
                                }
                                fin.WriteLine(str);
                            }
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Не удалось создать отчет.Возможно файл используется другой программой");
            }
        }

        /// <summary>
        /// Поиск всех товаров с меньшим колличеством на складе.
        /// </summary>
        /// <param name="count">Минимальное колличество.</param>
        /// <returns>Список товаров</returns>
        private List<List<string>> FindAllGoods(uint count)
        {
            try
            {
                List<List<string>> ans = new List<List<string>>();
                if (TreeView1.Nodes is null) return ans;
                foreach (var i in TreeView1.Nodes[0].Nodes)
                {
                    ans.AddRange(FindAllGoodsInCategory(count, (Category)i));
                }
                return ans;
            }
            catch
            {
                MessageBox.Show("Не удалось найти товары.");
                return new List<List<string>>();
            }
        }

        /// <summary>
        /// Поиск всех товаров с меньшим колличеством рекурсивный по категории.
        /// </summary>
        /// <param name="count">Минимальное колличество.</param>
        /// <returns>Список товаров.</returns>
        private List<List<string>> FindAllGoodsInCategory(uint count, Category category)
        {
            List<List<string>> ans = new List<List<string>>();
            if (!(category.Goods is null))
            {
                foreach (var i in category.Goods)
                {
                    if (i.Count <= count)
                    {
                        ans.Add(new List<string> { category.FullPath, i.Code, i.Name, i.Count.ToString() });
                    }
                }

            }
            if (!(category.Nodes is null))
            {
                foreach (var i in category.Nodes)
                {
                    ans.AddRange(FindAllGoodsInCategory(count, (Category)i));
                }
            }
            return ans;
        }

        /// <summary>
        /// Изменение состояния кнопок при изменении выделения в таблице.
        /// </summary>
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                bool ind = DataGridView1.SelectedRows.Count > 0;
                toolStripMenuItemDeleteGood.Enabled = ind;
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Нажание на кнопку помощи в главном меню.
        /// </summary>
        public virtual void ToolHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Для выделения нескольких товаров зажмите CTRL."
                + Environment.NewLine + "2. При двойном клики на узел дерева открывается контекстное меню"
                + Environment.NewLine + "3. Для изменения характеристик товара измените данные в таблице (Артикул не изменяется)");
        }

        /// <summary>
        /// Генерация подкатегорий.
        /// </summary>
        private void ToolStripMenuItemRandomCategories_Click(object sender, EventArgs e)
        {
            try
            {
                var getCountForm = new CountForm();
                if (getCountForm.ShowDialog() == DialogResult.OK)
                {
                    Warehouse warehouse = (Warehouse)TreeView1.SelectedNode;
                    int count = getCountForm.Count;
                    for (int i = 0; i < count; i++)
                    {
                        string name = GenerateString();
                        while (warehouse.Catigories.ContainsKey(name))
                        {
                            name = GenerateString();
                        }
                        Category category = new Category(name, Rnd.Next(0, 100000));
                        warehouse.Catigories[name] = category;
                        warehouse.Nodes.Add(category);
                        SortNodes(warehouse);
                        TreeView1_AfterSelect(sender, new TreeViewEventArgs(TreeView1.SelectedNode));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось сгенерировать подкатегории.");
            }
        }

        /// <summary>
        /// Генерация имени.
        /// </summary>
        /// <returns></returns>
        private string GenerateString()
        {
            int len = Rnd.Next(1, 10);
            string name = "";
            for (int i = 0; i < len; i++)
            {
                name += (char)Rnd.Next('a', 'z' + 1);
            }
            return name;
        }
        /// <summary>
        /// Генерация товаров.
        /// </summary>
        private void toolStripMenuItemRandomGoods_Click(object sender, EventArgs e)
        {
            try
            {
                var getCountForm = new CountForm();
                if (getCountForm.ShowDialog() == DialogResult.OK)
                {
                    Category category = (Category)TreeView1.SelectedNode;
                    int count = getCountForm.Count;
                    for (int i = 0; i < count; i++)
                    {
                        string name = GenerateString();
                        string code = GenerateCode();
                        int Count = Rnd.Next(0, 1000000);
                        double price = Rnd.Next(0, 1000000) + Rnd.NextDouble();
                        category.Goods.Add(new Good(name, code, price, Count));
                        TreeView1_AfterSelect(sender, new TreeViewEventArgs(TreeView1.SelectedNode));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось сгенерировать товар.");
            }
        }
        /// <summary>
        /// Генерация артикля.
        /// </summary>
        /// <returns></returns>
        private string GenerateCode()
        {
            return Rnd.Next(10, 100) + "-" + Rnd.Next(1000, 10000) + "-" + Rnd.Next(10, 100);
        }

        /// <summary>
        /// Выход из аккаунта.
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Закрытие формы.
        /// </summary>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Visible = true;
        }

        /// <summary>
        /// Переход в корзину.
        /// </summary>
        private void ToolStripMenuItemBasket_Click(object sender, EventArgs e)
        {
            try
            {
                List<Good> goods = AllCatigoriesGoods((Warehouse)TreeView1.Nodes[0]).Where(x => x.ChousenCount > 0).ToList();
                BasketForm form = new BasketForm(goods, (Warehouse)TreeView1.Nodes[0], MainForm.CurrentClient);
                form.Show();
                this.Enabled = false;
                form.FormClosed += (object x, FormClosedEventArgs e) => {
                    this.Enabled = true;
                };
            }
            catch
            {
                MessageBox.Show("Не удалось открыть карзину.");
            }
        }

        /// <summary>
        /// Список заказов.
        /// </summary>
        private void toolStripMenuItemMyOrders_Click(object sender, EventArgs e)
        {
            try
            {
                if(((Warehouse)TreeView1.Nodes[0]).Orders is null)
                {
                    ((Warehouse)TreeView1.Nodes[0]).Orders = new List<(string CastomerName, Order Order)>();
                }
                List<Order> orders = new List<Order>();
                for(int i=0; i< ((Warehouse)TreeView1.Nodes[0]).Orders.Count; i++){
                    if(((Warehouse)TreeView1.Nodes[0]).Orders[i].CastomerName== MainForm.CurrentClient.Email)
                    {
                        orders.Add(((Warehouse)TreeView1.Nodes[0]).Orders[i].Order);
                    }
                }
                var form = new OrdersForm(orders);
                form.Show();
                this.Enabled = false;
                form.FormClosed += (object x, FormClosedEventArgs e) => {
                    this.Enabled = true;
                };

            }
            catch
            {
                MessageBox.Show("Не удалось открыть заказы.");
            }
        }
        /// <summary>
        /// Отображение всех заказов.
        /// </summary>
        private void toolStripMenuItemOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Warehouse)TreeView1.Nodes[0]).Orders is null)
                {
                    ((Warehouse)TreeView1.Nodes[0]).Orders = new List<(string CastomerName, Order Order)>();
                }
                List<Order> orders = new List<Order>();
                for (int i = 0; i < ((Warehouse)TreeView1.Nodes[0]).Orders.Count; i++)
                {
                    orders.Add(((Warehouse)TreeView1.Nodes[0]).Orders[i].Order);
                }
                var form = new AllOrdersForm(orders);
                form.Show();
                this.Enabled = false;
                form.FormClosed += (object x, FormClosedEventArgs e) => {
                    this.Enabled = true;
                };

            }
            catch//(Exception ex)
            {
                MessageBox.Show("Не удалось открыть заказы.");//+ex.Message);
            }
        }
    }
}
