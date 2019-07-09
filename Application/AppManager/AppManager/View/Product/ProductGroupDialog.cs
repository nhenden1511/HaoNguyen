using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using DevExpress.XtraBars;
using AppManager.Entity;
using AppManager.Repository;
using DevExpress.XtraGrid.Views.Grid;
using AppManager.Model;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using AppManager.Util;

namespace AppManager.View.Product
{
    public partial class ProductGroupDialog : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        GridView gv;
        ProductGroup _currentGroup = new ProductGroup();
        IList<ProductGroup> _groups;
        List<ProductProperties> colors;
        List<ProductProperties> sizes;

        BindingList<ViewItemModel> _colorDataSource;
        BindingList<ViewItemModel> _sizeDataSource;

        public ProductGroupDialog()
        {
            InitializeComponent();

            ReloadColorSize();

            ReloadGroup();

            if (_groups != null) _currentGroup = _groups.FirstOrDefault();

            gv = _gridGroup.MainView as GridView;
            gv.GroupPanelText = "Product Group";

        }

        void ReloadColorSize()
        {
            var props = ProductPropertiesRepository.Instance.GetAll();
            colors = props.Where(p => p.Type == ProductType.Color).ToList();
            sizes = props.Where(p => p.Type == ProductType.Size).ToList();

            gridView_FocusedRowChanged(null, null);
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            _gridGroup.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dialog = new AddGroupDialog();
            var result = dialog.ShowDialog();
            if(result == DialogResult.Yes)
            {
                ReloadGroup();
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_currentGroup == null) return;
            var dialog = new AddGroupDialog(_currentGroup);
            var result = dialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                ReloadGroup();
            }
        }

        private void _btnAddColor_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dialog = new AddColorSizeDialog(true);
            var result = dialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                ReloadColorSize();
            }
        }

        private void _btnAddSize_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dialog = new AddColorSizeDialog(false);
            var result = dialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                ReloadColorSize();
            }
        }

        private void _itemColorClick_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit cEdit = (CheckEdit)sender;
            var col = _gridColor.MainView as ColumnView;
            GroupPropertiesMapRepository.Instance.UpdateStatus(_currentGroup.Id, (long)col.GetFocusedRowCellValue("Id"), cEdit.Checked);
        }

        private void _itemSizeSelected_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit cEdit = (CheckEdit)sender;
            var col = _gridSize.MainView as ColumnView;
            GroupPropertiesMapRepository.Instance.UpdateStatus(_currentGroup.Id, (long)col.GetFocusedRowCellValue("Id"), cEdit.Checked);
        }

        private void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (_groups == null) return;
            var col = _gridGroup.MainView as ColumnView;

            _currentGroup = _groups.Where(p => p.Id == ((long)col.GetFocusedRowCellValue("Id"))).FirstOrDefault();

            var colorMap = GroupPropertiesMapRepository.Instance.GetAllGroupMapPropertiesId(_currentGroup.Id);

            var currentColor = colors.Select(p => new ViewItemModel(p.Id, p.Name, colorMap.Contains(p.Id) ? true : false)).ToList();
            _colorDataSource = new BindingList<ViewItemModel>(currentColor);
            _gridColor.DataSource = _colorDataSource;


            var currentSize = sizes.Select(p => new ViewItemModel(p.Id, p.Name, colorMap.Contains(p.Id) ? true : false)).ToList();
            _sizeDataSource = new BindingList<ViewItemModel>(currentSize);
            _gridSize.DataSource = _sizeDataSource;
        }

        void ReloadGroup()
        {
            _groups = ProductGroupRepository.Instance.GetAll();
            BindingList<ProductGroup> dataSource = new BindingList<ProductGroup>(_groups);
            _gridGroup.DataSource = dataSource;
            bsiRecordsCount.Caption = "Total Groups : " + dataSource.Count;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_currentGroup == null) return;

            var confirmResult = MessageBox.Show("Bạn có muốn xóa loại sản phẩm này ??",
                                     "Xác Nhận Xóa!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ProductGroupRepository.Instance.Delete(_currentGroup);
                _currentGroup = _groups.FirstOrDefault();
                ReloadGroup();
            }
        }
    }
}