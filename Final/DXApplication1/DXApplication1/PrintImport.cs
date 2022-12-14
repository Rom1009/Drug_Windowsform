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
    public partial class PrintImport : Form
    {
        public PrintImport()
        {
            InitializeComponent();
        }

        private void PrintImport_Load(object sender, EventArgs e)
        {

            this.reportImport.RefreshReport();
        }

        private void reportImport_Load(object sender, EventArgs e)
        {
            List<Import> list = new List<Import>();
            for (int i = 0; i < UC_ImportInput.newDt.Rows.Count; i++)
            {

                Import ex = new Import();
                ex.ID = UC_ImportInput.newDt.Rows[i][0].ToString();
                ex.Name = UC_ImportInput.newDt.Rows[i][1].ToString();
                ex.Price = int.Parse(UC_ImportInput.newDt.Rows[i][2].ToString());
                ex.Description = UC_ImportInput.newDt.Rows[i][3].ToString();
                ex.Category = UC_ImportInput.newDt.Rows[i][4].ToString();

                ex.total = UC_ImportInput.total;
                list.Add(ex);

            }

            reportImport.LocalReport.ReportPath = "Import.rdlc";
            var source = new ReportDataSource("DataSetImport", list);
            reportImport.LocalReport.DataSources.Clear();
            reportImport.LocalReport.DataSources.Add(source);
            this.reportImport.RefreshReport();
        }
    }
}
