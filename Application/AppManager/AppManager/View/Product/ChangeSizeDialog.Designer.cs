namespace AppManager.View.Product
{
    partial class ChangeSizeDialog
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
            this._gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this._cbbGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cbbProduct = new System.Windows.Forms.ComboBox();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this._btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _gridProduct
            // 
            this._gridProduct.Location = new System.Drawing.Point(93, 252);
            this._gridProduct.MainView = this.gridView2;
            this._gridProduct.Name = "_gridProduct";
            this._gridProduct.Size = new System.Drawing.Size(853, 700);
            this._gridProduct.TabIndex = 33;
            this._gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.GridControl = this._gridProduct;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView2_FocusedRowObjectChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Sản Phẩm";
            this.gridColumn1.FieldName = "ProductName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Màu";
            this.gridColumn2.FieldName = "ColorName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Size";
            this.gridColumn3.FieldName = "SizeName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Lượng Còn";
            this.gridColumn4.FieldName = "Quantity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giá Nhập";
            this.gridColumn5.FieldName = "ItemPrice";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Loại Sản Phẩm";
            // 
            // _cbbGroup
            // 
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(298, 61);
            this._cbbGroup.Margin = new System.Windows.Forms.Padding(6);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(384, 33);
            this._cbbGroup.TabIndex = 30;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Chọn Sản Phẩm";
            // 
            // _cbbProduct
            // 
            this._cbbProduct.FormattingEnabled = true;
            this._cbbProduct.Location = new System.Drawing.Point(298, 117);
            this._cbbProduct.Margin = new System.Windows.Forms.Padding(6);
            this._cbbProduct.Name = "_cbbProduct";
            this._cbbProduct.Size = new System.Drawing.Size(384, 33);
            this._cbbProduct.TabIndex = 32;
            this._cbbProduct.SelectedIndexChanged += new System.EventHandler(this._cbbProduct_SelectedIndexChanged);
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this._gridProduct;
            this.searchControl1.Location = new System.Drawing.Point(93, 212);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this._gridProduct;
            this.searchControl1.Properties.FindDelay = 200;
            this.searchControl1.Size = new System.Drawing.Size(853, 34);
            this.searchControl1.TabIndex = 34;
            // 
            // _btnChange
            // 
            this._btnChange.Location = new System.Drawing.Point(735, 61);
            this._btnChange.Name = "_btnChange";
            this._btnChange.Size = new System.Drawing.Size(211, 89);
            this._btnChange.TabIndex = 35;
            this._btnChange.Text = "Đổi Size";
            this._btnChange.UseVisualStyleBackColor = true;
            this._btnChange.Click += new System.EventHandler(this._btnChange_Click);
            // 
            // ChangeSizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 1092);
            this.Controls.Add(this._btnChange);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this._gridProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbbGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbbProduct);
            this.Name = "ChangeSizeDialog";
            this.Text = "ChangeSizeDialog";
            ((System.ComponentModel.ISupportInitialize)(this._gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl _gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cbbGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbbProduct;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.Button _btnChange;
    }
}