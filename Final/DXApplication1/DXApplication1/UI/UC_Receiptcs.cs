using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.UI
{
    public partial class UC_Receiptcs : UserControl
    {
        public UC_Receiptcs()
        {
            InitializeComponent();
        }

        private void gridReceipt_Load(object sender, EventArgs e)
        {
            DataTable dt = Program.LoadDataBase("exec receiptDetail");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           if (cmbDetail.Text == "Import")
            {
                DataTable dt = Program.LoadDataBase("exec Import");
                gridReceipt.DataSource = dt;
            }
            else if (cmbDetail.Text == "Export")
            {
                DataTable dt = Program.LoadDataBase("exec Export");
                gridReceipt.DataSource = dt;
            }
        }
    }
}
