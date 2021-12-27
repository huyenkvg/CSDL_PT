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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        String maCN;
        Boolean isAddNV = false;
        Boolean ChuyenCN = false;
        Int32 vitriNV = 0;
        Int32 vitriNVT = 0;
        string maNVXoa = "";

        Stack<String> undoStack;

        String insertBack;
        String updateBack;
        String deleteBack;
        String ho, ten, diaChi, gioiTinh, sdt;
        int drop = 0;
        /*private class DataCN
        {
            public string TENCN { get; set; }
            public string DIEUKIEN { get; set; }
            public string TENPUB { get; set; }
            public string TENSERVER { get; set; }
        }*/
        public frmNhanVien()
        {
            InitializeComponent();
        }
        void checkStackUndo()
        {
            if (undoStack.Count > 0)
                btnPhucHoi.Enabled = true;
            else
                btnPhucHoi.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void trangThaiXoaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mANVTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                mANVTextEdit.Focus();
            }
            else if (hOTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                hOTextEdit.Focus();
            }
            else if (tENTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                tENTextEdit.Focus();
            }
            else if (sODTTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                sODTTextEdit.Focus();
            }
            else if (!Program.isValidInputSDT.IsMatch(sODTTextEdit.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng !", "Thông báo !", MessageBoxButtons.OK);
                sODTTextEdit.Focus();
            }
            else if (dIACHITextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
               dIACHITextEdit.Focus();
            }
            else
            {
                if(ChuyenCN==true)
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "sp_KIEMTRAMANHANVIENTONTAI";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = mANVTextEdit.Text;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "1")
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    str_sp = "sp_NVChuyenChiNhanh";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = maNVXoa;
                    Program.Sqlcmd.Parameters.Add("@MANVMOI", SqlDbType.VarChar).Value = mANVTextEdit.Text;
                    Program.Sqlcmd.Parameters.Add("@ MACNCHUYENDEN", SqlDbType.VarChar).Value = mANVTextEdit.Text;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();

                    if (ret == "NV01")
                    {
                        MessageBox.Show("HELLO WORLD", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }

                    str_sp = "sp_NVChuyenChiNhanh";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = maNVXoa;
                    Program.Sqlcmd.Parameters.Add("@MANVMOI", SqlDbType.VarChar).Value = mANVTextEdit.Text;
                    Program.Sqlcmd.Parameters.Add("@ MACNCHUYENDEN", SqlDbType.VarChar).Value = mANVTextEdit.Text;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();

                    // còn xóa login nữa
                    

                    if (ret == "-1")
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {

                        MessageBox.Show("Chuyển Chi nhánh thành công. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                        ChuyenCN = false;
                }    
                if (isAddNV == true)
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "sp_KIEMTRAMANHANVIENTONTAI";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = mANVTextEdit.Text;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "1")
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        try
                        {
                            nhanVienBindingSource.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                            nhanVienBindingSource.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                            this.nhanVienTableAdapter.Update(this.nGANHANGDataSet.NhanVien);         // cập nhật dl từ dataset về database thông qua tableadapter                           
                            isAddNV = false;
                            nhanVienGridControl.Enabled = true;
                            btnThem.Enabled = btnXoa.Enabled  = true;
                            mANVTextEdit.ReadOnly = true;
                            MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
                            insertBack = "delete from NhanVien where MANV = '" + mANVTextEdit.Text + "'";
                            undoStack.Push(insertBack);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi nhân viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }

                }
                else
                {

                    try
                    {
                        nhanVienBindingSource.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                       nhanVienBindingSource.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                        this.nhanVienTableAdapter.Update(this.nGANHANGDataSet.NhanVien);         // cập nhật dl từ dataset về database thông qua tableadapter
                        isAddNV = false;
                        nhanVienGridControl.Enabled = true;
                        btnThem.Enabled = btnXoa.Enabled = true;
                        mANVTextEdit.ReadOnly = true;
                        MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi nhân viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }

                }

            }
            checkStackUndo();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nhanVienBindingSource.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa hoàn toàn nhân viên này?", "Thông báo !", MessageBoxButtons.YesNo);
                if (ds == DialogResult.Yes)
                {
                    //SP_KTNHANVIENDUOCXOA
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "SP_KTNHANVIENDUOCXOA";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = maNVXoa;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "1")
                    {
                        DialogResult ds1 = MessageBox.Show("Nhân viên này đã có tài khoản, bạn có chắc muốn xóa?\nThao tác này không thể hoàn tác!!", "Thông báo !", MessageBoxButtons.YesNo);
                        if (ds1 == DialogResult.Yes)
                        {
                            try
                            {
                                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                                String str_sp1 = "SP_XOALOGIN";
                                Program.Sqlcmd = Program.conn.CreateCommand();
                                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                                Program.Sqlcmd.CommandText = str_sp1;
                                Program.Sqlcmd.Parameters.Add("@TENUSER", SqlDbType.VarChar).Value =mANVTextEdit.Text.Trim();
                                Program.Sqlcmd.Parameters.Add("@GROUPNAME", SqlDbType.VarChar).Value = Program.mGroup;
                                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                                Program.Sqlcmd.ExecuteNonQuery();
                                String ret1 = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                                if (ret1 == "0")
                                {
                                    MessageBox.Show("Bạn không có quyền này!!", "Thông báo !", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {

                                    nhanVienBindingSource.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                                    nhanVienBindingSource.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                                    this.nhanVienTableAdapter.Update(this.nGANHANGDataSet.NhanVien);
                                    MessageBox.Show("Xóa thành công!", "Thông báo !", MessageBoxButtons.OK);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi xóa login. Xóa thất bại" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                            }

                        }

                    }
                    else
                    {

                        updateBack = "update NhanVien set HO = N'" + ho + "', " +
                       "TEN = N'" + ten + "' , " +
                       "DIACHI = N'" + diaChi + "' , " +
                       "PHAI = '" + gioiTinh + "' , " +
                       "SODT = N'" + sdt + "' , " +
                       "MACN = N'" + maCN + "' , " +
                       "TrangThaiXoa = '" + drop + "' " +
                       "WHERE MANV = '" + mANVTextEdit.Text.Trim() + "';";
                        MessageBox.Show(updateBack, "sp undo UPDATE ", MessageBoxButtons.OK);
                        try
                        {
                            DataRowView drv = (DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position];
                            ho = drv["HO"].ToString();
                            ten = drv["TEN"].ToString();
                            diaChi = drv["DIACHI"].ToString();
                            gioiTinh = drv["PHAI"].ToString();
                            sdt = drv["SODT"].ToString();
                            drop = (int)drv["TrangThaiXoa"];
                            deleteBack = "insert into NhanVien(MANV,HO,TEN,DIACHI,PHAI,SODT,MACN,TrangThaiXoa)";
                            deleteBack += " values('" + mANVTextEdit.Text + "' , " + "N'" + ho + "', " +
                            "N'" + ten + "' , " +
                            "N'" + diaChi + "' , " +
                            "N'" + gioiTinh + "' , " +
                            "N'" + sdt + "' , " +
                            "'" + maCN + "' , " +
                            "'" + drop + "' )";
                            undoStack.Push(deleteBack);
                            MessageBox.Show(deleteBack,"sp undo DELETE ",MessageBoxButtons.OK);
                            nhanVienBindingSource.RemoveCurrent();         //xóa row đang chọn ra khỏi dataset
                            this.nhanVienTableAdapter.Update(this.nGANHANGDataSet.NhanVien);
                            nhanVienBindingSource.Position = 0;
                            MessageBox.Show("Xóa thành công!", "Thông báo !", MessageBoxButtons.OK);
                            checkStackUndo();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa nhân viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            nGANHANGDataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
            if (Program.KetNoi() == 0) return;
            String lenh = undoStack.Pop();
            int n = Program.ExecSqlNonQuery(lenh);
            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);
            checkStackUndo();
        }

        private void btnChuyenChiNhanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            nhanVienGridControl.Enabled = false;
            trangThaiXoaCheckBox.Checked = true;
            mACNComboBox.Enabled = true;
            ChuyenCN = true;
            mACNComboBox.DataSource = null;
            mACNComboBox.DataSource = Program.bdsDSPM;
            mACNComboBox.DisplayMember = "TENCN";
            mACNComboBox.ValueMember = "DIEUKIEN";
            mACNComboBox.Enabled = true;


        }

        private void mANVTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //maCN = ((DataRowView)Program.bdsDSPM[cbbChiNhanh.SelectedIndex])["DIEUKIEN"].ToString().Trim();
          //  mACNComboBox.SelectedText = maCN;
          //  =(DataRowView)Program.bdsDSPM[cbbChiNhanh.SelectedIndex].
        }

        private void btnHuyThaoTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (isAddNV==true) { 
             isAddNV = false;
           nhanVienBindingSource.Position = vitriNVT;
            nhanVienBindingSource.RemoveAt(nhanVienBindingSource.Count-1);
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = btnChuyenChiNhanh.Enabled = true;
            btnHuyThaoTac.Enabled = true;
           
            nhanVienGridControl.Enabled = true;
            btnHuyThaoTac.Enabled = false;
            checkStackUndo();
            }
                

            if (ChuyenCN==true)
            {
                nhanVienGridControl.Enabled = true;
                trangThaiXoaCheckBox.Checked = false;
                mACNComboBox.Enabled = false;

                nhanVienBindingSource.Position = vitriNV;
             
                btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = btnChuyenChiNhanh.Enabled = true;
                //btnHuyThaoTac.Enabled = true;

                nhanVienGridControl.Enabled = true;
                btnHuyThaoTac.Enabled = false;
                checkStackUndo();

            }
        }

        private void hOTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            
            undoStack = new Stack<string>(10);
            nGANHANGDataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);

          //  BindingSource allcn = new BindingSource();
          //allcn = Program.bdsDSPM;
          //  allcn.AddNew();
          //  allcn.DataSource[allcn.Count-1]["TENPUB"] = "ALL";
            //allcn.[allcn.Count]["DIEUKIEN"] = "ALL";
            //allcn.[allcn.Count]["TENCN"] = "ALL";
            //allcn.[allcn.Count]["TENSERVER"] = "ALL";

            // DataCN data = new DataCN();
            // data.DIEUKIEN = "all";
            // data.TENCN = "all";
            //data.TENPUB = "all";
            //data.TENSERVER = "all";

            //    allcn.Insert(3,dat);



            cbbChiNhanh.DataSource = Program.bdsDSPM;

          

           // Program.bdsDSPM.AddNew("C1", "C2", "C3", "V4");
          //  DataRow dr = new DataRow();
            //dr[""] = "Select";
            //dr[""] = " ";
            //dr[" "] = "";
           // Program.bdsDSPM.Add(dr);
           // cbbChiNhanh.DataSourc
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
        //    cbbChiNhanh.Items.Insert(3, "Copenhagen");
            //cbbChiNhanh.SelectedIndex = Program.mChinhanh;

           //  mACNComboBox.DataSource = Program.bdsDSPM;
          //   mACNComboBox.DisplayMember = "TENCN";
          //   mACNComboBox.ValueMember = "TENSERVER";
            // mACNComboBox.SelectedText = cbbChiNhanh.SelectedItem.ToString();
            mACNComboBox.Enabled = false;
            if (Program.mGroup.Trim() == "NganHang")
            {

                //Program.bdsDSPM.Filter = "TENCN <> 'Khách Hàng' ";
                
                cbbChiNhanh.SelectedText = maCN;
            }
            else
            {
                cbbChiNhanh.SelectedText = maCN;
                cbbChiNhanh.Enabled = false;
            }
            nGANHANGDataSet.EnforceConstraints = false;
            
           // maCN = ((DataRowView)bsdCN[0])["MACN"].ToString().Trim();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
           // this.nhanVienTableAdapter.Fill(this.d.NhanVien);
           /* maNVXoa = ((DataRowView)bdsDSNV[bdsDSNV.Position])["MANV"].ToString().Trim();
            if (maNVXoa == Program.username)
            {
                btnXoaNV.Enabled = false;
            }*/
            DataRowView drv = (DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position];
            ho = drv["HO"].ToString();
            ten = drv["TEN"].ToString();
            diaChi = drv["DIACHI"].ToString();
            gioiTinh = drv["PHAI"].ToString();
            sdt = drv["SODT"].ToString();
            drop = (int)drv["TrangThaiXoa"];
            mANVTextEdit.ReadOnly = true;
          //  mACNComboBox.Enabled = false;
            maCN = cbbChiNhanh.SelectedText;
         //  ma.ReadOnly = true;
            checkStackUndo();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mACNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            mANVTextEdit.Focus();
            vitriNV = nhanVienBindingSource.Position;
            vitriNVT = nhanVienBindingSource.Position;
            //  MessageBox.Show(" " + vitriNV);
            isAddNV = true;
         
            nhanVienBindingSource.AddNew();

            nhanVienGridControl.Enabled = false;
            //txtCN.Text = maCN;
            trangThaiXoaCheckBox.Checked = false;
            pHAIComboBox.Items.Add("Nam");
            pHAIComboBox.Items.Add("Nữ");

           //  pHAIComboBox.SelectedIndex = 1;
           // pHAIComboBox.SelectedIndex = 0;
            /*checkXoaNV.Enabled = false;*/
            //      MessageBox.Show(" " + Program.mChinhanh);
            //  
            DataRowView drv =(DataRowView)Program.bdsDSPM[Program.mChinhanh];
            mACNComboBox.SelectedText = drv["DIEUKIEN"].ToString();

            mACNComboBox.Enabled = false;
            mANVTextEdit.ReadOnly = false;
            mANVTextEdit.Focus();
           
           // MessageBox.Show(" "+ Program.mChinhanh);
            
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled =btnChuyenChiNhanh.Enabled=false;
            btnHuyThaoTac.Enabled = true;

        }
    }
}