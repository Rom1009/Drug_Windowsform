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
    public partial class UC_Product : UserControl
    {
        public UC_Product()
        {
            InitializeComponent();
        }

        private void gridProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = Program.LoadDataBase("select * from Product");
            gridProduct.DataSource = dt;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.LoadDataBase("select * from Product");
            gridProduct.DataSource = dt;
        }
    }
}
