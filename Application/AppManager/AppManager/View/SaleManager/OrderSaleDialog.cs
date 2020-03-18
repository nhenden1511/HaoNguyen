using AppManager.Entity;
using AppManager.Repository;
using AppManager.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AppManager.Model;
using System.Windows.Forms;
using IProduct = AppManager.Entity.Product;
using static AppManager.Constant;

namespace AppManager.View.SaleManager
{
    public partial class OrderSaleDialog : Form
    {
        List<ProductProperties> _allColors;
        List<ProductProperties> _allSizes;
        List<ProductProperties> _currentListColor;

        static IProduct _currentProduct;
        IList<IProduct> _currentListProduct;
        IList<InputProductModel> _currentListProductModel;
        InputProductModel _currentProductModel;

        static ProductGroup _currentProductGroup;
        IList<ProductGroup> _currentListGroups;

        List<ItemSaleModel> _currentListItemSaleModels;
        ItemSaleModel _currentItemSaleModel;

        OrderType _orderType;
        OrderStatus _orderStatus;

        public OrderSaleDialog(long orderId = 0, OrderType orderType = OrderType.Shop, OrderStatus orderStatus = OrderStatus.Done)
        {
            InitializeComponent();
            _orderType = orderType;
            _orderStatus = orderStatus;

            var props = ProductPropertiesRepository.Instance.GetAll();
            _allColors = props.Where(p => p.Type == ProductType.Color).ToList();
            _allSizes = props.Where(p => p.Type == ProductType.Size).ToList();

            _currentListGroups = _cbbGroup.LoadGroupToCBB();
            if (_currentListGroups != null)
            {
                _currentProductGroup = _currentListGroups.FirstOrDefault();
                LoadProductByGroup();
                LoadListProduct(_currentProduct);
            }
            _txtQuantityInput.Text = "1";
            _currentListItemSaleModels = new List<ItemSaleModel>();
            _txtShip.Text = "0.000";
            _txtDiscountAll.Text = "0.000";

            if (orderId != 0)
            {
                _txtFinish.Enabled = false;
                var order = OrderSaleRepository.Instance.GetById(orderId);
                var itemSales = ItemSaleRepository.Instance.GetByOrderId(orderId);

                foreach (var item in itemSales)
                {
                    _currentListItemSaleModels.Add(new ItemSaleModel()
                    {
                        Id = Identify.Id,
                        ColorId = item.ColorId,
                        ColorName = item.ColorName,
                        ProductName = item.ProductName,
                        ProductSaleId = item.ProductSaleId,
                        SizeId = item.SizeId,
                        SizeName = item.SizeName,
                        Discount = item.Discount.ToCurrency(),
                        Quantity = item.Quantity,
                        SellPrice = item.Price.ToCurrency(),
                        TotalPrice = (item.Price*item.Quantity - item.Discount).ToCurrency(),
                    });
                }

                BindingList<ItemSaleModel> dataSource = new BindingList<ItemSaleModel>(_currentListItemSaleModels);
                _gridItemSale.DataSource = dataSource;

                _txtTotalPrice.Text = order.Total.ToCurrency();
                _txtShip.Text = order.Ship.ToCurrency();
                _txtDiscountAll.Text = order.Discount.ToCurrency();
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
                _currentListProduct = ProductRepository.Instance.GetProductsByGroup(_currentProductGroup.Id);
                _cbbProduct.LoadProductToCBB(_currentListProduct);

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
                var colorSizeMap = GroupPropertiesMapRepository.Instance.GetAllGroupMapPropertiesId(_currentProduct != null ? _currentProduct.GroupId : 0);

                _currentListColor = _allColors.Where(p => colorSizeMap.Contains(p.Id)).ToList();
                _cbbColor.Items.Clear();
                if (_currentListColor.Count > 0)
                {
                    foreach (var item in _currentListColor)
                    {
                        _cbbColor.Items.Add(item.Name);
                    }
                    _cbbColor.SelectedIndex = 0;
                }
            }
        }

        private void _cbbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb = sender as System.Windows.Forms.ComboBox;
            if (_currentListProduct != null && cbb.SelectedIndex < _currentListProduct.Count)
            {
                _currentProduct = _currentListProduct.ElementAtOrDefault(cbb.SelectedIndex);
                LoadListProduct(_currentProduct);
            };
        }

        void LoadListProduct(IProduct product, ProductProperties color = null)
        {
            if (product == null) return;
            List<ProductSale> products;
            if (color == null)
                products = ProductSaleRepository.Instance.GetSellProduct(product.Id);
            else
                products = ProductSaleRepository.Instance.GetSellProduct(product.Id, color.Id);

            _currentListProductModel = new List<InputProductModel>();

            foreach (var item in products)
            {
                _currentListProductModel.Add(new InputProductModel()
                {
                    Id = item.Id,
                    ProductName = product.Name,
                    Quantity = item.Quantity,
                    ItemPrice = product.Price.ToCurrency(),
                    InputPrice = item.Price,
                    ColorName = color != null ? color.Name : _allColors.Where(p => p.Id == item.ColorId).FirstOrDefault()?.Name,
                    ColorId = color != null ? color.Id : _allColors.Where(p => p.Id == item.ColorId).FirstOrDefault().Id,
                    SizeName = _allSizes.Where(p => p.Id == item.SizeId).FirstOrDefault().Name,
                    SizeId = _allSizes.Where(p => p.Id == item.SizeId).FirstOrDefault().Id,
                });
            }

            BindingList<InputProductModel> dataSource = new BindingList<InputProductModel>(_currentListProductModel);
            _gridProduct.DataSource = dataSource;
        }

        private void _cbbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb = sender as System.Windows.Forms.ComboBox;
            if (_currentListColor != null && cbb.SelectedIndex < _currentListColor.Count)
            {
                var color = _currentListColor.ElementAtOrDefault(cbb.SelectedIndex);
                LoadListProduct(_currentProduct, color);
            };
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (_currentProductModel == null) return;
            _currentListItemSaleModels.Add(new ItemSaleModel()
            {
                Id = Identify.Id,
                ColorId = _currentProductModel.ColorId,
                ColorName = _currentProductModel.ColorName,
                ProductName = _currentProductModel.ProductName,
                ProductSaleId = _currentProductModel.Id,
                SizeId = _currentProductModel.SizeId,
                SizeName = _currentProductModel.SizeName,
                Discount = "0.000",
                Quantity = _txtQuantityInput.Text.ToPrice(),
                SellPrice = _currentProductModel.ItemPrice,
                InputPrice = _currentProductModel.InputPrice,
                TotalPrice = (_currentProductModel.ItemPrice.ToPrice() * _txtQuantityInput.Text.ToPrice()).ToCurrency(),
            });
            BindingList<ItemSaleModel> dataSource = new BindingList<ItemSaleModel>(_currentListItemSaleModels);
            _gridItemSale.DataSource = dataSource;
            UpdateForm();
        }

        private void _txtQuantityInbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _txtQuantityInput.SetNumber(sender, e);
        }

        private void _txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            _txtQuantity.SetNumber(sender, e);
        }

        void UpdateForm()
        {
            var total = _currentListItemSaleModels.Sum(p => p.TotalPrice.ToPrice());
            _txtTotalPrice.Text = (total - _txtDiscountAll.Text.ToPrice() + _txtShip.Text.ToPrice()).ToCurrency();
        }

        void UpdateItemSelect()
        {
            _txtTotalItem.Text = (_txtQuantity.ToNumber() * _txtPrice.ToPrice() - _txtDiscount.ToPrice()).ToCurrency();
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {
            _currentItemSaleModel.Quantity = _txtQuantity.ToPrice();
            _currentItemSaleModel.Discount = _txtDiscount.Text;
            _currentItemSaleModel.SellPrice = _txtPrice.Text;
            _currentItemSaleModel.TotalPrice = _txtTotalItem.Text;
            BindingList<ItemSaleModel> dataSource = new BindingList<ItemSaleModel>(_currentListItemSaleModels);
            _gridItemSale.DataSource = dataSource;
            UpdateForm();
        }


        private void _txtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateItemSelect();
        }

        private void _txtPrice_TextChanged(object sender, EventArgs e)
        {
            _txtPrice.ToCurrency();
            UpdateItemSelect();
        }

        private void _txtDiscount_TextChanged(object sender, EventArgs e)
        {
            _txtDiscount.ToCurrency();
            UpdateItemSelect();
        }

        private void _txtPrice_Enter(object sender, EventArgs e)
        {
            _txtPrice.Select(_txtPrice.Text.Length - 4, 0);
        }

        private void _txtDiscount_Enter(object sender, EventArgs e)
        {
            _txtDiscount.Select(_txtDiscount.Text.Length - 4, 0);
        }

        private void _txtPrice_Click(object sender, EventArgs e)
        {
            _txtPrice.Select(_txtPrice.Text.Length - 4, 0);
        }

        private void _txtDiscount_Click(object sender, EventArgs e)
        {
            _txtDiscount.Select(_txtDiscount.Text.Length - 4, 0);
        }

        private void _txtDiscountAll_TextChanged(object sender, EventArgs e)
        {
            _txtDiscountAll.ToCurrency();
            UpdateForm();
        }

        private void _txtShip_TextChanged(object sender, EventArgs e)
        {
            _txtShip.ToCurrency();
            UpdateForm();
        }

        private void _txtShip_Enter(object sender, EventArgs e)
        {
            _txtShip.Select(_txtShip.Text.Length - 4, 0);
        }

        private void _txtShip_Click(object sender, EventArgs e)
        {
            _txtShip.Select(_txtShip.Text.Length - 4, 0);
        }

        private void _txtDiscountAll_Click(object sender, EventArgs e)
        {
            _txtDiscountAll.Select(_txtDiscountAll.Text.Length - 4, 0);
        }

        private void _txtDiscountAll_Enter(object sender, EventArgs e)
        {
            _txtDiscountAll.Select(_txtDiscountAll.Text.Length - 4, 0);
        }

        private void _txtFinish_Click(object sender, EventArgs e)
        {
            var order = new OrderSale()
            {
                Date = DateTime.Now,
                Discount = _txtDiscountAll.ToPrice(),
                Note = _txtNote.Text,
                Ship = _txtShip.ToPrice(),
                Total = _txtTotalPrice.ToPrice(),
                OrderStatus = _orderStatus,
                OrderType = _orderType,
            };
            OrderSaleRepository.Instance.Insert(order);

            int profit = 0;
            List<ItemSale> itemSales = new List<ItemSale>();
            string name = "";
            foreach (var item in _currentListItemSaleModels)
            {
                itemSales.Add(new ItemSale()
                {
                    OrderSaleId = order.Id,
                    ProductSaleId = item.ProductSaleId,
                    ColorId = item.ColorId,
                    ColorName = item.ColorName,
                    Discount = item.Discount.ToPrice(),
                    Price = item.SellPrice.ToPrice(),
                    ProductName = item.ProductName,
                    Quantity = item.Quantity,
                    SizeId = item.SizeId,
                    SizeName = item.SizeName,
                });
                name += " " + item.ProductName;
                profit += (item.TotalPrice.ToPrice() - (item.InputPrice*item.Quantity));
                var productSale = ProductSaleRepository.Instance.GetById(item.ProductSaleId);
                productSale.Quantity -= item.Quantity;
                ProductSaleRepository.Instance.Update(productSale);
            }
            ItemSaleRepository.Instance.InsertAll(itemSales);
            order.Profit = profit - _txtDiscountAll.ToPrice();
            OrderSaleRepository.Instance.Update(order);
            ModelHelper.InputMoney(order.Total, name);
            Close();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentItemSaleModel != null)
                _currentListItemSaleModels.Remove(_currentItemSaleModel);
            BindingList<ItemSaleModel> dataSource = new BindingList<ItemSaleModel>(_currentListItemSaleModels);
            _gridItemSale.DataSource = dataSource;
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            var productSaleId = _gridProduct.GetIdFocus();
            _currentProductModel = _currentListProductModel.Where(p => p.Id == productSaleId).FirstOrDefault();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            var itemSaleId = _gridItemSale.GetIdFocus();
            _currentItemSaleModel = _currentListItemSaleModels.Where(p => p.Id == itemSaleId).FirstOrDefault();
            _txtProductName.Text = _currentItemSaleModel?.ProductName;
            _txtQuantity.Text = _currentItemSaleModel?.Quantity.ToString();
            _txtPrice.Text = _currentItemSaleModel?.SellPrice;
            _txtDiscount.Text = _currentItemSaleModel?.Discount;
            _txtColor.Text = _currentItemSaleModel?.ColorName;
            _txtSize.Text = _currentItemSaleModel?.SizeName;
            _txtTotalItem.Text = _currentItemSaleModel?.TotalPrice;
        }
    }
}
