
namespace NganHang
{
    partial class Frpt_LIETKETAIKHOAN
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
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dayfrom = new DevExpress.XtraEditors.DateEdit();
            this.dayto = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.DS = new NganHang.DS();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.chiNhanhTableAdapter = new NganHang.DSTableAdapters.ChiNhanhTableAdapter();
            this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxTatCaCN = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayfrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayfrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayto.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(219, 27);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(342, 21);
            this.cmbChiNhanh.TabIndex = 3;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi nhánh";
            // 
            // dayfrom
            // 
            this.dayfrom.EditValue = null;
            this.dayfrom.Location = new System.Drawing.Point(213, 116);
            this.dayfrom.Name = "dayfrom";
            this.dayfrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dayfrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dayfrom.Size = new System.Drawing.Size(146, 20);
            this.dayfrom.TabIndex = 4;
            this.dayfrom.EditValueChanged += new System.EventHandler(this.dayfrom_EditValueChanged);
            // 
            // dayto
            // 
            this.dayto.EditValue = null;
            this.dayto.Location = new System.Drawing.Point(461, 116);
            this.dayto.Name = "dayto";
            this.dayto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dayto.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dayto.Size = new System.Drawing.Size(142, 20);
            this.dayto.TabIndex = 5;
            this.dayto.EditValueChanged += new System.EventHandler(this.dayto_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đến ngày:";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(302, 183);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = this.chiNhanhTableAdapter;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCN
            // 
            this.bdsCN.DataMember = "ChiNhanh";
            this.bdsCN.DataSource = this.DS;
            // 
            // checkBoxTatCaCN
            // 
            this.checkBoxTatCaCN.AutoSize = true;
            this.checkBoxTatCaCN.Location = new System.Drawing.Point(219, 70);
            this.checkBoxTatCaCN.Name = "checkBoxTatCaCN";
            this.checkBoxTatCaCN.Size = new System.Drawing.Size(128, 17);
            this.checkBoxTatCaCN.TabIndex = 10;
            this.checkBoxTatCaCN.Text = "Tất cả các chi nhánh";
            this.checkBoxTatCaCN.UseVisualStyleBackColor = true;
            this.checkBoxTatCaCN.CheckedChanged += new System.EventHandler(this.checkBoxTatCaCN_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(486, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frpt_LIETKETAIKHOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 530);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.checkBoxTatCaCN);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayto);
            this.Controls.Add(this.dayfrom);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.label1);
            this.Name = "Frpt_LIETKETAIKHOAN";
            this.Text = "Frpt_LIETKETAIKHOAN";
            this.Load += new System.EventHandler(this.Frpt_LIETKETAIKHOAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayfrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayfrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayto.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dayfrom;
        private DevExpress.XtraEditors.DateEdit dayto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreview;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private System.Windows.Forms.BindingSource bdsCN;
        private System.Windows.Forms.CheckBox checkBoxTatCaCN;
        private System.Windows.Forms.Button btnThoat;
    }
}