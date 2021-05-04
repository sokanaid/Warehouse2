using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    [Serializable]
    /// <summary>
    /// Класс категории товаров.
    /// </summary>
    public class Category : Warehouse
    {
        public Category() 
        {

        }
        public Category(string name,int sortCode) : base(name,sortCode)
        {
        }
        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Good> Goods = new List<Good>();
    }
}
