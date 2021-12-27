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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dsPhanManh.V_DS_PHANMANH);

        }
    }
}