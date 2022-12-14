namespace DXApplication1.UI
{
    partial class UC_ExportInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridExportInput = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelto = new DevExpress.XtraEditors.LabelControl();
            this.labelNamePro = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.txtPhoneCus = new System.Windows.Forms.TextBox();
            this.txtAddressCus = new System.Windows.Forms.TextBox();
            this.txtNameID = new System.Windows.Forms.TextBox();
            this.groupPro = new DevExpress.XtraEditors.GroupControl();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupCus = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimeExport = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridExportInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPro)).BeginInit();
            this.groupPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCus)).BeginInit();
            this.groupCus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExportInput
            // 
            this.gridExportInput.Location = new System.Drawing.Point(7, 8);
            this.gridExportInput.MainView = this.gridView1;
            this.gridExportInput.Name = "gridExportInput";
            this.gridExportInput.Size = new System.Drawing.Size(883, 616);
            this.gridExportInput.TabIndex = 0;
            this.gridExportInput.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridExportInput.Load += new System.EventHandler(this.gridImportInput_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridExportInput;
            this.gridView1.Name = "gridView1";
            // 
            // labelTotal
            // 
            this.labelTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelTotal.Appearance.Options.UseFont = true;
            this.labelTotal.Location = new System.Drawing.Point(650, 630);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(89, 42);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total:";
            // 
            // labelto
            // 
            this.labelto.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelto.Appearance.Options.UseFont = true;
            this.labelto.Location = new System.Drawing.Point(758, 630);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(19, 42);
            this.labelto.TabIndex = 2;
            this.labelto.Text = "0";
            // 
            // labelNamePro
            // 
            this.labelNamePro.Location = new System.Drawing.Point(23, 61);
            this.labelNamePro.Name = "labelNamePro";
            this.labelNamePro.Size = new System.Drawing.Size(80, 23);
            this.labelNamePro.TabIndex = 3;
            this.labelNamePro.Text = "Name Id:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 23);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Name:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 23);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Phone:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 206);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 23);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Address:";
            // 
            // txtNameCus
            // 
            this.txtNameCus.Location = new System.Drawing.Point(138, 43);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(187, 30);
            this.txtNameCus.TabIndex = 7;
            // 
            // txtPhoneCus
            // 
            this.txtPhoneCus.Location = new System.Drawing.Point(138, 124);
            this.txtPhoneCus.Name = "txtPhoneCus";
            this.txtPhoneCus.Size = new System.Drawing.Size(187, 30);
            this.txtPhoneCus.TabIndex = 8;
            // 
            // txtAddressCus
            // 
            this.txtAddressCus.Location = new System.Drawing.Point(138, 199);
            this.txtAddressCus.Name = "txtAddressCus";
            this.txtAddressCus.Size = new System.Drawing.Size(187, 30);
            this.txtAddressCus.TabIndex = 9;
            // 
            // txtNameID
            // 
            this.txtNameID.Location = new System.Drawing.Point(138, 58);
            this.txtNameID.Name = "txtNameID";
            this.txtNameID.Size = new System.Drawing.Size(187, 30);
            this.txtNameID.TabIndex = 10;
            // 
            // groupPro
            // 
            this.groupPro.Controls.Add(this.labelControl2);
            this.groupPro.Controls.Add(this.dateTimeExport);
            this.groupPro.Controls.Add(this.txtQuantity);
            this.groupPro.Controls.Add(this.labelControl1);
            this.groupPro.Controls.Add(this.btnSelect);
            this.groupPro.Controls.Add(this.txtNameID);
            this.groupPro.Controls.Add(this.labelNamePro);
            this.groupPro.Location = new System.Drawing.Point(928, 19);
            this.groupPro.Name = "groupPro";
            this.groupPro.Size = new System.Drawing.Size(370, 253);
            this.groupPro.TabIndex = 11;
            this.groupPro.Text = "Product";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(138, 103);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(187, 30);
            this.txtQuantity.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 23);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Quantity:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(241, 201);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(123, 37);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupCus
            // 
            this.groupCus.Controls.Add(this.txtAddressCus);
            this.groupCus.Controls.Add(this.txtPhoneCus);
            this.groupCus.Controls.Add(this.txtNameCus);
            this.groupCus.Controls.Add(this.labelControl6);
            this.groupCus.Controls.Add(this.labelControl5);
            this.groupCus.Controls.Add(this.labelControl4);
            this.groupCus.Location = new System.Drawing.Point(928, 293);
            this.groupCus.Name = "groupCus";
            this.groupCus.Size = new System.Drawing.Size(370, 276);
            this.groupCus.TabIndex = 12;
            this.groupCus.Text = "Customer";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1158, 626);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 46);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(928, 626);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 46);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimeExport
            // 
            this.dateTimeExport.CustomFormat = "";
            this.dateTimeExport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExport.Location = new System.Drawing.Point(145, 156);
            this.dateTimeExport.Name = "dateTimeExport";
            this.dateTimeExport.Size = new System.Drawing.Size(187, 30);
            this.dateTimeExport.TabIndex = 14;
            this.dateTimeExport.Value = new System.DateTime(2022, 12, 12, 22, 19, 1, 0);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 162);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 23);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Date: ";
            // 
            // UC_ExportInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupCus);
            this.Controls.Add(this.groupPro);
            this.Controls.Add(this.labelto);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.gridExportInput);
            this.Name = "UC_ExportInput";
            this.Size = new System.Drawing.Size(1321, 689);
            ((System.ComponentModel.ISupportInitialize)(this.gridExportInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPro)).EndInit();
            this.groupPro.ResumeLayout(false);
            this.groupPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCus)).EndInit();
            this.groupCus.ResumeLayout(false);
            this.groupCus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridExportInput;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelTotal;
        private DevExpress.XtraEditors.LabelControl labelto;
        private DevExpress.XtraEditors.LabelControl labelNamePro;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.TextBox txtPhoneCus;
        private System.Windows.Forms.TextBox txtAddressCus;
        private System.Windows.Forms.TextBox txtNameID;
        private DevExpress.XtraEditors.GroupControl groupPro;
        private DevExpress.XtraEditors.GroupControl groupCus;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dateTimeExport;
    }
}
