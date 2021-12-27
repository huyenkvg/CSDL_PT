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
    public partial class frmChuyenTien : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenTien()
        {
            InitializeComponent();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

      

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (txtSoTKChuyen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số tài khoản chuyển", "Thông báo !", MessageBoxButtons.OK);
                txtSoTKChuyen.Focus();
                return;
            }
            else if (txtSoTKNhan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số tài khoản nhận", "Thông báo !", MessageBoxButtons.OK);
                txtSoTKNhan.Focus();
                return;
            }
            else if (txtSoTKChuyen.Text.Trim() == txtSoTKNhan.Text.Trim())
            {
                MessageBox.Show("Tài khoản nhận và tài khoản chuyển không được trùng nhau", "Thông báo !", MessageBoxButtons.OK);
                txtSoTKNhan.Focus();
                return;
            }
            else if (txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền cần chuyển", "Thông báo !", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }
            else
            {

                try
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "sp_CHUYENTIEN";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@stkfrom", SqlDbType.NChar).Value = txtSoTKChuyen.Text.Trim();
                    Program.Sqlcmd.Parameters.Add("@stkto", SqlDbType.NChar).Value = txtSoTKNhan.Text.Trim();
                    Program.Sqlcmd.Parameters.Add("@money", SqlDbType.Money).Value = txtSoTien.Text.Trim();
                    Program.Sqlcmd.Parameters.Add("@manv", SqlDbType.NChar).Value = txtMaNV.Text.Trim();
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();


                    if (ret == "0")
                    {
                        MessageBox.Show("Số dư không đủ.", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ret == "1")
                    {
                        txtSoTKChuyen.Text = "";
                        txtSoTKNhan.Text = "";
                        txtSoTien.Text = "";
                        MessageBox.Show("Chuyển tiền thành công", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ret == "2")
                    {
                        MessageBox.Show("Chuyển tiền thất bại",
                             "Xác thực", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ret == "3")
                    {
                        MessageBox.Show("Tài khoản không chuyển tồn tại", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ret == "4")
                    {
                        MessageBox.Show("Tài khoản nhận không tồn tại", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Chuyển tiền thất bại",
                    "Xác thực", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác chuyển tiền?",
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

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmChuyenTien_Load_1(object sender, EventArgs e)
        {
            txtMaNV.Text = Program.username;
            txtHoTen.Text = Program.mHoten;
        }
    }
}