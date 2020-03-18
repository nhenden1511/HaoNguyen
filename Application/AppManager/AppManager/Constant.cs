using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager
{
    public class Constant
    {
        public enum OrderType
        {
            Shop,
            Ship,
            Agency,
        }

        public enum OrderStatus
        {
            Done,
            Waiting,
            Shipping,
            Cancel,
            Return,
            Boom
        }

        public enum Expense
        {
            Output,
            Input
        }
    }
}
