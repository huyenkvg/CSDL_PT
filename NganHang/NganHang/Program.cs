using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace NganHang
{
    static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand Sqlcmd = new SqlCommand();
        public static String connstr;

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String database = "NGANHANG";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String connstrDN;
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;
        public static String mCN = "";
        public static BindingSource bdsDSPM = new BindingSource();
        public static frmMain frmChinh;
        public static frmDangNhap FrmDangNhap;
        public static Regex isValidInputSDT = new Regex(@"^((09(\d){8})|(08(\d){8})|(03(\d){8})|(01(\d){9}))$");
        public static Regex isValidInputCMNDSTK = new Regex(@"^\d{9}$");
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                MessageBox.Show(Program.conn.ConnectionString);
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            MessageBox.Show(strLenh);
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader(); return myReader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmDangNhap = new frmDangNhap();
            Application.Run(FrmDangNhap);

        }
    }
}
