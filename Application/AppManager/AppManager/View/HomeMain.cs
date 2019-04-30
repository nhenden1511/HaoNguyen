using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using AppManager.View.Product;

namespace AppManager.View
{
    public partial class HomeMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HomeMain()
        {
            InitializeComponent();
        }

        private Form CheckForm(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            var a = ((RibbonControl)sender).SelectedPage ;
        }

        private void _btnProductGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(ProductGroupDialog));
            if (frm == null)
            {
                ProductGroupDialog forms = new ProductGroupDialog();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void _btnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(ProductDialog));
            if (frm == null)
            {
                ProductDialog forms = new ProductDialog();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(InputProductDialog));
            if (frm == null)
            {
                InputProductDialog forms = new InputProductDialog();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}