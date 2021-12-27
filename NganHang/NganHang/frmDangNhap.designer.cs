
namespace NganHang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPhanManh = new NganHang.dsPhanManh();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.v_DS_PHANMANHTableAdapter = new NganHang.dsPhanManhTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new NganHang.dsPhanManhTableAdapters.TableAdapterManager();
            this.v_DS_PHANMANHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI NHÁNH";
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DataSource = this.vDSPHANMANHBindingSource;
            this.cbbChiNhanh.DisplayMember = "TENCN";
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(249, 67);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(309, 21);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.ValueMember = "TENSERVER";
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.dsPhanManh;
            // 
            // dsPhanManh
            // 
            this.dsPhanManh.DataSetName = "dsPhanManh";
            this.dsPhanManh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(180, 129);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(249, 137);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(309, 21);
            this.txt_username.TabIndex = 18;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(249, 195);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(309, 21);
            this.txt_password.TabIndex = 19;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(273, 252);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_DangNhap.TabIndex = 20;
            this.btn_DangNhap.Text = "ĐĂNG NHẬP";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(427, 251);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 21;
            this.btn_Thoat.Text = "THOÁT";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = NganHang.dsPhanManhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DS_PHANMANHGridControl
            // 
            this.v_DS_PHANMANHGridControl.DataSource = this.vDSPHANMANHBindingSource;
            this.v_DS_PHANMANHGridControl.Location = new System.Drawing.Point(687, 54);
            this.v_DS_PHANMANHGridControl.MainView = this.gridView1;
            this.v_DS_PHANMANHGridControl.Name = "v_DS_PHANMANHGridControl";
            this.v_DS_PHANMANHGridControl.Size = new System.Drawing.Size(300, 220);
            this.v_DS_PHANMANHGridControl.TabIndex = 21;
            this.v_DS_PHANMANHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.v_DS_PHANMANHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 340);
            this.Controls.Add(this.v_DS_PHANMANHGridControl);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbbChiNhanh);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private dsPhanManh dsPhanManh;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private dsPhanManhTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private dsPhanManhTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_DS_PHANMANHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}