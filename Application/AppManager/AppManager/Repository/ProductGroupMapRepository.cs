using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class ProductGroupMapRepository : BaseRepository<ProductGroupMap>
    {
        static readonly Lazy<ProductGroupMapRepository> _instance = new Lazy<ProductGroupMapRepository>();

        public static ProductGroupMapRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<ProductGroupMap> GetAllGroupMap(long groupId)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Table<ProductGroupMap>().Where(p=>p.ProductGroupId == groupId).ToList();
                }
            }
        }

        public List<long> GetAllGroupMapPropertiesId(long groupId)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    return db.Table<ProductGroupMap>().Where(p => p.ProductGroupId == groupId && !p.IsDelete).Select(p=>p.ProductPropertiesId).ToList();
                }
            }
        }

        public void UpdateStatus(long groupId, long propId, bool status)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var entity = db.Table<ProductGroupMap>().Where(p => p.ProductGroupId == groupId && p.ProductPropertiesId == propId).FirstOrDefault();
                    if (entity != null)
                    {
                        entity.IsDelete = !status;
                        Update(entity);
                    }
                    else
                    {
                        entity = new ProductGroupMap(groupId, propId);
                        Insert(entity);
                    }
                }
            }
        }
    }
}
