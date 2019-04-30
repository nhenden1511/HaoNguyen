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
using AppManager.Entity;
using AppManager.Repository;
using DevExpress.XtraEditors.Controls;
using System.Collections.ObjectModel;
using IProduct = AppManager.Entity.Product;

namespace AppManager.View.Product
{
    public partial class AddProduct : DevExpress.XtraEditors.XtraForm
    {
        ProductGroup _currentProductGroup;
        IList<ProductGroup> _groups;
        public AddProduct(ProductGroup productGroup)
        {
            InitializeComponent();

            _groups = ProductGroupRepository.Instance.GetAll();
            _currentProductGroup = _groups.Where(p=>p.Id == productGroup.Id).FirstOrDefault();

            foreach (var item in _groups)
            {
                _cbbGroup.Items.Add(item.Name);
            }
            _cbbGroup.SelectedIndex = _groups.IndexOf(_currentProductGroup);
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_txtProductName.Text) && !string.IsNullOrWhiteSpace(_txtPrice.Text))
            {
                var name = _txtProductName.Text;
                var groupId = _currentProductGroup.Id;
                var price = int.Parse(_txtPrice.Text);
                var orderPrice = int.Parse(_txtOrderPrice.Text);
                var product = new IProduct(groupId, name, price, orderPrice);
                try
                {
                    ProductRepository.Instance.Insert(product);
                    this.Close();
                    DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    string message = ex.ToString();
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
                
            }
        }

        private void _cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
       {
            var cbb = sender as System.Windows.Forms.ComboBox;
            _currentProductGroup = _groups.ElementAtOrDefault(cbb.SelectedIndex);
        }
    }
}