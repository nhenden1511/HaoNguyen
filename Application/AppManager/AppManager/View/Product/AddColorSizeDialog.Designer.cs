namespace AppManager.View.Product
{
    partial class AddColorSizeDialog
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
            this._groupName = new DevExpress.XtraEditors.GroupControl();
            this._lbName = new DevExpress.XtraEditors.LabelControl();
            this._txtValue = new DevExpress.XtraEditors.TextEdit();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this._groupName)).BeginInit();
            this._groupName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _groupName
            // 
            this._groupName.Controls.Add(this._btnAdd);
            this._groupName.Controls.Add(this._txtValue);
            this._groupName.Controls.Add(this._lbName);
            this._groupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupName.Location = new System.Drawing.Point(0, 0);
            this._groupName.Name = "_groupName";
            this._groupName.Size = new System.Drawing.Size(389, 145);
            this._groupName.TabIndex = 0;
            this._groupName.Text = "Add Color";
            // 
            // _lbName
            // 
            this._lbName.Location = new System.Drawing.Point(24, 41);
            this._lbName.Name = "_lbName";
            this._lbName.Size = new System.Drawing.Size(55, 13);
            this._lbName.TabIndex = 0;
            this._lbName.Text = "Color Name";
            // 
            // _txtValue
            // 
            this._txtValue.Location = new System.Drawing.Point(109, 38);
            this._txtValue.Name = "_txtValue";
            this._txtValue.Size = new System.Drawing.Size(242, 20);
            this._txtValue.TabIndex = 1;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(109, 108);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(175, 25);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.Text = "Add";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // AddColorSizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 145);
            this.Controls.Add(this._groupName);
            this.Name = "AddColorSizeDialog";
            this.Text = "AddColorSizeDialog";
            ((System.ComponentModel.ISupportInitialize)(this._groupName)).EndInit();
            this._groupName.ResumeLayout(false);
            this._groupName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl _groupName;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.TextEdit _txtValue;
        private DevExpress.XtraEditors.LabelControl _lbName;
    }
}