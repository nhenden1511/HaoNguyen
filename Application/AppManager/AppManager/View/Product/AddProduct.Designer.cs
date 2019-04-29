namespace AppManager.View.Product
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtProductName = new DevExpress.XtraEditors.TextEdit();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this._cbbGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtPrice = new DevExpress.XtraEditors.TextEdit();
            this._txtOrderPrice = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this._txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtOrderPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductGroup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // _txtProductName
            // 
            this._txtProductName.Location = new System.Drawing.Point(142, 57);
            this._txtProductName.Name = "_txtProductName";
            this._txtProductName.Size = new System.Drawing.Size(241, 20);
            this._txtProductName.TabIndex = 3;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(164, 156);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(107, 38);
            this._btnAdd.TabIndex = 4;
            this._btnAdd.Text = "Add";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _cbbGroup
            // 
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(142, 26);
            this._cbbGroup.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(241, 21);
            this._cbbGroup.TabIndex = 5;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Price";
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(142, 87);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(241, 20);
            this._txtPrice.TabIndex = 8;
            // 
            // _txtOrderPrice
            // 
            this._txtOrderPrice.Location = new System.Drawing.Point(142, 119);
            this._txtOrderPrice.Name = "_txtOrderPrice";
            this._txtOrderPrice.Size = new System.Drawing.Size(241, 20);
            this._txtOrderPrice.TabIndex = 9;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 207);
            this.Controls.Add(this._txtOrderPrice);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbbGroup);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this._txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtOrderPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit _txtProductName;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private System.Windows.Forms.ComboBox _cbbGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit _txtPrice;
        private DevExpress.XtraEditors.TextEdit _txtOrderPrice;
    }
}