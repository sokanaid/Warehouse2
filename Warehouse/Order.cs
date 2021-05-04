using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
namespace Warehouse
{
    [Serializable]
    public class Order
    {
        public int Code { get; private set; }
        public OrderStatus Status { get; set; }
        private Client Client { get; set; }
        public DateTime Time { get; private set; }
        public Order(OrderStatus status, int code, Client client, DateTime time)
        {
            Status = status;
            Code = code;
            Client = client;
            Time = time;
        }
        /// <summary>
        /// Нажатие на кнопку оплаты.
        /// </summary>
        public void PayButton_Click()
        {
            try
            {
                if (Status.HasFlag(OrderStatus.Paid))
                {
                    MessageBox.Show("Заказ уже оплачен");
                    return;
                }
                if (!Status.HasFlag(OrderStatus.Processed))
                {
                    MessageBox.Show("Заказ еще не обработан. Дождитесь пока продавец изменит статус заказа на \"Processed\"");
                    return;
                }
                Status = Status | OrderStatus.Paid;
                MessageBox.Show("Заказ оплачен.");
            }
            catch
            {
                return;
            }
        }
    }
}
