using AppManager.Context;
using AppManager.Entity;
using AppManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class OrderInputItemRepository : BaseRepository<OrderInputItem>
    {
        static readonly Lazy<OrderInputItemRepository> _instance = new Lazy<OrderInputItemRepository>();

        public static OrderInputItemRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public List<OrderInputItem> GetByOrderId(long orderId)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    var result = db.Table<OrderInputItem>().Where(p => p.OrderInputId == orderId);
                    return result.ToList();
                }
            }
        }


        public int AddListOrder(IList<OrderInputItem> entities)
        {
            lock (DbInitialization.Lockdb)
            {
                using (var db = NewConnection())
                {
                    InsertAll(entities);
                    foreach (var item in entities)
                    {
                        var product = ProductSaleRepository.Instance.GetByProduct(item.ProductId, item.ColorId, item.SizeId, item.Price);
                        if (product != null)
                        {
                            product.Quantity += item.Quantity;
                            ProductSaleRepository.Instance.Update(product);
                        }
                        else
                        {
                            var newProduct = new ProductSale()
                            {
                                ProductId = item.ProductId,
                                ColorId = item.ColorId,
                                SizeId = item.SizeId,
                                Price = item.Price,
                                Quantity = item.Quantity,
                            };
                            ProductSaleRepository.Instance.Insert(newProduct);
                        }
                    }
                    return 1;
                }
            }
        }
    }
}
