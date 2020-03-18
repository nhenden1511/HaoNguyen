namespace AppManager.View.Product
{
    partial class ChangeOrderProductDialog
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
            this._txtGroup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._txtColor = new System.Windows.Forms.Label();
            this._txtProduct = new System.Windows.Forms.Label();
            this._txtSize = new System.Windows.Forms.Label();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._txtQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm Sản Phẩm";
            // 
            // _txtGroup
            // 
            this._txtGroup.AutoSize = true;
            this._txtGroup.Location = new System.Drawing.Point(349, 50);
            this._txtGroup.Name = "_txtGroup";
            this._txtGroup.Size = new System.Drawing.Size(86, 25);
            this._txtGroup.TabIndex = 1;
            this._txtGroup.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kích Thước";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Màu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số Lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Giá Nhập";
            // 
            // _txtColor
            // 
            this._txtColor.AutoSize = true;
            this._txtColor.Location = new System.Drawing.Point(349, 148);
            this._txtColor.Name = "_txtColor";
            this._txtColor.Size = new System.Drawing.Size(86, 25);
            this._txtColor.TabIndex = 10;
            this._txtColor.Text = "Product";
            // 
            // _txtProduct
            // 
            this._txtProduct.AutoSize = true;
            this._txtProduct.Location = new System.Drawing.Point(349, 99);
            this._txtProduct.Name = "_txtProduct";
            this._txtProduct.Size = new System.Drawing.Size(86, 25);
            this._txtProduct.TabIndex = 11;
            this._txtProduct.Text = "Product";
            // 
            // _txtSize
            // 
            this._txtSize.AutoSize = true;
            this._txtSize.Location = new System.Drawing.Point(349, 197);
            this._txtSize.Name = "_txtSize";
            this._txtSize.Size = new System.Drawing.Size(86, 25);
            this._txtSize.TabIndex = 12;
            this._txtSize.Text = "Product";
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(354, 290);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(220, 31);
            this._txtPrice.TabIndex = 14;
            this._txtPrice.Click += new System.EventHandler(this._txtPrice_Click);
            this._txtPrice.TextChanged += new System.EventHandler(this._txtPrice_TextChanged);
            this._txtPrice.Enter += new System.EventHandler(this._txtPrice_Enter);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(261, 362);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(275, 65);
            this._btnSave.TabIndex = 15;
            this._btnSave.Text = "Lưu Lại";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _txtQuantity
            // 
            this._txtQuantity.Location = new System.Drawing.Point(354, 242);
            this._txtQuantity.Name = "_txtQuantity";
            this._txtQuantity.Size = new System.Drawing.Size(220, 31);
            this._txtQuantity.TabIndex = 16;
            this._txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtQuantity_KeyPress);
            // 
            // ChangeOrderProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtQuantity);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this._txtSize);
            this.Controls.Add(this._txtProduct);
            this.Controls.Add(this._txtColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtGroup);
            this.Controls.Add(this.label1);
            this.Name = "ChangeOrderProductDialog";
            this.Text = "ChangeOrderProductDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _txtGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label _txtColor;
        private System.Windows.Forms.Label _txtProduct;
        private System.Windows.Forms.Label _txtSize;
        private System.Windows.Forms.TextBox _txtPrice;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.TextBox _txtQuantity;
    }
}