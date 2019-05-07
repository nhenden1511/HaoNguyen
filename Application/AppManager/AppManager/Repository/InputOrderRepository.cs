using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class InputOrderRepository : BaseRepository<InputOrder>
    {
        static readonly Lazy<InputOrderRepository> _instance = new Lazy<InputOrderRepository>();

        public static InputOrderRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
