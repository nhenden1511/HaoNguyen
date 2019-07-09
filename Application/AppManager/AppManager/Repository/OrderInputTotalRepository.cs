using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class OrderInputTotalRepository : BaseRepository<OrderInputTotal>
    {
        static readonly Lazy<OrderInputTotalRepository> _instance = new Lazy<OrderInputTotalRepository>();

        public static OrderInputTotalRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
