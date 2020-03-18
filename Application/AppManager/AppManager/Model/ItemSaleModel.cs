using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Model
{
    public class ItemSaleModel
    {
        public long Id { get; set; }

        public long ProductSaleId { get; set; }
        public string ProductName { get; set; }

        public long ColorId { get; set; }
        public string ColorName { get; set; }

        public long SizeId { get; set; }
        public string SizeName { get; set; }

        public int Quantity { get; set; }

        public string SellPrice { get; set; }

        public string TotalPrice { get; set; }

        public string Discount { get; set; }

        public int InputPrice { get; set; }

        //public ViewItemModel(long id, string name, bool selected)
        //{
        //    Id = id;
        //    Name = name;
        //    Selected = selected;
        //}
    }
}
