using DevExpress.XtraReports.UI;
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
    public partial class UC_ImportInput : UserControl
    {
        public UC_ImportInput()
        {
            InitializeComponent();
        }
        public static DataTable newDt = new DataTable();
        public static string nameID = "";
        public static int total=0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.LoadDataBase("select * from Product");
            dt.PrimaryKey = new DataColumn[] { dt.Columns["pid"] };
            Program.InsertDatabase("delete Detail where rid = 'R01' and pid = '" + txtNameID.Text + "'");
            if (dt.Rows.Contains(txtNameID.Text) && (txtNameID.Text != "" && txtName.Text != ""  && txtPrice.Text != "" && txtCategory.Text != "" && txtDescription.Text != "" && txtQuantity.Text != ""))
            {
                nameID = txtNameID.Text;

                MessageBox.Show("Product exist");
                Program.InsertDatabase("insert into Detail values('" + txtNameID.Text + "'," + "'R01'" + ",'" + txtQuantity.Text + "')");
                Program.InsertDatabase("Update Product Set stock = stock + " + txtQuantity.Text + " where pid = '" + txtNameID.Text + "'");

                DataTable dt2 = Program.LoadDataBase("select * from Product where pid = '" + txtNameID.Text + "'");
                gridImportInput.DataSource = dt2;
                total += int.Parse(txtPrice.Text)*int.Parse(txtQuantity.Text);
                if (newDt.Rows.Count == 0)
                {
                    newDt.Columns.Add("NameID");
                    newDt.Columns.Add("Name");
                    newDt.Columns.Add("Price");
                    newDt.Columns.Add("Category");
                    newDt.Columns.Add("Description");
                }

                newDt.Rows.Add(new Object[] {
                    txtNameID.Text,
                    txtName.Text,
                    int.Parse(txtPrice.Text),
                    txtCategory.Text,
                    txtDescription.Text,
                });

            }
            else if (!dt.Rows.Contains(txtNameID.Text) && (txtNameID.Text != "" && txtName.Text != "" 
                    && txtPrice.Text != "" && txtCategory.Text != "" && txtDescription.Text != "" && txtQuantity.Text != ""))
            {
                nameID = txtNameID.Text;

                Program.InsertDatabase("insert into Product values('" + txtNameID.Text + "',"
                                                                        + "N'" + txtName.Text + "',"
                                                                        + "''"+ ","
                                                                        + "''" + ","
                                                                        + "''" + ","
                                                                        + txtPrice.Text + ","
                                                                        + "N'" + txtCategory.Text + "',"
                                                                        + "N'" + txtDescription.Text + "',"
                                                                        + "''" + ")");

                Program.InsertDatabase("Update Product Set stock =" + txtQuantity.Text + " where pid = '" + txtNameID.Text + "'");
                total += int.Parse(txtPrice.Text) * int.Parse(txtQuantity.Text);

                if (newDt.Rows.Count == 0)
                {
                    newDt.Columns.Add("NameID");
                    newDt.Columns.Add("Name");
                    newDt.Columns.Add("Price");
                    newDt.Columns.Add("Category");
                    newDt.Columns.Add("Description");
                }

                newDt.Rows.Add(new Object[] { 
                    txtNameID.Text,
                    txtName.Text,
                    int.Parse(txtPrice.Text),
                    txtCategory.Text,
                    txtDescription.Text,
                });

                gridImportInput.DataSource = newDt;
                Program.InsertDatabase("insert into Detail values('" + txtNameID.Text + "'," + "'R01'" + ",'" + txtQuantity.Text + "')");

            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            total = 0;
        }

        
        private void gridImportInput_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            PrintImport p = new PrintImport();
            p.ShowDialog();
        }
    }
}
