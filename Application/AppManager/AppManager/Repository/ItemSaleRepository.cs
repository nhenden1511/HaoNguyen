using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class ItemSaleRepository : BaseRepository<ItemSale>
    {
        static readonly Lazy<ItemSaleRepository> _instance = new Lazy<ItemSaleRepository>();

        public static ItemSaleRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<ItemSale> GetByOrderId(long orderId)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<ItemSale>().Where(p => p.OrderSaleId == orderId);
                    return result.ToList();
                }
            }
        }
    }
}
