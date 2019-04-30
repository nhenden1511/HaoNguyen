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
        public AddGroupDialog()
        {
            InitializeComponent();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_txtName.Text)&& !string.IsNullOrWhiteSpace(_txtCode.Text))
            {
                try
                {
                    var group = new ProductGroup(_txtName.Text, _txtCode.Text);
                    ProductGroupRepository.Instance.Insert(group);
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