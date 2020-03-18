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
using IProduct = AppManager.Entity.Product;

namespace AppManager.View.Product
{
    public partial class CheckAllProduct : Form
    {
        List<ProductProperties> _allColors;
        List<ProductProperties> _allSizes;
        IList<ProductGroup> _groups;
        ProductGroup _currentProductGroup;
        IList<IProduct> _products;

        bool _isCheckAll = true;

        public CheckAllProduct()
        {
            InitializeComponent();
            _groups = _cbbGroup.LoadGroupToCBB();

            var props = ProductPropertiesRepository.Instance.GetAll();
            _allColors = props.Where(p => p.Type == ProductType.Color).ToList();
            _allSizes = props.Where(p => p.Type == ProductType.Size).ToList();
            _cbAll.Checked = true;
            LoadProduct();
        }

        private void _cbAll_CheckedChanged(object sender, EventArgs e)
        {
            _isCheckAll = _cbAll.Checked;
            if (_isCheckAll)
                _cbGroup.Checked = false;
            LoadProduct();
        }

        void LoadProduct(long productId = 0)
        {
            List<InputProductModel> models = new List<InputProductModel>();
            IList<ProductSale> products;
            if (!_isCheckAll && _currentProductGroup != null)
            {
                if (productId == 0)
                    products = ProductSaleRepository.Instance.GetByGroupId(_currentProductGroup.Id);
                else
                    products = ProductSaleRepository.Instance.GetSellProduct(productId);
            }
            else
                products = ProductSaleRepository.Instance.GetAll().Where(p => p.Quantity > 0).ToList(); ;

            int total = 0;
            int sum = 0;
            foreach (var item in products)
            {
                var product = ProductRepository.Instance.GetById(item.ProductId);
                models.Add(new InputProductModel()
                {
                    GroupName = _groups.Where(p => p.Id == product.GroupId).FirstOrDefault().Name,
                    ProductName = product.Name,
                    ItemPrice = item.Price.ToCurrency(),
                    Quantity = item.Quantity,
                    TotalPrice = (item.Price * item.Quantity).ToCurrency(),
                    SizeName = _allSizes.Where(p => p.Id == item.SizeId).FirstOrDefault().Name,
                    ColorName = _allColors.Where(p => p.Id == item.ColorId).FirstOrDefault().Name,
                });
                total += item.Quantity * item.Price;
                sum += item.Quantity;
            }
            _txtTotal.Text = total.ToCurrency();
            _txtQuantity.Text = sum.ToString();

            BindingList<InputProductModel> dataSource = new BindingList<InputProductModel>(models);
            _gridProduct.DataSource = dataSource;
        }

        private void _cbGroup_CheckedChanged(object sender, EventArgs e)
        {
            _isCheckAll = !_cbGroup.Checked;
            if (!_isCheckAll)
                _cbAll.Checked = false;
            LoadProduct();
        }

        private void _cbbGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var cbb = sender as System.Windows.Forms.ComboBox;
            if (_groups != null)
            {
                _currentProductGroup = _groups.ElementAtOrDefault(cbb.SelectedIndex);
                LoadProduct();
                _products = ProductRepository.Instance.GetProductsByGroup(_currentProductGroup.Id);
                if(_currentProductGroup != null)
                {
                    _products = _cbbProduct.LoadProductToCBB(_currentProductGroup.Id);
                }
            }
        }

        private void _cbbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb = sender as System.Windows.Forms.ComboBox;
            if (_products != null)
            {
                var product = _products.ElementAtOrDefault(cbb.SelectedIndex);
                LoadProduct(product.Id);
            }
        }
    }
}
