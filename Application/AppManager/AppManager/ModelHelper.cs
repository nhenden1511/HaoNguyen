using AppManager.Entity;
using AppManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager
{
    public static class ModelHelper
    {
        public static Device CurrentDevice { get; set; }

        public static void UpdateDevice()
        {
            DeviceRepository.Instance.Update(CurrentDevice);
        }

        public static void InputMoney(long money, string text = "")
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                DeviceExpense item = new DeviceExpense()
                {
                    Money = money,
                    Name = text,
                    Type = Constant.Expense.Input,
                    ExpenseType = ExpenseType.Product,
                    DateTime = DateTime.Now,
                    BeforMoney = CurrentDevice.Money,
                };
                DeviceExpenseRepository.Instance.Insert(item);
            }

            CurrentDevice.Money += money;
            UpdateDevice();
        }

        public static void OutputMoney(long money, string text = "")
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                DeviceExpense item = new DeviceExpense()
                {
                    Money = money,
                    Name = text,
                    ExpenseType = ExpenseType.Product,
                    Type = Constant.Expense.Output,
                    DateTime = DateTime.Now,
                    BeforMoney = CurrentDevice.Money,
                };
                DeviceExpenseRepository.Instance.Insert(item);
            }
            CurrentDevice.Money -= money;
            UpdateDevice();
        }
    }
}
