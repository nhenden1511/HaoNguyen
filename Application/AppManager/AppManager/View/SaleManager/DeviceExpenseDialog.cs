using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppManager.Entity;
using AppManager.Model;
using AppManager.Repository;
using AppManager.Util;

namespace AppManager.View.SaleManager
{
    public partial class DeviceExpenseDialog : Form
    {
        public DeviceExpenseDialog()
        {
            InitializeComponent();
            ReloadData();
        }

        void ReloadData()
        {
            _txtTotal.Text = ModelHelper.CurrentDevice.Money.ToCurrency();

            var items = DeviceExpenseRepository.Instance.GetAll();

            var models = new List<DeviceExpenseModel>();
            foreach (var item in items)
            {
                models.Add(new DeviceExpenseModel()
                {
                    DateTime = item.DateTime.ToString("dd-MM-yyyy"),
                    Money = item.Money.ToCurrency(),
                    Type = item.Type == Constant.Expense.Input ? "Nhập" : "Xuất",
                    Name = item.Name,
                    BeforMoney = item.BeforMoney.ToCurrency(),
                });
            };
            BindingList<DeviceExpenseModel> dataSource = new BindingList<DeviceExpenseModel>(models);
            _gridExpense.DataSource = dataSource;
        }

        private void _btnOutput_Click(object sender, EventArgs e)
        {
            DeviceExpense item = new DeviceExpense()
            {
                Money = _txtMoneyOutPut.ToPrice(),
                Name = _txtNoteOutPut.Text,
                Type = Constant.Expense.Output,
                DateTime = DateTime.Now,
            };

            DeviceExpenseRepository.Instance.Insert(item);
            ModelHelper.OutputMoney(item.Money);
            ReloadData();
        }

        private void _btnInput_Click(object sender, EventArgs e)
        {
            DeviceExpense item = new DeviceExpense()
            {
                Money = _txtMoneyInput.ToPrice(),
                Name = _txtNoteInput.Text,
                Type = Constant.Expense.Input,
                DateTime = DateTime.Now,
            };

            DeviceExpenseRepository.Instance.Insert(item);
            ModelHelper.InputMoney(item.Money);
            ReloadData();
        }
    }
}
