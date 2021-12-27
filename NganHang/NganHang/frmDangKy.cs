using DevExpress.XtraBars;
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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        String nLogin = "";
        String nPass = "";
        // String nUserName = "";
        String nRole = "";
        String trangThaiXoa;
        private class Data
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);
           if (Program.mGroup == "NganHang")
            {
                cmbRole.Items.Add("NganHang");
               // cmbRole.Items.Add("CHINHANH");
            }
            else if (Program.mGroup == "ChiNhanh")
            {
                cmbRole.Items.Add("ChiNhanh");
            }

            //cmbRole.SelectedIndex = 0;
            txtMK.Properties.UseSystemPasswordChar = true;
            txtNhapLai.Properties.UseSystemPasswordChar = true;

        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {
         //   txtHoTenNV.Text = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["HO"].ToString().Trim() + " " + ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["TEN"].ToString().Trim();
           // txtMaNV.Text = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString().Trim();
            //trangThaiXoa = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["TrangThaiXoa"].ToString().Trim();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (trangThaiXoa == "1")
            {
                MessageBox.Show("Nhân viên này đã xóa không thể tạo login", "Thông báo !", MessageBoxButtons.OK);
                txtTK.Focus();
                return;
            }
            if (txtTK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo !", MessageBoxButtons.OK);
                txtTK.Focus();
                return;
            }
            else if (txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                txtMK.Focus();
                return;
            }
            else if (txtNhapLai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                txtMK.Focus();
                return;
            }
            else if (txtMK.Text.Trim() != txtNhapLai.Text.Trim())
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu chưa trùng khớp", "Thông báo !", MessageBoxButtons.OK);
                txtMK.Focus();
                return;
            }
            else if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else
            {
                nLogin = txtTK.Text.Trim();
                nPass = txtMK.Text.Trim();
                nRole = cmbRole.Text.Trim();

                try
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "sp_TAOTAIKHOAN";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@tendangnhap", SqlDbType.NChar).Value = nLogin;
                    Program.Sqlcmd.Parameters.Add("@matkhau", SqlDbType.NChar).Value = nPass;
                    Program.Sqlcmd.Parameters.Add("@tennguoidung", SqlDbType.NChar).Value = txtMaNV.Text;
                    Program.Sqlcmd.Parameters.Add("@phanquyen", SqlDbType.NChar).Value = nRole;
                    Program.Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo Login thành công !", "Thông báo !", MessageBoxButtons.OK);
                    txtTK.Text = "";
                    txtNhapLai.Text = "";
                    txtMaNV.Text = "";
                   // txtHoTenNV.Text = "";
                    txtMK.Text = "";
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("server principal"))
                    {
                        MessageBox.Show("Login name bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ex.Message.Contains("User, group, or role"))
                    {
                        MessageBox.Show("Nhân viên này đã được tạo login. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                     "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void checkedShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.Properties.UseSystemPasswordChar = (checkedShowPass.Checked) ? false : true;
            txtNhapLai.Properties.UseSystemPasswordChar = (checkedShowPass.Checked) ? false : true;
        }
    }
}