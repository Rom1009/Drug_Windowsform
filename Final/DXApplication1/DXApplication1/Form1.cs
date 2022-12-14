using DevExpress.XtraBars;
using DXApplication1.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        UC_Receiptcs ucReceiptcs;
        UC_Product ucProduct;
        UC_ExportInput ucExportInput;
        UC_ImportInput ucImportInput;

        private void mnAccountant_Click(object sender, EventArgs e)
        {
      
        }

        private void mnDetail_Click(object sender, EventArgs e)
        {
            if (ucReceiptcs == null)
            {
                ucReceiptcs = new UC_Receiptcs();
                ucReceiptcs.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucReceiptcs);
                ucReceiptcs.BringToFront();
            }
            else
            {
                ucReceiptcs.BringToFront();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank for using our app");
            Application.Exit();
        }

        private void PrintProduct_Click(object sender, EventArgs e)
        {

        }

        private void ImportInput_Click(object sender, EventArgs e)
        {
            if (ucExportInput == null)
            {
                ucExportInput = new UC_ExportInput();
                ucExportInput.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucExportInput);
                ucExportInput.BringToFront();
            }
            else
            {
                ucExportInput.BringToFront();
            }
        }

        private void ImportInput_Click_1(object sender, EventArgs e)
        {
            if (ucImportInput == null)
            {
                ucImportInput = new UC_ImportInput();
                ucImportInput.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucImportInput);
                ucImportInput.BringToFront();
            }
            else
            {
                ucImportInput.BringToFront();
            }
        }

        private void proDuctList_Click(object sender, EventArgs e)
        {
            if (ucProduct == null)
            {
                ucProduct = new UC_Product();
                ucProduct.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucProduct);
                ucProduct.BringToFront();
            }
            else
            {
                ucProduct.BringToFront();
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintImport p = new PrintImport();
            p.ShowDialog();
        }
    }
}
