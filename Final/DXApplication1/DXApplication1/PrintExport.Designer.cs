namespace DXApplication1
{
    partial class PrintExport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportExport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportExport
            // 
            this.reportExport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetExport";
            reportDataSource1.Value = this.ExportBindingSource;
            this.reportExport.LocalReport.DataSources.Add(reportDataSource1);
            this.reportExport.LocalReport.ReportEmbeddedResource = "DXApplication1.Export.rdlc";
            this.reportExport.Location = new System.Drawing.Point(0, 0);
            this.reportExport.Name = "reportExport";
            this.reportExport.ServerReport.BearerToken = null;
            this.reportExport.Size = new System.Drawing.Size(1336, 653);
            this.reportExport.TabIndex = 0;
            this.reportExport.Load += new System.EventHandler(this.reportExport_Load);
            // 
            // ExportBindingSource
            // 
            this.ExportBindingSource.DataSource = typeof(DXApplication1.Export);
            // 
            // PrintExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 653);
            this.Controls.Add(this.reportExport);
            this.Name = "PrintExport";
            this.Text = "PrintExport";
            this.Load += new System.EventHandler(this.PrintExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportExport;
        private System.Windows.Forms.BindingSource ExportBindingSource;
    }
}