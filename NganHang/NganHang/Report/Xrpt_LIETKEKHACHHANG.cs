using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class Xrpt_LIETKEKHACHHANG : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_LIETKEKHACHHANG()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
