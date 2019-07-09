using AppManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public class ProductSale : BaseEntity
    {
        public ProductSale()
        {

        }
        public long ProductId { get; set; }

        public long ColorId { get; set; }

        public long SizeId { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public ProductSale(int price, long productId, long colorId, long sizeId, int quantity)
        {
            ProductId = productId;
            ColorId = colorId;
            SizeId = sizeId;
            Price = price;
            Quantity = quantity;
        }
    }
}
