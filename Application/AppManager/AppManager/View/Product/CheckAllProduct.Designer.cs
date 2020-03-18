namespace AppManager.View.Product
{
    partial class CheckAllProduct
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this._txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cbbGroup = new System.Windows.Forms.ComboBox();
            this._txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cbGroup = new DevExpress.XtraEditors.CheckEdit();
            this._cbAll = new DevExpress.XtraEditors.CheckEdit();
            this._gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this._cbbProduct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this._cbbProduct);
            this.splitContainerControl1.Panel1.Controls.Add(this.label4);
            this.splitContainerControl1.Panel1.Controls.Add(this._txtQuantity);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3);
            this.splitContainerControl1.Panel1.Controls.Add(this._cbbGroup);
            this.splitContainerControl1.Panel1.Controls.Add(this._txtTotal);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this._cbGroup);
            this.splitContainerControl1.Panel1.Controls.Add(this._cbAll);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this._gridProduct);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1988, 1240);
            this.splitContainerControl1.SplitterPosition = 98;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // _txtQuantity
            // 
            this._txtQuantity.Location = new System.Drawing.Point(1544, 56);
            this._txtQuantity.Name = "_txtQuantity";
            this._txtQuantity.Size = new System.Drawing.Size(212, 33);
            this._txtQuantity.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1432, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _cbbGroup
            // 
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(637, 36);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(269, 33);
            this._cbbGroup.TabIndex = 7;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged_1);
            // 
            // _txtTotal
            // 
            this._txtTotal.Location = new System.Drawing.Point(1544, 17);
            this._txtTotal.Name = "_txtTotal";
            this._txtTotal.Size = new System.Drawing.Size(212, 33);
            this._txtTotal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1432, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng Tiền";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại";
            // 
            // _cbGroup
            // 
            this._cbGroup.Location = new System.Drawing.Point(305, 35);
            this._cbGroup.Name = "_cbGroup";
            this._cbGroup.Properties.Caption = "Nhóm sản phẩm";
            this._cbGroup.Size = new System.Drawing.Size(195, 34);
            this._cbGroup.TabIndex = 2;
            this._cbGroup.CheckedChanged += new System.EventHandler(this._cbGroup_CheckedChanged);
            // 
            // _cbAll
            // 
            this._cbAll.Location = new System.Drawing.Point(12, 35);
            this._cbAll.Name = "_cbAll";
            this._cbAll.Properties.Caption = "Tất cả sản phẩm";
            this._cbAll.Size = new System.Drawing.Size(237, 34);
            this._cbAll.TabIndex = 1;
            this._cbAll.CheckedChanged += new System.EventHandler(this._cbAll_CheckedChanged);
            // 
            // _gridProduct
            // 
            this._gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridProduct.Location = new System.Drawing.Point(0, 0);
            this._gridProduct.MainView = this.gridView1;
            this._gridProduct.Name = "_gridProduct";
            this._gridProduct.Size = new System.Drawing.Size(1988, 1132);
            this._gridProduct.TabIndex = 0;
            this._gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this._gridProduct;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Giá Nhập";
            this.gridColumn6.FieldName = "ItemPrice";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Lượng";
            this.gridColumn5.FieldName = "Quantity";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Size";
            this.gridColumn4.FieldName = "SizeName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Màu";
            this.gridColumn3.FieldName = "ColorName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sản Phẩm";
            this.gridColumn2.FieldName = "ProductName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Loại";
            this.gridColumn1.FieldName = "GroupName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // _cbbProduct
            // 
            this._cbbProduct.FormattingEnabled = true;
            this._cbbProduct.Location = new System.Drawing.Point(1082, 36);
            this._cbbProduct.Name = "_cbbProduct";
            this._cbbProduct.Size = new System.Drawing.Size(311, 33);
            this._cbbProduct.TabIndex = 11;
            this._cbbProduct.SelectedIndexChanged += new System.EventHandler(this._cbbProduct_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(952, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sản Phẩm";
            // 
            // CheckAllProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1988, 1240);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "CheckAllProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "CheckAllProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._cbGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.CheckEdit _cbGroup;
        private DevExpress.XtraEditors.CheckEdit _cbAll;
        private DevExpress.XtraGrid.GridControl _gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtTotal;
        private System.Windows.Forms.ComboBox _cbbGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.TextBox _txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbbProduct;
        private System.Windows.Forms.Label label4;
    }
}