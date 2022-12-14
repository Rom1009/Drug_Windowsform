namespace DXApplication1
{
    partial class PrintImport
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
            this.reportImport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportImport
            // 
            this.reportImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportImport.LocalReport.ReportEmbeddedResource = "DXApplication1.Import.rdlc";
            this.reportImport.Location = new System.Drawing.Point(0, 0);
            this.reportImport.Name = "reportImport";
            this.reportImport.ServerReport.BearerToken = null;
            this.reportImport.Size = new System.Drawing.Size(1265, 686);
            this.reportImport.TabIndex = 0;
            this.reportImport.Load += new System.EventHandler(this.reportImport_Load);
            // 
            // PrintImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 686);
            this.Controls.Add(this.reportImport);
            this.Name = "PrintImport";
            this.Text = "PrintImport";
            this.Load += new System.EventHandler(this.PrintImport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportImport;
    }
}