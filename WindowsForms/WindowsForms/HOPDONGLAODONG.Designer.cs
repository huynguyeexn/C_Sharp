namespace WindowsForms
{
    partial class HOPDONGLAODONG
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
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_inds = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labbel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.dtp_tungay = new System.Windows.Forms.DateTimePicker();
            this.dtp_denngay = new System.Windows.Forms.DateTimePicker();
            this.cb_loaihd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(59, 419);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 84;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(545, 419);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 81;
            this.bt_thoat.TabStop = false;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_inds
            // 
            this.bt_inds.Location = new System.Drawing.Point(464, 419);
            this.bt_inds.Name = "bt_inds";
            this.bt_inds.Size = new System.Drawing.Size(75, 33);
            this.bt_inds.TabIndex = 80;
            this.bt_inds.TabStop = false;
            this.bt_inds.Text = "In DS";
            this.bt_inds.UseVisualStyleBackColor = true;
            this.bt_inds.Click += new System.EventHandler(this.bt_inds_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(383, 419);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 79;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(302, 419);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 33);
            this.bt_sua.TabIndex = 78;
            this.bt_sua.TabStop = false;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(221, 419);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 33);
            this.bt_xoa.TabIndex = 77;
            this.bt_xoa.TabStop = false;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(140, 419);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 33);
            this.bt_them.TabIndex = 82;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(47, 220);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(597, 179);
            this.dtgv.TabIndex = 83;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Loại hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Mã nhân viên";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(154, 52);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(177, 22);
            this.txt_mahd.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "HỢP ĐỒNG LAO ĐỘNG";
            // 
            // labbel
            // 
            this.labbel.AutoSize = true;
            this.labbel.Location = new System.Drawing.Point(44, 55);
            this.labbel.Name = "labbel";
            this.labbel.Size = new System.Drawing.Size(91, 17);
            this.labbel.TabIndex = 73;
            this.labbel.Text = "Mã hợp đồng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Đến ngày";
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(154, 85);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(177, 24);
            this.cb_manv.TabIndex = 85;
            this.cb_manv.DropDown += new System.EventHandler(this.cb_manv_DropDown);
            this.cb_manv.SelectedIndexChanged += new System.EventHandler(this.cb_manv_SelectedIndexChanged);
            this.cb_manv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_manv_KeyDown);
            // 
            // dtp_tungay
            // 
            this.dtp_tungay.CustomFormat = "dd/MM/yyyy";
            this.dtp_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tungay.Location = new System.Drawing.Point(154, 149);
            this.dtp_tungay.Name = "dtp_tungay";
            this.dtp_tungay.Size = new System.Drawing.Size(177, 22);
            this.dtp_tungay.TabIndex = 86;
            // 
            // dtp_denngay
            // 
            this.dtp_denngay.CustomFormat = "dd/MM/yyyy";
            this.dtp_denngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_denngay.Location = new System.Drawing.Point(154, 182);
            this.dtp_denngay.Name = "dtp_denngay";
            this.dtp_denngay.Size = new System.Drawing.Size(177, 22);
            this.dtp_denngay.TabIndex = 86;
            // 
            // cb_loaihd
            // 
            this.cb_loaihd.FormattingEnabled = true;
            this.cb_loaihd.Items.AddRange(new object[] {
            "Dài hạn",
            "Ngắn hạn"});
            this.cb_loaihd.Location = new System.Drawing.Point(154, 118);
            this.cb_loaihd.Name = "cb_loaihd";
            this.cb_loaihd.Size = new System.Drawing.Size(177, 24);
            this.cb_loaihd.TabIndex = 85;
            this.cb_loaihd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_loaihd_KeyDown);
            // 
            // HOPDONGLAODONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 481);
            this.Controls.Add(this.dtp_denngay);
            this.Controls.Add(this.dtp_tungay);
            this.Controls.Add(this.cb_loaihd);
            this.Controls.Add(this.cb_manv);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labbel);
            this.Name = "HOPDONGLAODONG";
            this.Text = "HOPDONGLAODONG";
            this.Load += new System.EventHandler(this.HOPDONGLAODONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_inds;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labbel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.DateTimePicker dtp_tungay;
        private System.Windows.Forms.DateTimePicker dtp_denngay;
        private System.Windows.Forms.ComboBox cb_loaihd;
    }
}