using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class ProductSaleRepository : BaseRepository<ProductSale>
    {
        static readonly Lazy<ProductSaleRepository> _instance = new Lazy<ProductSaleRepository>();

        public static ProductSaleRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public ProductSale GetByProduct(long productId, long colorId, long sizeId, long price)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<ProductSale>().Where(p => p.ProductId == productId && p.ColorId == colorId
                                                    && p.SizeId == sizeId && p.Price == price).FirstOrDefault();
                    return result;
                }
            }
        }


        public List<ProductSale> GetByGroupId(long groupId)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var productIds = db.Table<Product>().Where(p => p.GroupId == groupId).Select(p => p.Id).ToList();
                    var result = db.Table<ProductSale>().Where(p => productIds.Contains(p.ProductId) && p.Quantity > 0);
                    return result.ToList();
                }
            }
        }
    }
}
