namespace AppManager.View.Product
{
    partial class InputOrderDialog
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this._txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this._cbbGroup = new System.Windows.Forms.ComboBox();
            this._cbbSize = new System.Windows.Forms.ComboBox();
            this._cbbColor = new System.Windows.Forms.ComboBox();
            this._cbbProduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this._cbbProduct);
            this.splitContainerControl1.Panel2.Controls.Add(this._cbbColor);
            this.splitContainerControl1.Panel2.Controls.Add(this._cbbSize);
            this.splitContainerControl1.Panel2.Controls.Add(this._cbbGroup);
            this.splitContainerControl1.Panel2.Controls.Add(this.button1);
            this.splitContainerControl1.Panel2.Controls.Add(this._txtTotalPrice);
            this.splitContainerControl1.Panel2.Controls.Add(this._txtQuantity);
            this.splitContainerControl1.Panel2.Controls.Add(this.label7);
            this.splitContainerControl1.Panel2.Controls.Add(this.label6);
            this.splitContainerControl1.Panel2.Controls.Add(this.label5);
            this.splitContainerControl1.Panel2.Controls.Add(this.label4);
            this.splitContainerControl1.Panel2.Controls.Add(this.label3);
            this.splitContainerControl1.Panel2.Controls.Add(this.label2);
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1134, 684);
            this.splitContainerControl1.SplitterPosition = 645;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(645, 638);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Price";
            // 
            // _txtQuantity
            // 
            this._txtQuantity.Location = new System.Drawing.Point(126, 277);
            this._txtQuantity.Name = "_txtQuantity";
            this._txtQuantity.Size = new System.Drawing.Size(194, 20);
            this._txtQuantity.TabIndex = 11;
            // 
            // _txtTotalPrice
            // 
            this._txtTotalPrice.Location = new System.Drawing.Point(126, 302);
            this._txtTotalPrice.Name = "_txtTotalPrice";
            this._txtTotalPrice.Size = new System.Drawing.Size(194, 20);
            this._txtTotalPrice.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(645, 684);
            this.splitContainerControl2.SplitterPosition = 638;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // _cbbGroup
            // 
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(126, 67);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(194, 21);
            this._cbbGroup.TabIndex = 14;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged);
            // 
            // _cbbSize
            // 
            this._cbbSize.FormattingEnabled = true;
            this._cbbSize.Location = new System.Drawing.Point(126, 155);
            this._cbbSize.Name = "_cbbSize";
            this._cbbSize.Size = new System.Drawing.Size(194, 21);
            this._cbbSize.TabIndex = 15;
            // 
            // _cbbColor
            // 
            this._cbbColor.FormattingEnabled = true;
            this._cbbColor.Location = new System.Drawing.Point(126, 126);
            this._cbbColor.Name = "_cbbColor";
            this._cbbColor.Size = new System.Drawing.Size(194, 21);
            this._cbbColor.TabIndex = 16;
            // 
            // _cbbProduct
            // 
            this._cbbProduct.FormattingEnabled = true;
            this._cbbProduct.Location = new System.Drawing.Point(126, 96);
            this._cbbProduct.Name = "_cbbProduct";
            this._cbbProduct.Size = new System.Drawing.Size(194, 21);
            this._cbbProduct.TabIndex = 17;
            this._cbbProduct.SelectedIndexChanged += new System.EventHandler(this._cbbProduct_SelectedIndexChanged);
            // 
            // InputOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 684);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "InputOrderDialog";
            this.Text = "InputOrderDialog";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit _txtTotalPrice;
        private DevExpress.XtraEditors.TextEdit _txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.ComboBox _cbbProduct;
        private System.Windows.Forms.ComboBox _cbbColor;
        private System.Windows.Forms.ComboBox _cbbSize;
        private System.Windows.Forms.ComboBox _cbbGroup;
    }
}