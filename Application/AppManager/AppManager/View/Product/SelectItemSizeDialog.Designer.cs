namespace AppManager.View.Product
{
    partial class SelectItemSizeDialog
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
            this._txtLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._btnChange = new System.Windows.Forms.Button();
            this._cbbSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _txtLabel
            // 
            this._txtLabel.AutoSize = true;
            this._txtLabel.Location = new System.Drawing.Point(93, 52);
            this._txtLabel.Name = "_txtLabel";
            this._txtLabel.Size = new System.Drawing.Size(70, 25);
            this._txtLabel.TabIndex = 0;
            this._txtLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Size";
            // 
            // _btnChange
            // 
            this._btnChange.Location = new System.Drawing.Point(233, 206);
            this._btnChange.Name = "_btnChange";
            this._btnChange.Size = new System.Drawing.Size(253, 75);
            this._btnChange.TabIndex = 3;
            this._btnChange.Text = "Đổi Size";
            this._btnChange.UseVisualStyleBackColor = true;
            this._btnChange.Click += new System.EventHandler(this._btnChange_Click);
            // 
            // _cbbSize
            // 
            this._cbbSize.FormattingEnabled = true;
            this._cbbSize.Location = new System.Drawing.Point(233, 114);
            this._cbbSize.Name = "_cbbSize";
            this._cbbSize.Size = new System.Drawing.Size(253, 33);
            this._cbbSize.TabIndex = 4;
            this._cbbSize.SelectedIndexChanged += new System.EventHandler(this._cbbSize_SelectedIndexChanged_1);
            // 
            // SelectItemSizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 330);
            this.Controls.Add(this._cbbSize);
            this.Controls.Add(this._btnChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtLabel);
            this.Name = "SelectItemSizeDialog";
            this.Text = "SelectItemSizeDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _txtLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnChange;
        private System.Windows.Forms.ComboBox _cbbSize;
    }
}