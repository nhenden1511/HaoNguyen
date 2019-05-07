using AppManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public class InputOrder : BaseEntity
    {
        public InputOrder()
        {

        }

        public long GroupId { get; set; }
        public long ProductId { get; set; }
        public long ColorId { get; set; }
        public long SizeId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }

        public InputOrder(long gr, long pr, long col, long siz, int qua, int total)
        {
            GroupId = gr;
            ProductId = pr;
            ColorId = col;
            SizeId = siz;
            TotalPrice = total;
            Price = total / qua;
        }

    }
}
