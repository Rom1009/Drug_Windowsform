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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.LoadDataBase("select * from Accountant");
            if (dt.Rows[0][2].ToString() == txtuserName.Text && dt.Rows[0][0].ToString() == txtpassWord.Text)
            {
                Hide();
                Form1 frm = new Form1();
                frm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Just admin can log in");
            }
        }
    }
}
