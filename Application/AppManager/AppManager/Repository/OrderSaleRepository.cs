using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class OrderSaleRepository : BaseRepository<OrderSale>
    {
        static readonly Lazy<OrderSaleRepository> _instance = new Lazy<OrderSaleRepository>();

        public static OrderSaleRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
