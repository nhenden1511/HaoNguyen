using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public class ProductGroup : BaseEntity
    {
        public ProductGroup()
        {

        }
        [Unique]
        public string Name { get; set; }
        [Unique]
        public string GroupCode { get; set; }
        public string Image { get; set; }
        public ProductGroup(string name, string code)
        {
            Name = name;
            GroupCode = code;
        }
    }
}
