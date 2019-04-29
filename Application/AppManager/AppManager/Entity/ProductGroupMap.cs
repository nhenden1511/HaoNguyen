using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public class ProductGroupMap : BaseEntity
    {
        public ProductGroupMap()
        {

        }
        public long ProductGroupId { get; set; }
        public long ProductPropertiesId { get; set; }

        public ProductGroupMap(long groupId, long prop)
        {
            ProductGroupId = groupId;
            ProductPropertiesId = prop;
        }
    }
}
