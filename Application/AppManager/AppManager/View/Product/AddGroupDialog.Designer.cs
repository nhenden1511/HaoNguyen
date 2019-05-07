namespace AppManager.View.Product
{
    partial class AddGroupDialog
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
            this._txtName = new DevExpress.XtraEditors.TextEdit();
            this._txtCode = new DevExpress.XtraEditors.TextEdit();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this._txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Group Code";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(353, 108);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(418, 34);
            this._txtName.TabIndex = 2;
            // 
            // _txtCode
            // 
            this._txtCode.Location = new System.Drawing.Point(353, 168);
            this._txtCode.Name = "_txtCode";
            this._txtCode.Size = new System.Drawing.Size(418, 34);
            this._txtCode.TabIndex = 3;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(321, 320);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(261, 71);
            this._btnAdd.TabIndex = 4;
            this._btnAdd.Text = "Add Group";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // AddGroupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 445);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._txtCode);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddGroupDialog";
            this.Text = "AddGroupDialog";
            ((System.ComponentModel.ISupportInitialize)(this._txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit _txtName;
        private DevExpress.XtraEditors.TextEdit _txtCode;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
    }
}