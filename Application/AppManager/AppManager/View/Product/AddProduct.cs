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
using AppManager.Util;

namespace AppManager.View.Product
{
    public partial class AddProduct : DevExpress.XtraEditors.XtraForm
    {
        ProductGroup _currentProductGroup;
        IList<ProductGroup> _groups;
        IProduct _oldProduct;
        public AddProduct(ProductGroup productGroup, IProduct product = null)
        {
            InitializeComponent();

            _groups = ProductGroupRepository.Instance.GetAll();
            _currentProductGroup = _groups.Where(p=>p.Id == productGroup.Id).FirstOrDefault();

            foreach (var item in _groups)
            {
                _cbbGroup.Items.Add(item.Name);
            }
            _cbbGroup.SelectedIndex = _groups.IndexOf(_currentProductGroup);

            _oldProduct = product;
            if (product != null)
            {
                _txtPrice.Text = product.Price.ToCurrency();
                _txtPriceProvide.Text = product.PriceProvide.ToCurrency();
                _txtProductName.Text = product.Name;
                _cbbGroup.Enabled = false;
                _btnAdd.Text = "Sửa";
            }
            else
            {
                _txtPrice.Text = "0.000";
                _txtPriceProvide.Text = "0.000";
            }
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_txtProductName.Text) && !string.IsNullOrWhiteSpace(_txtPrice.Text))
            {
                try
                {
                    if(_oldProduct == null)
                    {
                        var name = _txtProductName.Text;
                        var groupId = _currentProductGroup.Id;
                        var price = _txtPrice.Text.ToPrice();
                        var priceProvide = _txtPriceProvide.Text.ToPrice();
                        var product = new IProduct(groupId, name, price, priceProvide);
                        ProductRepository.Instance.Insert(product);
                        this.Close();
                        DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        _oldProduct.Name = _txtProductName.Text;
                        _oldProduct.Price = _txtPrice.Text.ToPrice();
                        _oldProduct.PriceProvide = _txtPriceProvide.Text.ToPrice();
                        ProductRepository.Instance.Update(_oldProduct);
                        DialogResult = DialogResult.Yes;
                    }
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

        private void _txtPrice_TextChanged_1(object sender, EventArgs e)
        {
            _txtPrice.ToCurrency();
        }

        private void _txtPrice_Enter(object sender, EventArgs e)
        {
            _txtPrice.Select(_txtPrice.Text.Length - 4, 0);
        }

        private void _txtPrice_Click(object sender, EventArgs e)
        {
            _txtPrice.Select(_txtPrice.Text.Length - 4, 0);
        }

        private void _txtPriceProvide_TextChanged(object sender, EventArgs e)
        {
            _txtPriceProvide.ToCurrency();
        }

        private void _txtPriceProvide_Enter(object sender, EventArgs e)
        {
            _txtPriceProvide.Select(_txtPrice.Text.Length - 4, 0);
        }

        private void _txtPriceProvide_Click(object sender, EventArgs e)
        {
            _txtPriceProvide.Select(_txtPrice.Text.Length - 4, 0);
        }
    }
}