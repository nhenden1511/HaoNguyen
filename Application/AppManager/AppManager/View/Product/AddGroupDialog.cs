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

namespace AppManager.View.Product
{
    public partial class AddGroupDialog : DevExpress.XtraEditors.XtraForm
    {
        ProductGroup _group;
        public AddGroupDialog(ProductGroup group = null)
        {
            InitializeComponent();
            _group = group;
            if (_group != null)
            {
                _txtName.Text = _group.Name;
                _txtCode.Text = _group.GroupCode;
                _btnAdd.Text = "Cập Nhật";
                Text = "Cập Nhật Nhóm Sản Phẩm";
            }
            else
                Text = "Thêm Mới Nhóm Sản Phẩm";
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_txtName.Text)&& !string.IsNullOrWhiteSpace(_txtCode.Text))
            {
                try
                {
                    if(_group == null)
                    {
                        var group = new ProductGroup(_txtName.Text, _txtCode.Text);
                        ProductGroupRepository.Instance.Insert(group);
                    }
                    else
                    {
                        ProductGroupRepository.Instance.Update(_group);
                    }
                    
                    this.Close();
                    DialogResult = DialogResult.Yes;
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
    }
}