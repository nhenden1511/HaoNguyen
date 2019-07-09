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
using AppManager.Util;
using AppManager.Entity;
using IProduct = AppManager.Entity.Product;
using AppManager.Repository;
using AppManager.Model;
using System.Globalization;

namespace AppManager.View.Product
{
    public partial class InputOrderDialog : XtraForm
    {
        List<ProductProperties> _allColors;
        List<ProductProperties> _allSizes;

        static ProductGroup _currentProductGroup;
        IList<ProductGroup> _currentListGroups;

        static IProduct _currentProduct;
        IList<IProduct> _currentListProduct;
        IList<InputProductModel> _currentListModel;
        long _orderId;

        bool _isItemPrice = false;

        public InputOrderDialog(long orderId = 0)
        {
            InitializeComponent();

            var props = ProductPropertiesRepository.Instance.GetAll();
            _allColors = props.Where(p => p.Type == ProductType.Color).ToList();
            _allSizes = props.Where(p => p.Type == ProductType.Size).ToList();

            _currentListGroups = _cbbGroup.LoadGroupToCBB();

            if (_currentListGroups.Count > 0)
                _currentProductGroup = _currentListGroups.FirstOrDefault();
            LoadProductByGroup();

            if (_currentListProduct?.Count > 0)
            {
                _currentProduct = _currentListProduct.FirstOrDefault();
                LoadColorSizeByProduct();
            }

            _currentListModel = new List<InputProductModel>();
            _txtItemPrice.Text = "0.000";
            _txtTotalPrice.Text = "0.000";
            _txtSum.Text = "0.000";
            _txtSum.Enabled = false;
            _orderId = orderId;
            if(_orderId != 0)
            {
                _btnFinish.Enabled = false;
                button1.Enabled = false;
                var order = OrderInputTotalRepository.Instance.GetById(_orderId);
                _txtName.Text = order.OrderName;
                _txtSum.Text = order.TotalPrice.ToCurrency();

                var items = OrderInputItemRepository.Instance.GetByOrderId(orderId);
                foreach (var item in items)
                {
                    var product = ProductRepository.Instance.GetById(item.ProductId);
                    var newOrder = new InputProductModel()
                    {
                        GroupName = _currentListGroups.Where(p => p.Id == product.GroupId).FirstOrDefault().Name,
                        ProductId = product.Id,
                        ProductName = product.Name,
                        ColorName = _allColors.Where(p => p.Id == item.ColorId).FirstOrDefault().Name,
                        SizeName = _allSizes.Where(p => p.Id == item.SizeId).FirstOrDefault().Name,
                        Quantity = item.Quantity,
                        ItemPrice = item.Price.ToCurrency(),
                        TotalPrice = (item.Price * item.Quantity).ToCurrency(),
                    };
                    _currentListModel.Add(newOrder);
                }
                BindingList<InputProductModel> dataSource = new BindingList<InputProductModel>(_currentListModel);
                _gvOrder.DataSource = dataSource;
            }
        }

        private void _cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb = sender as System.Windows.Forms.ComboBox;
            if (_currentListGroups != null && cbb.SelectedIndex < _currentListGroups.Count)
            {
                _currentProductGroup = _currentListGroups.ElementAtOrDefault(cbb.SelectedIndex);
                LoadProductByGroup();
            }
        }

        void LoadProductByGroup()
        {
            if (_currentProductGroup != null)
            {
                _currentListProduct = _cbbProduct.LoadProductToCBB(_currentProductGroup.Id);
                if (_currentListProduct?.Count > 0)
                {
                    _currentProduct = _currentListProduct.FirstOrDefault();
                    LoadColorSizeByProduct();
                }
            }
        }

        void LoadColorSizeByProduct()
        {
            if (_currentProductGroup != null)
            {
                var colorSizeMap = GroupPropertiesMapRepository.Instance.GetAllGroupMapPropertiesId(_currentProduct.GroupId);

                var color = _allColors.Where(p => colorSizeMap.Contains(p.Id)).ToList();
                _cbbColor.Items.Clear();
                if (color.Count > 0)
                {
                    foreach (var item in color)
                    {
                        _cbbColor.Items.Add(item.Name);
                    }
                    _cbbColor.SelectedIndex = 0;
                }

                var size = _allSizes.Where(p => colorSizeMap.Contains(p.Id)).ToList();
                _cbbSize.Items.Clear();
                if (size.Count > 0)
                {
                    foreach (var item in size)
                    {
                        _cbbSize.Items.Add(item.Name);
                    }
                    _cbbSize.SelectedIndex = 0;
                }
            }
        }

        private void _cbbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentListProduct != null && _currentListProduct.Count > 0)
            {
                var cbb = sender as System.Windows.Forms.ComboBox;
                _currentProduct = _currentListProduct.ElementAtOrDefault(cbb.SelectedIndex);
                LoadColorSizeByProduct();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var color = (string)_cbbColor.SelectedItem;
            var size = (string)_cbbSize.SelectedItem;
            if (_txtItemPrice.IsNull() || _txtQuantity.IsNull() || _txtTotalPrice.IsNull()) return;
            var newOrder = new InputProductModel()
            {
                GroupId = _currentProductGroup.Id,
                GroupName = _currentProductGroup.Name,
                ProductId = _currentProduct.Id,
                ProductName = _currentProduct.Name,
                ColorId = _allColors.Where(p => p.Name.Equals(color)).FirstOrDefault().Id,
                ColorName = color,
                SizeId = _allSizes.Where(p => p.Name.Equals(size)).FirstOrDefault().Id,
                SizeName = size,
                Quantity = _txtQuantity.ToNumber(),
                ItemPrice = _txtItemPrice.ToCurrency(),
                TotalPrice = (_txtTotalPrice.ToCurrency()),
            };

            _currentListModel.Add(newOrder);
            BindingList<InputProductModel> dataSource = new BindingList<InputProductModel>(_currentListModel);
            _gvOrder.DataSource = dataSource;

            _txtItemPrice.Text = "";
            _txtQuantity.Text = "";
            _txtSum.Text = _currentListModel.Sum(p => p.TotalPrice.ToPrice()).ToCurrency();
        }

        private void _btnFinish_Click(object sender, EventArgs e)
        {
            if (!_currentListModel.Any()) return;

            var orderTotal = new OrderInputTotal(0, _txtName.Text , DateTime.Now, _currentListModel.Sum(p => p.TotalPrice.ToPrice()));
            OrderInputTotalRepository.Instance.Insert(orderTotal);

            var order = _currentListModel.ToListEntity(orderTotal.Id);
            OrderInputItemRepository.Instance.AddListOrder(order);
            Close();
            DialogResult = DialogResult.Yes;
        }

        #region display
        private void _txtItemPrice_TextChanged(object sender, EventArgs e)
        {
            _txtItemPrice.ToCurrency();
            if (_isItemPrice)
                _txtTotalPrice.ToCurrency((_txtItemPrice.ToPrice() * _txtQuantity.ToNumber()).ToString());
        }

        private void _txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            _txtTotalPrice.ToCurrency();
            if (!_isItemPrice && _txtQuantity.ToNumber()!=0)
                _txtItemPrice.ToCurrency((_txtTotalPrice.ToPrice() / _txtQuantity.ToNumber()).ToString());
        }

        private void _txtItemPrice_Enter(object sender, EventArgs e)
        {
            _isItemPrice = true;
            _txtItemPrice.Select(_txtItemPrice.Text.Length - 4, 0);
        }

        private void _txtTotalPrice_Enter(object sender, EventArgs e)
        {
            _isItemPrice = false;
            _txtTotalPrice.Select(_txtTotalPrice.Text.Length - 4, 0);
        }

        private void _txtTotalPrice_Click(object sender, EventArgs e)
        {
            _txtTotalPrice.Select(_txtTotalPrice.Text.Length - 4, 0);
        }

        private void _txtItemPrice_Click(object sender, EventArgs e)
        {
            _txtItemPrice.Select(_txtItemPrice.Text.Length - 4, 0);
        }
        #endregion
    }
}