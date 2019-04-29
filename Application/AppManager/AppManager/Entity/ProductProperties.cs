using AppManager.Util;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppManager.Util.Utils;

namespace AppManager.Entity
{
    public class ProductProperties : BaseEntity
    {
        public ProductProperties()
        {

        }
        [Unique]
        public string Name { get; set; }

        public ProductType Type { get; set; }

        public ProductProperties(string name, ProductType type)
        {
            Name = name;
            Type = type;
        }
    }
}
