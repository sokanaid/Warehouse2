using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    /// <summary>
    /// Статусы заказа.
    /// </summary>
    [Flags]
    [Serializable]
    public enum OrderStatus
    {
        /// <summary>
        /// Обрабатывается.
        /// </summary>
        Procesing=0,
        /// <summary>
        /// Обработан.
        /// </summary>
        Processed = 1,
        /// <summary>
        /// Оплачен.
        /// </summary>
        Paid = 2,
        /// <summary>
        /// Доставлен.
        /// </summary>
        Shipped = 4,
        /// <summary>
        /// Исполнен.
        /// </summary>
        Executed = 8
    }
}
