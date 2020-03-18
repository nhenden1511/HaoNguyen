using AppManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppManager.Constant;

namespace AppManager.Model
{
    public class OrderSaleModel
    {
        public long Id { get; set; }

        public string Total { get; set; }

        public string Discount { get; set; }

        public string Ship { get; set; }

        public string Profit { get; set; }

        public string Date { get; set; }

        public string Note { get; set; }

        public OrderType OrderType { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}
