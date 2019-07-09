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
        public int Price { get; set; }
        public long GroupId { get; set; }

        public Product(long groupId, string name, int price)
        {
            GroupId = groupId;
            Name = name;
            Price = price;
            ProductCode = Identify.Id;
        }
    }
}
