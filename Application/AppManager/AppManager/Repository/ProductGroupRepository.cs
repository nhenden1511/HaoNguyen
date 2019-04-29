using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class ProductGroupRepository : BaseRepository<ProductGroup>
    {
        static readonly Lazy<ProductGroupRepository> _instance = new Lazy<ProductGroupRepository>();

        public static ProductGroupRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<ProductGroup> GetFullProductGroup()
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<ProductGroup>().ToList();
                    return result;
                }
            }
        }

    }
}
