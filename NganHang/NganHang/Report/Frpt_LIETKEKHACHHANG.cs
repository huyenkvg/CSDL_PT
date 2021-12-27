using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class Frpt_LIETKEKHACHHANG : Form
    {
        public Frpt_LIETKEKHACHHANG()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void Frpt_LIETKEKHACHHANG_Load(object sender, EventArgs e)
        {
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            cmbChiNhanh.DataSource = Program.bdsDSPM;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup.Trim() == "NGANHANG")
            {
              
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Xrpt_LIETKEKHACHHANG rpt = new Xrpt_LIETKEKHACHHANG();
            rpt.lblChiNhanh.Text = cmbChiNhanh.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void khachHangBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
