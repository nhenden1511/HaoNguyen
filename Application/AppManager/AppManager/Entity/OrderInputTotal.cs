using AppManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public class OrderInputTotal : BaseEntity
    {
        public OrderInputTotal()
        {

        }

        public long SupplierId { get; set; }

        public string OrderName { get; set; }

        public DateTime DateTimeOrder { get; set; }

        public int TotalPrice { get; set; }

        public OrderInputTotal(long supplierId, string name, DateTime date, int price)
        {
            SupplierId = supplierId;
            OrderName = name;
            DateTimeOrder = date;
            TotalPrice = price;
        }
    }
}
