using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppManager.Constant;

namespace AppManager.Entity
{
    public enum ExpenseType
    {
        None,
        Product,
    }

    public class DeviceExpense : BaseEntity
    {
        public string Name { get; set; }

        public Expense Type { get; set; }

        public ExpenseType ExpenseType { get; set; }

        public long Money { get; set; }

        public long BeforMoney { get; set; }

        public DateTime DateTime { get; set; }
    }
}
