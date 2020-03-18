using AppManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public class ItemSale : BaseEntity
    {
        public long OrderSaleId { get; set; }

        public long ProductSaleId { get; set; }

        public string ProductName { get; set; }

        public long ColorId { get; set; }

        public long SizeId { get; set; }

        public string ColorName { get; set; }

        public string SizeName { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set;}

        public int Discount { get; set; }
    }
}
