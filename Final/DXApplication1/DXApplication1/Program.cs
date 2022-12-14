using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DXApplication1
{

    internal static class Program
    {
        public static string strConn = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static void InsertDatabase(string query)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
        }
        public static DataTable LoadDataBase(string query) {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            conn.Close();

            //MessageBox.Show("Nodata");
            return new DataTable();
        }
        [STAThread]
        static void Main()
        {
            strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}