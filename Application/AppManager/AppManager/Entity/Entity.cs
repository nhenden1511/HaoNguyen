using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Entity
{
    public abstract class BaseEntity
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }

        public bool IsDelete { get; set; }

        public virtual BaseEntity Copy()
        {
            return (BaseEntity)MemberwiseClone();
        }
    }
}
