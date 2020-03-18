using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public class Device : BaseEntity
    {
        public Device()
        {

        }
        public string Name { get; set; }

        public bool IsMasterDevice { get; set; }

        public long Money { get; set; }
    }
}
