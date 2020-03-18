using AppManager.Model;
using AppManager.Repository;
using AppManager.Util;
using AppManager.View.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppManager.View.SaleManager
{
    public partial class CheckOrderDialog : Form
    {
        public CheckOrderDialog()
        {
            InitializeComponent();
            var orderSales = OrderSaleRepository.Instance.GetAll();

            List<OrderSaleModel> models = new List<OrderSaleModel>();
            foreach (var item in orderSales)
            {
                models.Add(new OrderSaleModel
                {
                    Id = item.Id,
                    Date = item.Date.ToString("dd-MM-yyyy"),
                    Profit = item.Profit.ToCurrency(),
                    Discount = item.Discount.ToCurrency(),
                    Note = item.Note,
                    OrderStatus = item.OrderStatus,
                    Ship = item.Ship.ToCurrency(),
                    OrderType = item.OrderType,
                    Total = item.Total.ToCurrency(),
                });
            }

            BindingList<OrderSaleModel> dataSource = new BindingList<OrderSaleModel>(models);
            _gridCheckOrder.DataSource = dataSource;
        }

        private void _gridCheckOrder_DoubleClick(object sender, EventArgs e)
        {
            var orderId = _gridCheckOrder.GetIdFocus();
            var dialog = new OrderSaleDialog(orderId);
            DialogResult result = dialog.ShowDialog();
        }
    }
}
