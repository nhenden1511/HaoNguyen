using AppManager.Entity;
using AppManager.Model;
using AppManager.Repository;
using AppManager.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppManager.View.Product
{
    public partial class SelectItemSizeDialog : Form
    {
        IList<ProductProperties> _sizes;
        ProductProperties _size;
        InputProductModel _model;

        public SelectItemSizeDialog(InputProductModel model)
        {
            InitializeComponent();
            _model = model;
            var props = ProductPropertiesRepository.Instance.GetAll();
            _sizes = props.Where(p => p.Type == ProductType.Size).ToList();
            _txtLabel.Text = model.ProductName + " - " + model.ColorName + " - " + model.SizeName;
            _cbbSize.Items.Clear();

            if (_sizes.Count > 0)
            {
                foreach (var item in _sizes)
                {
                    _cbbSize.Items.Add(item.Name);
                }
                _cbbSize.SelectedIndex = 0;
            }
        }

        private void _btnChange_Click(object sender, EventArgs e)
        {
            var productSale = ProductSaleRepository.Instance.GetById(_model.Id);
            productSale.Quantity -= 1;
            ProductSaleRepository.Instance.Update(productSale);

            var product = ProductSaleRepository.Instance.GetByProduct(_model.ProductId, _model.ColorId, _size.Id, _model.ItemPrice.ToPrice());
            if (product != null)
            {
                product.Quantity += 1;
                ProductSaleRepository.Instance.Update(product);
            }
            else
            {
                var newProduct = new ProductSale()
                {
                    ProductId = _model.ProductId,
                    ColorId = _model.ColorId,
                    SizeId = _size.Id,
                    Price = _model.ItemPrice.ToPrice(),
                    Quantity = 1,
                };
                ProductSaleRepository.Instance.Insert(newProduct);
            }

            Close();
            DialogResult = DialogResult.Yes;
        }

        private void _cbbSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var cbb = sender as System.Windows.Forms.ComboBox;
            if (_sizes != null && cbb.SelectedIndex < _sizes.Count)
            {
                _size = _sizes.ElementAtOrDefault(cbb.SelectedIndex);
            }
        }
    }
}
