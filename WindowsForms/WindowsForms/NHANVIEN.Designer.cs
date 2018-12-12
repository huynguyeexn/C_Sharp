namespace WindowsForms
{
    partial class NHANVIEN
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
            this.txt_quequan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dantoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cb_mapb = new System.Windows.Forms.ComboBox();
            this.cb_macv = new System.Windows.Forms.ComboBox();
            this.cb_matdhv = new System.Windows.Forms.ComboBox();
            this.cb_bacluong = new System.Windows.Forms.ComboBox();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(119, 441);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 36;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(605, 441);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 35;
            this.bt_thoat.TabStop = false;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_inds
            // 
            this.bt_inds.Location = new System.Drawing.Point(524, 441);
            this.bt_inds.Name = "bt_inds";
            this.bt_inds.Size = new System.Drawing.Size(75, 33);
            this.bt_inds.TabIndex = 34;
            this.bt_inds.TabStop = false;
            this.bt_inds.Text = "In DS";
            this.bt_inds.UseVisualStyleBackColor = true;
            this.bt_inds.Click += new System.EventHandler(this.bt_inds_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(443, 441);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 33;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(362, 441);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 33);
            this.bt_sua.TabIndex = 32;
            this.bt_sua.TabStop = false;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(281, 441);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 33);
            this.bt_xoa.TabIndex = 31;
            this.bt_xoa.TabStop = false;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(200, 441);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 33);
            this.bt_them.TabIndex = 37;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(37, 241);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(742, 179);
            this.dtgv.TabIndex = 38;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // txt_quequan
            // 
            this.txt_quequan.Location = new System.Drawing.Point(210, 145);
            this.txt_quequan.Name = "txt_quequan";
            this.txt_quequan.Size = new System.Drawing.Size(177, 22);
            this.txt_quequan.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(210, 89);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(177, 22);
            this.txt_hoten.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Họ Tên";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(210, 61);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(177, 22);
            this.txt_manv.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "CẬP NHẬT THÔNG TIN NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dân tộc";
            // 
            // txt_dantoc
            // 
            this.txt_dantoc.Location = new System.Drawing.Point(210, 201);
            this.txt_dantoc.Name = "txt_dantoc";
            this.txt_dantoc.Size = new System.Drawing.Size(177, 22);
            this.txt_dantoc.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "SĐT";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(523, 61);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(177, 22);
            this.txt_sdt.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mã phòng ban";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 24;
            this.label9.Tag = "";
            this.label9.Text = "Mã chức vụ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(100, 173);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 17);
            this.label.TabIndex = 25;
            this.label.Tag = "";
            this.label.Text = "Giới tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Bậc lương";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Mã TĐHV";
            // 
            // ngaysinh
            // 
            this.ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinh.Location = new System.Drawing.Point(210, 118);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(177, 22);
            this.ngaysinh.TabIndex = 39;
            // 
            // cb_mapb
            // 
            this.cb_mapb.FormattingEnabled = true;
            this.cb_mapb.Location = new System.Drawing.Point(523, 87);
            this.cb_mapb.Name = "cb_mapb";
            this.cb_mapb.Size = new System.Drawing.Size(178, 24);
            this.cb_mapb.TabIndex = 40;
            this.cb_mapb.DropDown += new System.EventHandler(this.cb_mapb_DropDown);
            this.cb_mapb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_mapb_KeyDown);
            // 
            // cb_macv
            // 
            this.cb_macv.FormattingEnabled = true;
            this.cb_macv.Location = new System.Drawing.Point(523, 115);
            this.cb_macv.Name = "cb_macv";
            this.cb_macv.Size = new System.Drawing.Size(179, 24);
            this.cb_macv.TabIndex = 40;
            this.cb_macv.DropDown += new System.EventHandler(this.cb_macv_DropDown);
            this.cb_macv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_macv_KeyDown);
            // 
            // cb_matdhv
            // 
            this.cb_matdhv.FormattingEnabled = true;
            this.cb_matdhv.Location = new System.Drawing.Point(523, 143);
            this.cb_matdhv.Name = "cb_matdhv";
            this.cb_matdhv.Size = new System.Drawing.Size(179, 24);
            this.cb_matdhv.TabIndex = 40;
            this.cb_matdhv.DropDown += new System.EventHandler(this.cb_matdhv_DropDown);
            this.cb_matdhv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_matdhv_KeyDown);
            // 
            // cb_bacluong
            // 
            this.cb_bacluong.FormattingEnabled = true;
            this.cb_bacluong.Location = new System.Drawing.Point(523, 172);
            this.cb_bacluong.Name = "cb_bacluong";
            this.cb_bacluong.Size = new System.Drawing.Size(179, 24);
            this.cb_bacluong.TabIndex = 40;
            this.cb_bacluong.DropDown += new System.EventHandler(this.cb_bacluong_DropDown);
            this.cb_bacluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_bacluong_KeyDown);
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(210, 172);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(177, 24);
            this.cb_gioitinh.TabIndex = 41;
            this.cb_gioitinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_gioitinh_KeyDown);
            // 
            // NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 519);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.cb_bacluong);
            this.Controls.Add(this.cb_matdhv);
            this.Controls.Add(this.cb_macv);
            this.Controls.Add(this.cb_mapb);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_quequan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_dantoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "NHANVIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHANVIEN";
            this.Load += new System.EventHandler(this.NHANVIEN_Load);
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
        private System.Windows.Forms.TextBox txt_quequan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dantoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.ComboBox cb_mapb;
        private System.Windows.Forms.ComboBox cb_macv;
        private System.Windows.Forms.ComboBox cb_matdhv;
        private System.Windows.Forms.ComboBox cb_bacluong;
        private System.Windows.Forms.ComboBox cb_gioitinh;
    }
}