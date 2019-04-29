using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class ProductPropertiesRepository : BaseRepository<ProductProperties>
    {
        static readonly Lazy<ProductPropertiesRepository> _instance = new Lazy<ProductPropertiesRepository>();

        public static ProductPropertiesRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
