using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private String nameServerDN;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.v_DS_PHANMANHTableAdapter.Fill(this.dsPhanManh.V_DS_PHANMANH);
            Program.bdsDSPM = this.vDSPHANMANHBindingSource;

            Program.servername = cbbChiNhanh.SelectedValue.ToString();
            nameServerDN = Program.servername;
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue != null)
            {
                Program.servername = cbbChiNhanh.SelectedValue.ToString();
                nameServerDN = Program.servername;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng.", "Báo lỗi đăng nhập",
                    MessageBoxButtons.OK);
                txt_username.Focus();
                return;
            }
            if (txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu đăng nhập không được rỗng.", "Báo lỗi đăng nhập",
                    MessageBoxButtons.OK);
                txt_username.Focus();
                return;
            }

            Program.mlogin = txt_username.Text;
            Program.password = txt_password.Text;
            Program.servername = nameServerDN;
            if (Program.KetNoi() == 0)
                return;
            Program.mChinhanh = cbbChiNhanh.SelectedIndex;// 0: Bến Thành ,  1: Tân Định
            Program.connstrDN = Program.connstr;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            // MessageBox.Show("Đăng nhập thành công.", "", MessageBoxButtons.OK);
            //SqlDataReader myReader;
            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;


            if (Program.myReader.Read())
            {
                Program.username = Program.myReader.GetString(0);
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
            }
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn vui lòng xem lại!", "", MessageBoxButtons.OK);
                return;
            }


            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh = new frmMain();
            Program.frmChinh.MANV.Text = "Mã nhân viên: " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ và tên: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;

            Program.frmChinh.Show();
            Program.FrmDangNhap.Visible = false;
            txt_username.Text = "Username";
            txt_password.Text = "Password";
        }
    }
}