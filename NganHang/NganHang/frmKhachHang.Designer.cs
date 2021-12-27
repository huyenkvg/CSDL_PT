
namespace NganHang
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label pHAILabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new NganHang.DS();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new NganHang.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.ngayCap = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new NganHang.DSTableAdapters.ChiNhanhTableAdapter();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            pHAILabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(43, 16);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(40, 13);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(393, 16);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(393, 59);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(43, 94);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(43, 55);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(58, 13);
            nGAYCAPLabel.TabIndex = 8;
            nGAYCAPLabel.Text = "NGAYCAP:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(45, 140);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(38, 13);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "SODT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(388, 145);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 13);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "MACN:";
            // 
            // pHAILabel1
            // 
            pHAILabel1.AutoSize = true;
            pHAILabel1.Location = new System.Drawing.Point(393, 102);
            pHAILabel1.Name = "pHAILabel1";
            pHAILabel1.Size = new System.Drawing.Size(35, 13);
            pHAILabel1.TabIndex = 16;
            pHAILabel1.Text = "PHAI:";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(933, 54);
            this.panelControl1.TabIndex = 4;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(93, 17);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(294, 21);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Hiệu chỉnh";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Phục hồi";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);

            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 10;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(933, 45);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.barButtonItem6,
            this.btnReload,
            this.barButtonItem8,
            this.btnThoat,
            this.btnThem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 641);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(933, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 596);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(933, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 596);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.DS;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcKH
            // 
            this.gcKH.DataSource = this.bdsKH;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKH.Location = new System.Drawing.Point(0, 99);
            this.gcKH.MainView = this.gridView1;
            this.gcKH.MenuManager = this.barManager1;
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(933, 220);
            this.gcKH.TabIndex = 9;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.GridControl = this.gcKH;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(pHAILabel1);
            this.panelControl2.Controls.Add(this.cmbPhai);
            this.panelControl2.Controls.Add(mACNLabel);
            this.panelControl2.Controls.Add(this.txtMACN);
            this.panelControl2.Controls.Add(sODTLabel);
            this.panelControl2.Controls.Add(this.txtSDT);
            this.panelControl2.Controls.Add(nGAYCAPLabel);
            this.panelControl2.Controls.Add(this.ngayCap);
            this.panelControl2.Controls.Add(dIACHILabel);
            this.panelControl2.Controls.Add(this.txtDiaChi);
            this.panelControl2.Controls.Add(tENLabel);
            this.panelControl2.Controls.Add(this.txtTEN);
            this.panelControl2.Controls.Add(hOLabel);
            this.panelControl2.Controls.Add(this.txtHO);
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Controls.Add(this.txtCMND);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 319);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(933, 322);
            this.panelControl2.TabIndex = 10;
            // 
            // cmbPhai
            // 
            this.cmbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "PHAI", true));
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbPhai.Location = new System.Drawing.Point(453, 94);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(157, 21);
            this.cmbPhai.TabIndex = 17;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(453, 140);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(157, 21);
            this.txtMACN.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "SODT", true));
            this.txtSDT.Location = new System.Drawing.Point(116, 137);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(146, 21);
            this.txtSDT.TabIndex = 11;
            // 
            // ngayCap
            // 
            this.ngayCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "NGAYCAP", true));
            this.ngayCap.EditValue = null;
            this.ngayCap.Location = new System.Drawing.Point(116, 52);
            this.ngayCap.MenuManager = this.barManager1;
            this.ngayCap.Name = "ngayCap";
            this.ngayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCap.Size = new System.Drawing.Size(146, 20);
            this.ngayCap.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(116, 94);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(146, 21);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(453, 55);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(157, 21);
            this.txtTEN.TabIndex = 5;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(453, 13);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(157, 21);
            this.txtHO.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(116, 13);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(146, 21);
            this.txtCMND.TabIndex = 1;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCN
            // 
            this.bdsCN.DataMember = "ChiNhanh";
            this.bdsCN.DataSource = this.DS;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 661);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcKH);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsKH;
        private DS DS;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtHO;
        private System.Windows.Forms.TextBox txtSDT;
        private DevExpress.XtraEditors.DateEdit ngayCap;
        private System.Windows.Forms.ComboBox cmbPhai;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource bdsCN;
        private DSTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
    }
}