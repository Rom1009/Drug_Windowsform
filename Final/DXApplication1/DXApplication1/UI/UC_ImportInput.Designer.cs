namespace DXApplication1.UI
{
    partial class UC_ImportInput
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameID = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimeImport = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gridImportInput = new DevExpress.XtraGrid.GridControl();
            this.gridImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Name ID:";
            // 
            // txtNameID
            // 
            this.txtNameID.Location = new System.Drawing.Point(176, 69);
            this.txtNameID.Name = "txtNameID";
            this.txtNameID.Size = new System.Drawing.Size(193, 30);
            this.txtNameID.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.dateTimeImport);
            this.groupControl1.Controls.Add(this.txtQuantity);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtCategory);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtPrice);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNameID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(891, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 542);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Input Product";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(54, 496);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 23);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Date: ";
            // 
            // dateTimeImport
            // 
            this.dateTimeImport.CustomFormat = "";
            this.dateTimeImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeImport.Location = new System.Drawing.Point(176, 490);
            this.dateTimeImport.Name = "dateTimeImport";
            this.dateTimeImport.Size = new System.Drawing.Size(193, 30);
            this.dateTimeImport.TabIndex = 16;
            this.dateTimeImport.Value = new System.DateTime(2022, 12, 12, 22, 19, 1, 0);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(176, 432);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(193, 30);
            this.txtQuantity.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(54, 439);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(83, 23);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Quantity: ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(176, 364);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(193, 30);
            this.txtDescription.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(54, 371);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(106, 23);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Description: ";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(176, 285);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(193, 30);
            this.txtCategory.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(54, 288);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 23);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Category: ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(176, 207);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(193, 30);
            this.txtPrice.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(54, 214);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 23);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Price: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 133);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 30);
            this.txtName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(54, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 23);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Name: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1131, 628);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 53);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(891, 628);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 53);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gridImportInput
            // 
            this.gridImportInput.Location = new System.Drawing.Point(0, 3);
            this.gridImportInput.MainView = this.gridImport;
            this.gridImportInput.Name = "gridImportInput";
            this.gridImportInput.Size = new System.Drawing.Size(877, 730);
            this.gridImportInput.TabIndex = 7;
            this.gridImportInput.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridImport});
            // 
            // gridImport
            // 
            this.gridImport.GridControl = this.gridImportInput;
            this.gridImport.Name = "gridImport";
            this.gridImport.OptionsView.ShowGroupPanel = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(895, 702);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(415, 60);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // UC_ImportInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridImportInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl1);
            this.Name = "UC_ImportInput";
            this.Size = new System.Drawing.Size(1343, 783);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtNameID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtCategory;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dateTimeImport;
        private DevExpress.XtraGrid.GridControl gridImportInput;
        private DevExpress.XtraGrid.Views.Grid.GridView gridImport;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
        private System.Windows.Forms.Button btnPrint;
    }
}
