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
using AppManager.Util;

namespace AppManager.View.Product
{
    public partial class AddColorSizeDialog : DevExpress.XtraEditors.XtraForm
    {
        bool _fColor;
        public AddColorSizeDialog(bool fColor)
        {
            _fColor = fColor;
            InitializeComponent();
            if (fColor)
            {
                this.Name = "Color";
                _groupName.Text = "Add Color";
                _lbName.Text = "Color Name";
            }
            else
            {
                this.Name = "Size";
                _groupName.Text = "Add Size";
                _lbName.Text = "Size Name";
            }
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_txtValue.Text))
            {
                ProductProperties entity = new ProductProperties() { Name = _txtValue.Text, Type = _fColor ? ProductType.Color : ProductType.Size };
                try
                {
                    ProductPropertiesRepository.Instance.Insert(entity);
                    this.Close();
                    DialogResult = DialogResult.Yes;
                }
                catch (Exception)
                {
                    string message = "Can not replace name";
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
        }
    }
}