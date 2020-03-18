using AppManager.Context;
using AppManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public class DeviceExpenseRepository : BaseRepository<DeviceExpense>
    {
        static readonly Lazy<DeviceExpenseRepository> _instance = new Lazy<DeviceExpenseRepository>();

        public static DeviceExpenseRepository Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        //public Device GetMasterDevice()
        //{
        //    lock (DbInitialization.Lockdb)
        //    {
        //        using (var db = NewConnection())
        //        {
        //            var result = db.Table<Device>().FirstOrDefault();
        //            if(result == null)
        //            {
        //                result = new Device() { Id = 200, IsMasterDevice = true, Name = "HaoNguyenDevice" };
        //                Insert(result);
        //            }
        //            return result;
        //        }
        //    }
        //}
    }
}
