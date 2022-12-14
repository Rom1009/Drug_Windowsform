using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DXApplication1.UI
{
    public partial class UC_ExportInput : UserControl
    {
        public UC_ExportInput()
        {
            InitializeComponent();
        }

        public static DataTable newDt = new DataTable();

        public static int total ;
        private void gridImportInput_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrintExport p = new PrintExport();
            p.ShowDialog(); 
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            DataTable dt = Program.LoadDataBase("select * from Product");

            total = int.Parse(labelto.Text);
            for (int i =0; i < dt.Rows.Count; i++)
            {
                String name = dt.Rows[i][0].ToString();
                String price = dt.Rows[i][5].ToString();
                Program.InsertDatabase("delete Detail where rid = 'R02' and pid = '" + txtNameID.Text + "'");
                
                if (name == txtNameID.Text)
                {
                    int stock = int.Parse(dt.Rows[i][2].ToString());
                    if (stock > 0)
                    {
                        String a = "select * from Product where pid = '" + txtNameID.Text + "'";
                        DataTable dt1 = Program.LoadDataBase(a);
                        total += int.Parse(price) * int.Parse(txtQuantity.Text);

                        labelto.Text = total.ToString();

                        Program.InsertDatabase("insert into Detail values('" + txtNameID.Text + "'," + "'R02'" + ",'" + txtQuantity.Text + "')");
                        Program.InsertDatabase("Update Product Set stock = stock - " + txtQuantity.Text + " where pid = '" + txtNameID.Text + "'");
                        if (newDt.Rows.Count == 0)
                        {
                            newDt.Columns.Add("ID Product");
                            newDt.Columns.Add("Date");
                            newDt.Columns.Add("Name Customer");
                            newDt.Columns.Add("Phone Customer");
                            newDt.Columns.Add("Address Customer");

                        }

                        newDt.Rows.Add(new Object[] {
                        txtNameID.Text,
                        dateTimeExport.Text,
                        txtNameCus.Text,
                        txtPhoneCus.Text,
                        txtAddressCus.Text,
                        });


                        gridExportInput.DataSource = newDt;
                        break;
                    }
                    else if(stock <= 0)
                    {
                        MessageBox.Show("Don't enough to export");
                        break;

                    }


                }
                else if (name != txtNameID.Text){
                    MessageBox.Show("This item is currently not available");
                    break;
                }

            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            labelto.Text = "0";
            txtAddressCus.Text = "";
            txtNameCus.Text = "";
            txtPhoneCus.Text = "";
        }
    }
}
