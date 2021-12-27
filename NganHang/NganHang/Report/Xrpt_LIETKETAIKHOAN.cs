using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class Xrpt_LIETKETAIKHOAN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_LIETKETAIKHOAN()
        {
            InitializeComponent();
        }

        public Xrpt_LIETKETAIKHOAN(DateTime tuNgay, DateTime denNgay, String maCN, Boolean tatCa)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denNgay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maCN;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = tatCa;
            this.sqlDataSource1.Fill();
        }
    }
}
