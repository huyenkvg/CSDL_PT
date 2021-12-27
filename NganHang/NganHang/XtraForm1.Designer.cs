
namespace NganHang
{
    partial class XtraForm1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dsPhanManh = new NganHang.dsPhanManh();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new NganHang.dsPhanManhTableAdapters.V_DS_PHANMANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vDSPHANMANHBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // dsPhanManh
            // 
            this.dsPhanManh.DataSetName = "dsPhanManh";
            this.dsPhanManh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.dsPhanManh;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.comboBox1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private dsPhanManh dsPhanManh;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private dsPhanManhTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}