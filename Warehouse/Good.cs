using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Warehouse
{
    [Serializable]
    /// <summary>
    /// Класс товара.
    /// </summary>
    public class Good
    {

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Артикул.
        /// </summary>
        public string Code { get; private set; }
        private double price;

        /// <summary>
        /// Цена.
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
            set
            {

                price = Math.Abs(value);
            }
        }
        /// <summary>
        /// Остаток.
        /// </summary>
        public uint Count { get; set; }
        /// <summary>
        /// Солличество товара в корзине.
        /// </summary>
        private uint chousenCount;
        public uint ChousenCount
        {
            get
            {
                return chousenCount;
            }
            set
            {
                if (value > Count)
                {
                    chousenCount = Count;
                    return;
                }
                else
                {
                    chousenCount = value;
                }
            }
        }
        public Good(string name, string code, double price, int count)
        {
            Price = price;
            Name = name;
            Code = code;
            Count = (uint)count;
            ChousenCount = 0;
        }
        // Переопределение операторов == и != для Good
        public static bool operator ==(Good a, Good b)
        {
            return a.Name == b.Name && a.Code == b.Code && a.Price == b.Price && a.Count == b.Count;
        }
        public static bool operator !=(Good a, Good b)
        {
            return !(a == b);
        }
        public Good()
        {

        }


    }
}
