﻿using System;
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
using AppManager.Entity;
using AppManager.Repository;
using IProduct = AppManager.Entity.Product;
using DevExpress.XtraGrid.Views.Base;
using AppManager.Util;

namespace AppManager.View.Product
{
    public partial class ProductDialog : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductGroup _currentGroup = new ProductGroup();
        IList<ProductGroup> _groups;
        IList<IProduct> _currentListProduct = new List<IProduct>();
        IProduct _currentProduct = new IProduct();

        public ProductDialog()
        {
            InitializeComponent();

            _groups = ProductGroupRepository.Instance.GetAll();
            BindingList<ProductGroup> dataSource = new BindingList<ProductGroup>(_groups);
            _gridProductGroup.DataSource = dataSource;
            bsiRecordsCount.Caption = "Total Groups : " + dataSource.Count;
            
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var groupId = _gridProductGroup.GetIdFocus();
            _currentGroup = _groups.Where(p => p.Id == groupId).FirstOrDefault();
            _currentListProduct = ProductRepository.Instance.GetProductsByGroup(groupId);
            BindingList<IProduct> dataSource = new BindingList<IProduct>(_currentListProduct);
            _gridProduct.DataSource = dataSource;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dialog = new AddProduct(_currentGroup);
            var result = dialog.ShowDialog();
            if (result == DialogResult.Yes) Reload();
        }

        void Reload()
        {
            var products = ProductRepository.Instance.GetProductsByGroup(_currentGroup.Id);
            BindingList<IProduct> dataSource = new BindingList<IProduct>(products);
            _gridProduct.DataSource = dataSource;
        }

        private void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            var productId = _gridProduct.GetIdFocus();
            _currentProduct = _currentListProduct.Where(p => p.Id == productId).FirstOrDefault();
        }

        private void _gridProduct_DoubleClick(object sender, EventArgs e)
        {
            var dialog = new AddProduct(_currentGroup, _currentProduct);
            var result = dialog.ShowDialog();
            if (result == DialogResult.Yes) Reload();
        }
    }
}