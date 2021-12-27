using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class Frpt_LIETKETAIKHOAN : Form
    {
        DateTime dateTo;
        DateTime dateFrom;
        DateTime now = DateTime.Now;
        Boolean chontatCa = false;
        String maCN;
        public Frpt_LIETKETAIKHOAN()
        {
            InitializeComponent();
        }

        private void Frpt_LIETKETAIKHOAN_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false; //không cần ktra các ràng buộc
            this.chiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiNhanhTableAdapter.Fill(this.DS.ChiNhanh);

            maCN = ((DataRowView)bdsCN[0])["MACN"].ToString().Trim();
            
            cmbChiNhanh.DataSource = Program.bdsDSPM;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup.Trim() == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;
                checkBoxTatCaCN.Enabled = true; 
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                checkBoxTatCaCN.Enabled = false;
            }
            dayfrom.DateTime = now;
            dayto.DateTime = now;

        }


        private void dayfrom_EditValueChanged(object sender, EventArgs e)
        {
            dateFrom = dayfrom.DateTime;
        }

        private void dayto_EditValueChanged(object sender, EventArgs e)
        {
            dateTo = dayto.DateTime;
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
                this.chiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiNhanhTableAdapter.Fill(this.DS.ChiNhanh);
                 maCN = ((DataRowView)bdsCN[0])["MACN"].ToString().Trim();
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(dateFrom.CompareTo(dateTo) == 1)
            {
                MessageBox.Show("Mốc thời gian từ ngày phải nhỏ hơn đến ngày!", "", MessageBoxButtons.OK);
                return;
            }
            Xrpt_LIETKETAIKHOAN rpt = new Xrpt_LIETKETAIKHOAN(dateFrom,dateTo,maCN,chontatCa);
            rpt.lblChiNhanh.Text = cmbChiNhanh.Text;
            rpt.lblTuNgay.Text = dateFrom + "";
            rpt.lblDenNgay.Text = dateTo + "";
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void checkBoxTatCaCN_CheckedChanged(object sender, EventArgs e)
        {
            chontatCa = checkBoxTatCaCN.Checked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
