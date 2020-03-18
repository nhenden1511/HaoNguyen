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
    public partial class ChangeSizeDialog : Form
    {
        List<ProductProperties> _allColors;
        List<ProductProperties> _allSizes;

        IList<ProductGroup> _currentListGroups;
        static ProductGroup _currentProductGroup;

        static IProduct _currentProduct;
        IList<IProduct> _currentListProduct;

        IList<InputProductModel> _currentListProductModel;
        InputProductModel _currentProductModel;

        public ChangeSizeDialog()
        {
            InitializeComponent();

            var props = ProductPropertiesRepository.Instance.GetAll();
            _allColors = props.Where(p => p.Type == ProductType.Color).ToList();
            _allSizes = props.Where(p => p.Type == ProductType.Size).ToList();

            _currentListGroups = _cbbGroup.LoadGroupToCBB();
            if (_currentListGroups != null)
            {
                _currentProductGroup = _currentListGroups.FirstOrDefault();
                LoadProductByGroup();
                //LoadListProduct(_currentProduct);
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
                }
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

        void LoadListProduct()
        {
            if (_currentProduct == null) return;
            List<ProductSale> products;

            products = ProductSaleRepository.Instance.GetSellProduct(_currentProduct.Id);

            _currentListProductModel = new List<InputProductModel>();

            foreach (var item in products)
            {
                _currentListProductModel.Add(new InputProductModel()
                {
                    Id = item.Id,
                    ProductId = item.ProductId,
                    ProductName = _currentProduct.Name,
                    Quantity = item.Quantity,
                    ItemPrice = item.Price.ToCurrency(),
                    ColorName = _allColors.Where(p => p.Id == item.ColorId).FirstOrDefault()?.Name,
                    ColorId = _allColors.Where(p => p.Id == item.ColorId).FirstOrDefault().Id,
                    SizeName = _allSizes.Where(p => p.Id == item.SizeId).FirstOrDefault().Name,
                    SizeId = _allSizes.Where(p => p.Id == item.SizeId).FirstOrDefault().Id,
                });
            }

            BindingList<InputProductModel> dataSource = new BindingList<InputProductModel>(_currentListProductModel);
            _gridProduct.DataSource = dataSource;
        }

        private void _cbbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb = sender as System.Windows.Forms.ComboBox;
            if (_currentListProduct != null && cbb.SelectedIndex < _currentListProduct.Count)
            {
                _currentProduct = _currentListProduct.ElementAtOrDefault(cbb.SelectedIndex);
                LoadListProduct();
            };
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            var productSaleId = _gridProduct.GetIdFocus();
            _currentProductModel = _currentListProductModel.Where(p => p.Id == productSaleId).FirstOrDefault();
        }

        private void _btnChange_Click(object sender, EventArgs e)
        {
            if (_currentProductModel == null) return;
            var dialog =  new SelectItemSizeDialog(_currentProductModel);
            var result = dialog.ShowDialog();
            if (result == DialogResult.Yes)
                LoadListProduct();
        }
    }
}
