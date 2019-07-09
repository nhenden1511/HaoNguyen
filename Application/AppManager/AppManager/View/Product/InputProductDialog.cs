using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using AppManager.Repository;
using AppManager.Entity;
using AppManager.Util;

namespace AppManager.View.Product
{
    public partial class InputProductDialog : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public InputProductDialog()
        {
            InitializeComponent();
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
            LoadOrder();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            _gvOrder.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dialog = new InputOrderDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.Yes)
            {
                LoadOrder();
            }
        }

        void LoadOrder()
        {
            var orders = OrderInputTotalRepository.Instance.GetAll();
            BindingList<OrderInputTotal> dataSource = new BindingList<OrderInputTotal>(orders);
            _gvOrder.DataSource = dataSource;
            bsiRecordsCount.Caption = "Total Groups : " + dataSource.Count;
        }

        private void _btnCheckOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dialog = new CheckAllProduct();
            dialog.Show();
        }

        private void _gvOrder_DoubleClick(object sender, EventArgs e)
        {
            var orderId = _gvOrder.GetIdFocus();
            var dialog = new InputOrderDialog(orderId);
            DialogResult result = dialog.ShowDialog();
        }
    }
}