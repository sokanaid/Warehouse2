using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    [Serializable]
    public class Order
    {
        public string Status { get; set; }
        public int Code { get; private set; }
        public Order(string status,int code)
        {
            Status = status;
            Code = code;
        }
    }
}
