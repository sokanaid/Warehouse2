using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    [Serializable]
    /// <summary>
    /// Класс для сериализации.
    /// </summary>
    class SerialiseClass
    {
        public void SeriliseClass()
        {

        }

        //  Рекурсивное сохранение данных из дерева.
        public int SortCode { get; set; }
        readonly String Name;
        public List<SerialiseClass> Categories= new List<SerialiseClass>();
        public List<Good> Goods = new List<Good>();
        public List<(string CastomerName, Order Order)> Orders ;
        /// <summary>
        /// Сохранение данных.
        /// </summary>
        /// <param name="category">Склад</param>
        public SerialiseClass(Warehouse warehouse)
        {
            Name = warehouse.Text;
            SortCode = warehouse.SortCode;
            Orders = warehouse.Orders;
            foreach(var i in warehouse.Catigories)
            {
                Categories.Add(new SerialiseClass(i.Value));
            }
        }
        /// <summary>
        /// Сохранение данных.
        /// </summary>
        /// <param name="category">Категория</param>
        private SerialiseClass(Category category)
        {
            SortCode = category.SortCode;
            Name = category.Text;
            foreach (var i in category.Catigories)
            {
                Categories.Add(new SerialiseClass(i.Value));
            }
            foreach(var i in category.Goods)
            {
                Goods.Add(i);
            }
        }
        // Рекурсивная десереализация данных.
        /// <summary>
        /// Востановление данных.
        /// </summary>
        /// <param name="category">Склад</param>
        public Warehouse ReturnWarehouse()
        {
            Warehouse warehouse= new Warehouse(Name,SortCode);
            foreach(var i in Categories)
            {
                Category category = ReturnCategory(i);
                warehouse.Catigories[category.Name] = category;
                warehouse.Nodes.Add(category);
                warehouse.Orders = Orders;
            }
            return warehouse;
        }
        /// <summary>
        /// Востановление данных.
        /// </summary>
        /// <param name="category">Категория.</param>
        private Category ReturnCategory(SerialiseClass categoryS)
        {
            Category category = new Category(categoryS.Name,categoryS.SortCode);
            foreach (var i in categoryS.Categories)
            {
                Category newCategory = ReturnCategory(i);
                category.Catigories[newCategory.Name] = newCategory;
                category.Nodes.Add(newCategory);
            }
            foreach(var i in categoryS.Goods)
            {
                category.Goods.Add(i);
            }
            return category;
        }
    }
}
