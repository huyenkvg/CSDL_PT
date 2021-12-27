using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NganHang
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }
        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmNhanVien));
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Close();

                Program.FrmDangNhap.Visible = true;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDangKy));
        }

       

        private void btnGuiRut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmGuiTien));
        }

        private void btnChuyentie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmChuyenTien));
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGiaoDich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.frmRpDaoDich));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTaikhaonkhachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmTaiKhoan));
        }

        private void btnCapnhatKh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmKhachHang));
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_LIETKETAIKHOAN));
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Frpt_LIETKEKHACHHANG));
        }
    }
}
