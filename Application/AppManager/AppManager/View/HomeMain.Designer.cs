namespace AppManager.View
{
    partial class HomeMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this._btnProductGroup = new DevExpress.XtraBars.BarButtonItem();
            this._btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this._btnShopOrder = new DevExpress.XtraBars.BarButtonItem();
            this._btnShipOrder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this._btnCheckOrder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this._btnChangeSize = new DevExpress.XtraBars.BarButtonItem();
            this.HOME = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTab = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this._btnCheckStore = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this._btnProductGroup,
            this._btnProduct,
            this.barButtonItem2,
            this._btnShopOrder,
            this._btnShipOrder,
            this.barButtonItem5,
            this._btnCheckOrder,
            this.barButtonItem3,
            this._btnChangeSize,
            this._btnCheckStore});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(6);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HOME,
            this.ribbonPage2,
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1750, 282);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
            // 
            // _btnProductGroup
            // 
            this._btnProductGroup.Caption = "Phân Loại Sản Phẩm";
            this._btnProductGroup.Id = 6;
            this._btnProductGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnProductGroup.ImageOptions.Image")));
            this._btnProductGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("_btnProductGroup.ImageOptions.LargeImage")));
            this._btnProductGroup.Name = "_btnProductGroup";
            this._btnProductGroup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this._btnProductGroup.SmallWithTextWidth = 100;
            this._btnProductGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._btnProductGroup_ItemClick);
            // 
            // _btnProduct
            // 
            this._btnProduct.Caption = "Sản Phẩm";
            this._btnProduct.Id = 7;
            this._btnProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnProduct.ImageOptions.Image")));
            this._btnProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("_btnProduct.ImageOptions.LargeImage")));
            this._btnProduct.Name = "_btnProduct";
            this._btnProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this._btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._btnProduct_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Nhập Đơn Hàng";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // _btnShopOrder
            // 
            this._btnShopOrder.Caption = "Lên Đơn Shop";
            this._btnShopOrder.Id = 10;
            this._btnShopOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnShopOrder.ImageOptions.Image")));
            this._btnShopOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("_btnShopOrder.ImageOptions.LargeImage")));
            this._btnShopOrder.Name = "_btnShopOrder";
            this._btnShopOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._btnShopOrder_ItemClick);
            // 
            // _btnShipOrder
            // 
            this._btnShipOrder.Caption = "Lên Đơn Ship";
            this._btnShipOrder.Id = 11;
            this._btnShipOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnShipOrder.ImageOptions.Image")));
            this._btnShipOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("_btnShipOrder.ImageOptions.LargeImage")));
            this._btnShipOrder.Name = "_btnShipOrder";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Lên Đơn Sỉ";
            this.barButtonItem5.Id = 12;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // _btnCheckOrder
            // 
            this._btnCheckOrder.Caption = "Thống Kê Đơn Hàng";
            this._btnCheckOrder.Id = 13;
            this._btnCheckOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnCheckOrder.ImageOptions.Image")));
            this._btnCheckOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("_btnCheckOrder.ImageOptions.LargeImage")));
            this._btnCheckOrder.Name = "_btnCheckOrder";
            this._btnCheckOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._btnCheckOrder_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Quản Lý Chi Tiêu";
            this.barButtonItem3.Id = 14;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // _btnChangeSize
            // 
            this._btnChangeSize.Caption = "Đổi Size";
            this._btnChangeSize.Id = 15;
            this._btnChangeSize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnChangeSize.ImageOptions.Image")));
            this._btnChangeSize.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("_btnChangeSize.ImageOptions.LargeImage")));
            this._btnChangeSize.Name = "_btnChangeSize";
            this._btnChangeSize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._btnChangeSize_ItemClick);
            // 
            // HOME
            // 
            this.HOME.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.HOME.Name = "HOME";
            this.HOME.Text = "Trang Chính";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this._btnShopOrder);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lên Đơn Shop";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this._btnShipOrder);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Order";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Trang Quản Lý Sản Phẩm";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this._btnProductGroup);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Product Group";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this._btnProduct);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Product";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this._btnChangeSize);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Company";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang Nhập Hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thống Kê";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this._btnCheckOrder);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1027);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1750, 54);
            // 
            // xtraTab
            // 
            this.xtraTab.MdiParent = this;
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 3;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Input Product";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this._btnCheckStore);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "ribbonPageGroup11";
            // 
            // _btnCheckStore
            // 
            this._btnCheckStore.Caption = "Kiểm Kho";
            this._btnCheckStore.Id = 16;
            this._btnCheckStore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this._btnCheckStore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this._btnCheckStore.Name = "_btnCheckStore";
            this._btnCheckStore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._btnCheckStore_ItemClick);
            // 
            // HomeMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1750, 1081);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HomeMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HomeMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage HOME;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTab;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem _btnProductGroup;
        private DevExpress.XtraBars.BarButtonItem _btnProduct;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem _btnShopOrder;
        private DevExpress.XtraBars.BarButtonItem _btnShipOrder;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem _btnCheckOrder;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem _btnChangeSize;
        private DevExpress.XtraBars.BarButtonItem _btnCheckStore;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
    }
}