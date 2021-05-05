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
        public Client Client;
        public DateTime Time { get; private set; }
        public string CustomerEmail { get; private set; }
        public Order(OrderStatus status, int code, Client client, DateTime time)
        {
            Status = status;
            Code = code;
            Client = client;
            Time = time;
            CustomerEmail = Client.Email;
        }
        public Order(Order oldorder):this(oldorder.Status,oldorder.Code,oldorder.Client,oldorder.Time)
        {
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
        /// <summary>
        /// Нажатие на кнопку для изменения статуса заказа.
        /// </summary>
        public void StatusButton_Click(string statusName,OrderStatus status)
        {
            try
            {
                if (Status.HasFlag(status))
                {
                    MessageBox.Show("Заказ уже "+statusName);
                    return;
                }
                Status = Status | status;
                MessageBox.Show("Заказ "+statusName);
            }
            catch
            {
                return;
            }
        }
    }
}
