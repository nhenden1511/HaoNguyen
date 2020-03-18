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
    public partial class ChangeOrderProductDialog : Form
    {
        InputProductModel _model;
        public ChangeOrderProductDialog(InputProductModel model)
        {
            InitializeComponent();
            _txtGroup.Text = model.GroupName;
            _txtQuantity.Text = model.Quantity.ToString();
            _txtProduct.Text = model.ProductName;
            _txtColor.Text = model.ColorName;
            _txtSize.Text = model.SizeName;
            _txtPrice.Text = model.ItemPrice;
            _model = model;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if(_txtPrice.Text.ToPrice() != _model.ItemPrice.ToPrice() || _txtQuantity.Text.ToPrice() != _model.Quantity)
            {
                var item = ProductSaleRepository.Instance.GetByProduct(_model.ProductId, _model.ColorId, _model.SizeId, _model.ItemPrice.ToPrice());
                if(item == null || item.Quantity < _model.Quantity)
                {
                    MessageBox.Show("Không Tìm Thấy Sản Phẩm", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    //change quantity
                    if(item.Price == _txtPrice.Text.ToPrice())
                    {
                        item.Quantity = item.Quantity - _model.Quantity + _txtQuantity.Text.ToPrice();
                        ProductSaleRepository.Instance.Update(item);
                    }
                    else
                    {
                        item.Quantity = item.Quantity - _model.Quantity;
                        ProductSaleRepository.Instance.Update(item);

                        var newItem = ProductSaleRepository.Instance.GetByProduct(_model.ProductId, _model.ColorId, _model.SizeId, _txtPrice.Text.ToPrice());
                        if(newItem != null)
                        {
                            newItem.Quantity += _txtQuantity.Text.ToPrice();
                            ProductSaleRepository.Instance.Update(newItem);
                        }
                        else
                        {
                            var newProduct = new ProductSale()
                            {
                                ProductId = _model.ProductId,
                                ColorId = _model.ColorId,
                                SizeId = _model.SizeId,
                                Price = _txtPrice.Text.ToPrice(),
                                Quantity = _txtQuantity.Text.ToPrice(),
                            };
                            ProductSaleRepository.Instance.Insert(newProduct);
                        }
                    }
                    //update order input sale
                    var inputTotal = OrderInputTotalRepository.Instance.GetById(_model.ParentId);
                    var orderInput = OrderInputItemRepository.Instance.GetById(_model.Id);
                    orderInput.Quantity = _txtQuantity.Text.ToPrice();
                    orderInput.Price = _txtPrice.Text.ToPrice();
                    OrderInputItemRepository.Instance.Update(orderInput);
                    inputTotal.TotalPrice += ((orderInput.Quantity * orderInput.Price) - (_model.Quantity * _model.ItemPrice.ToPrice()));
                    OrderInputTotalRepository.Instance.Update(inputTotal);
                    ModelHelper.InputMoney(((orderInput.Quantity * orderInput.Price) - (_model.Quantity * _model.ItemPrice.ToPrice())), "Cập nhật Đơn nhập hàng");
                    Close();
                    DialogResult = DialogResult.Yes;
                }
            }
        }

        private void _txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            _txtQuantity.SetNumber(sender, e);
        }

        private void _txtPrice_Click(object sender, EventArgs e)
        {
            _txtPrice.Select(_txtPrice.Text.Length - 4, 0);
        }

        private void _txtPrice_Enter(object sender, EventArgs e)
        {
            _txtPrice.Select(_txtPrice.Text.Length - 4, 0);
        }

        private void _txtPrice_TextChanged(object sender, EventArgs e)
        {
            _txtPrice.ToCurrency();
        }
    }
}
