namespace AppManager.View.SaleManager
{
    partial class DeviceExpenseDialog
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
            this._gridExpense = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this._txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtMoneyOutPut = new System.Windows.Forms.TextBox();
            this._txtNoteOutPut = new System.Windows.Forms.TextBox();
            this._txtMoneyInput = new System.Windows.Forms.TextBox();
            this._txtNoteInput = new System.Windows.Forms.TextBox();
            this._btnOutput = new System.Windows.Forms.Button();
            this._btnInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._gridExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _gridExpense
            // 
            this._gridExpense.Location = new System.Drawing.Point(1179, 22);
            this._gridExpense.MainView = this.gridView1;
            this._gridExpense.Name = "_gridExpense";
            this._gridExpense.Size = new System.Drawing.Size(867, 952);
            this._gridExpense.TabIndex = 0;
            this._gridExpense.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this._gridExpense;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền Shop";
            // 
            // _txtTotal
            // 
            this._txtTotal.Location = new System.Drawing.Point(219, 127);
            this._txtTotal.Name = "_txtTotal";
            this._txtTotal.Size = new System.Drawing.Size(312, 31);
            this._txtTotal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xuất Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lý Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thu Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 682);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nội Dung";
            // 
            // _txtMoneyOutPut
            // 
            this._txtMoneyOutPut.Location = new System.Drawing.Point(219, 279);
            this._txtMoneyOutPut.Name = "_txtMoneyOutPut";
            this._txtMoneyOutPut.Size = new System.Drawing.Size(312, 31);
            this._txtMoneyOutPut.TabIndex = 7;
            // 
            // _txtNoteOutPut
            // 
            this._txtNoteOutPut.Location = new System.Drawing.Point(219, 335);
            this._txtNoteOutPut.Name = "_txtNoteOutPut";
            this._txtNoteOutPut.Size = new System.Drawing.Size(668, 31);
            this._txtNoteOutPut.TabIndex = 8;
            // 
            // _txtMoneyInput
            // 
            this._txtMoneyInput.Location = new System.Drawing.Point(219, 625);
            this._txtMoneyInput.Name = "_txtMoneyInput";
            this._txtMoneyInput.Size = new System.Drawing.Size(312, 31);
            this._txtMoneyInput.TabIndex = 9;
            // 
            // _txtNoteInput
            // 
            this._txtNoteInput.Location = new System.Drawing.Point(219, 679);
            this._txtNoteInput.Name = "_txtNoteInput";
            this._txtNoteInput.Size = new System.Drawing.Size(668, 31);
            this._txtNoteInput.TabIndex = 10;
            // 
            // _btnOutput
            // 
            this._btnOutput.Location = new System.Drawing.Point(457, 386);
            this._btnOutput.Name = "_btnOutput";
            this._btnOutput.Size = new System.Drawing.Size(171, 67);
            this._btnOutput.TabIndex = 11;
            this._btnOutput.Text = "Xuất";
            this._btnOutput.UseVisualStyleBackColor = true;
            this._btnOutput.Click += new System.EventHandler(this._btnOutput_Click);
            // 
            // _btnInput
            // 
            this._btnInput.Location = new System.Drawing.Point(457, 737);
            this._btnInput.Name = "_btnInput";
            this._btnInput.Size = new System.Drawing.Size(171, 67);
            this._btnInput.TabIndex = 12;
            this._btnInput.Text = "Nhập";
            this._btnInput.UseVisualStyleBackColor = true;
            this._btnInput.Click += new System.EventHandler(this._btnInput_Click);
            // 
            // DeviceExpenseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2132, 1008);
            this.Controls.Add(this._btnInput);
            this.Controls.Add(this._btnOutput);
            this.Controls.Add(this._txtNoteInput);
            this.Controls.Add(this._txtMoneyInput);
            this.Controls.Add(this._txtNoteOutPut);
            this.Controls.Add(this._txtMoneyOutPut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._gridExpense);
            this.Name = "DeviceExpenseDialog";
            this.Text = "DeviceExpenseDialog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this._gridExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl _gridExpense;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtMoneyOutPut;
        private System.Windows.Forms.TextBox _txtNoteOutPut;
        private System.Windows.Forms.TextBox _txtMoneyInput;
        private System.Windows.Forms.TextBox _txtNoteInput;
        private System.Windows.Forms.Button _btnOutput;
        private System.Windows.Forms.Button _btnInput;
    }
}