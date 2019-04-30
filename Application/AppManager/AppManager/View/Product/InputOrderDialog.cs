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

namespace AppManager.View.Product
{
    public partial class InputOrderDialog : DevExpress.XtraEditors.XtraForm
    {
        List<ProductProperties> colors;
        List<ProductProperties> sizes;

        static ProductGroup _currentProductGroup;
        IList<ProductGroup> _currentListGroups;

        static IProduct _currentProduct;
        IList<IProduct> _currentListProduct;

        public InputOrderDialog()
        {
            InitializeComponent();

            var props = ProductPropertiesRepository.Instance.GetAll();
            colors = props.Where(p => p.Type == ProductType.Color).ToList();
            sizes = props.Where(p => p.Type == ProductType.Size).ToList();

            _currentListGroups = _cbbGroup.LoadGroupToCBB();

            if (_currentListGroups.Count > 0)
                _currentProductGroup = _currentListGroups.FirstOrDefault();
            LoadProductByGroup();

            if (_currentListProduct.Count > 0)
                _currentProduct = _currentListProduct.FirstOrDefault();

            LoadColorSizeByProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                _currentListProduct = _cbbProduct.LoadProductToCBB(_currentProductGroup.Id);
        }

        void LoadColorSizeByProduct()
        {
            if (_currentProductGroup != null)
            {
                var colorSizeMap = GroupPropertiesMapRepository.Instance.GetAllGroupMapPropertiesId(_currentProduct.GroupId);

                var color = colors.Where(p => colorSizeMap.Contains(p.Id)).ToList();
                if (color.Count > 0)
                {
                    foreach (var item in color)
                    {
                        _cbbColor.Items.Add(item.Name);
                    }
                    _cbbColor.SelectedIndex = 0;
                }

                var size = sizes.Where(p => colorSizeMap.Contains(p.Id)).ToList();
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
            if (_currentListProduct != null)
            {
                var cbb = sender as System.Windows.Forms.ComboBox;
                _currentProduct = _currentListProduct.ElementAtOrDefault(cbb.SelectedIndex);
                LoadColorSizeByProduct();
            }
        }
    }
}