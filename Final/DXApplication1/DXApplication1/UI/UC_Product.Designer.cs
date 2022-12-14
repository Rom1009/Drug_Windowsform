namespace DXApplication1.UI
{
    partial class UC_Product
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
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProduct
            // 
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.Location = new System.Drawing.Point(0, 0);
            this.gridProduct.MainView = this.gridView1;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(1440, 836);
            this.gridProduct.TabIndex = 0;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridProduct.Load += new System.EventHandler(this.gridProduct_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridProduct;
            this.gridView1.Name = "gridView1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 614);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(227, 61);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gridProduct);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(1440, 836);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnLoad;
    }
}
