using AppManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppManager.Constant;

namespace AppManager.Entity
{
    public class OrderSale : BaseEntity
    {
        public int Total { get; set; }

        public int Discount { get; set; }

        public int Ship { get; set; }

        public int Profit { get; set; }

        public DateTime Date { get; set; }

        public string Note { get; set; }

        public OrderType OrderType { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}
