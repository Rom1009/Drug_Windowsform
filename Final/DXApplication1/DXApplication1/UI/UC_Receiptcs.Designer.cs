namespace DXApplication1.UI
{
    partial class UC_Receiptcs
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
            this.gridReceipt = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupDetail = new DevExpress.XtraEditors.GroupControl();
            this.cmbDetail = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDetail)).BeginInit();
            this.groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDetail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReceipt
            // 
            this.gridReceipt.Location = new System.Drawing.Point(0, 0);
            this.gridReceipt.MainView = this.gridView1;
            this.gridReceipt.Name = "gridReceipt";
            this.gridReceipt.Size = new System.Drawing.Size(915, 668);
            this.gridReceipt.TabIndex = 0;
            this.gridReceipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridReceipt.Load += new System.EventHandler(this.gridReceipt_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridReceipt;
            this.gridView1.Name = "gridView1";
            // 
            // groupDetail
            // 
            this.groupDetail.Controls.Add(this.btnSelect);
            this.groupDetail.Controls.Add(this.cmbDetail);
            this.groupDetail.Location = new System.Drawing.Point(958, 175);
            this.groupDetail.Name = "groupDetail";
            this.groupDetail.Size = new System.Drawing.Size(394, 193);
            this.groupDetail.TabIndex = 1;
            this.groupDetail.Text = "Detail";
            // 
            // cmbDetail
            // 
            this.cmbDetail.Location = new System.Drawing.Point(16, 54);
            this.cmbDetail.Name = "cmbDetail";
            this.cmbDetail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDetail.Properties.Items.AddRange(new object[] {
            "Import",
            "Export"});
            this.cmbDetail.Size = new System.Drawing.Size(354, 38);
            this.cmbDetail.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(240, 133);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(142, 47);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // UC_Receiptcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupDetail);
            this.Controls.Add(this.gridReceipt);
            this.Name = "UC_Receiptcs";
            this.Size = new System.Drawing.Size(1417, 668);
            ((System.ComponentModel.ISupportInitialize)(this.gridReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDetail)).EndInit();
            this.groupDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDetail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridReceipt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupDetail;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDetail;
        private System.Windows.Forms.Button btnSelect;
    }
}
