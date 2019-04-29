using AppManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public class Product : BaseEntity
    {
        public Product()
        {

        }
        public string Name { get; set; }
        public long ProductCode { get; set; }
        public string Image { get; set; }
        public uint Price { get; set; }
        public uint OrderPrice { get; set; }
        public int GroupId { get; set; }

        public Product(int groupId, string name, uint price, uint orderPrice = 0)
        {
            GroupId = groupId;
            Name = name;
            Price = price;
            ProductCode = Identify.Id;
            OrderPrice = orderPrice != 0 ? orderPrice : price;
        }
    }
}
