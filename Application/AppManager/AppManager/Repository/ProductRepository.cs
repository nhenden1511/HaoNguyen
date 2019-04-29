using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class ProductRepository : BaseRepository<Product>
    {
        static readonly Lazy<ProductRepository> _instance = new Lazy<ProductRepository>();

        public static ProductRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public IList<Product> GetProductsByGroup(long groupId)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Table<Product>().Where(p => p.GroupId == groupId && !p.IsDelete).ToList();
                }
            }
        }
    }
}
