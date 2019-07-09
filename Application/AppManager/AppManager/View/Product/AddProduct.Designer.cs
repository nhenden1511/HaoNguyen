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
            this._txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._txtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // _txtProductName
            // 
            this._txtProductName.Location = new System.Drawing.Point(284, 110);
            this._txtProductName.Margin = new System.Windows.Forms.Padding(6);
            this._txtProductName.Name = "_txtProductName";
            this._txtProductName.Size = new System.Drawing.Size(482, 34);
            this._txtProductName.TabIndex = 3;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(332, 260);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(214, 73);
            this._btnAdd.TabIndex = 4;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _cbbGroup
            // 
            this._cbbGroup.FormattingEnabled = true;
            this._cbbGroup.Location = new System.Drawing.Point(284, 50);
            this._cbbGroup.Margin = new System.Windows.Forms.Padding(60, 6, 6, 6);
            this._cbbGroup.Name = "_cbbGroup";
            this._cbbGroup.Size = new System.Drawing.Size(482, 33);
            this._cbbGroup.TabIndex = 5;
            this._cbbGroup.SelectedIndexChanged += new System.EventHandler(this._cbbGroup_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá Bán";
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(284, 170);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(482, 33);
            this._txtPrice.TabIndex = 7;
            this._txtPrice.Click += new System.EventHandler(this._txtPrice_Click);
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged_1);
            this._txtPrice.Enter += new System.EventHandler(this._txtPrice_Enter);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 366);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbbGroup);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddProduct";
            this.Text = "Thêm Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this._txtProductName.Properties)).EndInit();
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
        private System.Windows.Forms.TextBox _txtPrice;
    }
}