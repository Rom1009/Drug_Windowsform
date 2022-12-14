using DXApplication1.UI;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class PrintExport : Form
    {
        public PrintExport()
        {
            InitializeComponent();
        }

        private void PrintExport_Load(object sender, EventArgs e)
        {

            this.reportExport.RefreshReport();
        }

        private void reportExport_Load(object sender, EventArgs e)
        {
            List<Export> list = new List<Export>();
            for (int i = 0; i < UC_ExportInput.newDt.Rows.Count; i++)
            {

                Export ex = new Export();
                ex.NameID = UC_ExportInput.newDt.Rows[i][0].ToString();
                ex.Date = UC_ExportInput.newDt.Rows[i][1].ToString();
                ex.nameCus = UC_ExportInput.newDt.Rows[i][2].ToString();
                ex.phoneCus = UC_ExportInput.newDt.Rows[i][3].ToString();
                ex.addressCus = UC_ExportInput.newDt.Rows[i][4].ToString();
                ex.total = UC_ExportInput.total;
                list.Add(ex);

            }

            reportExport.LocalReport.ReportPath = "Export.rdlc";
            var source = new ReportDataSource("DataSetExport", list);
            reportExport.LocalReport.DataSources.Clear();
            reportExport.LocalReport.DataSources.Add(source);
            this.reportExport.RefreshReport();
        }
    }
}
