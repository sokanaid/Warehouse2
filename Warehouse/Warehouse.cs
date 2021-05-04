using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    [Serializable]
    /// <summary>
    /// Класс склада.
    /// </summary>
    public class Warehouse:TreeNode, IComparable<Warehouse>, IComparer<TreeNode>
    {
        public Warehouse():base()
        {

        }
        public Warehouse(string name,int sortCode) : base(name)
        {
            SortCode = sortCode;
        }
        public List<(string CastomerName, Order Order)> Orders = new List<(string, Order)>();
        public int SortCode { get; private set; }
        /// <summary>
        /// Список категорий товаров.
        /// </summary>
        public Dictionary<string , Category> Catigories= new Dictionary<string,Category>();

        /// <summary>
        /// Переопределение сравнения по коду сортировки.
        /// </summary>
        public int CompareTo(Warehouse warehouse)
        {
            //var warehouse = obj as Warehouse;
            if (warehouse.SortCode < this.SortCode || warehouse.SortCode == this.SortCode &&
                warehouse.Text.CompareTo(this.Text) == -1) return 1;
            else return -1;
        }

        /// <summary>
        /// Сравнение узлов.
        /// </summary>
        public int Compare([AllowNull] TreeNode x, [AllowNull] TreeNode y)
        {
            return ((Warehouse)x).CompareTo((Warehouse)y);
        }
    }
}
