namespace WindowsForms
{
    partial class KHENTHUONGKYLUAT
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
            this.txt_loaiqd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenqd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soqd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labbel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hinhthuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sotien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.dtp_ngayqd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(51, 388);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 84;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(537, 388);
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
            this.bt_inds.Location = new System.Drawing.Point(456, 388);
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
            this.bt_huy.Location = new System.Drawing.Point(375, 388);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 79;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(294, 388);
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
            this.bt_xoa.Location = new System.Drawing.Point(213, 388);
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
            this.bt_them.Location = new System.Drawing.Point(132, 388);
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
            this.dtgv.Location = new System.Drawing.Point(39, 189);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(597, 179);
            this.dtgv.TabIndex = 83;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // txt_loaiqd
            // 
            this.txt_loaiqd.Location = new System.Drawing.Point(456, 56);
            this.txt_loaiqd.Name = "txt_loaiqd";
            this.txt_loaiqd.Size = new System.Drawing.Size(177, 22);
            this.txt_loaiqd.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Loại quyết định";
            // 
            // txt_tenqd
            // 
            this.txt_tenqd.Location = new System.Drawing.Point(151, 112);
            this.txt_tenqd.Name = "txt_tenqd";
            this.txt_tenqd.Size = new System.Drawing.Size(177, 22);
            this.txt_tenqd.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tên quyết định";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Ngày quyết định";
            // 
            // txt_soqd
            // 
            this.txt_soqd.Location = new System.Drawing.Point(151, 56);
            this.txt_soqd.Name = "txt_soqd";
            this.txt_soqd.Size = new System.Drawing.Size(177, 22);
            this.txt_soqd.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "KHEN THƯỞNG VÀ KĨ LUẬT";
            // 
            // labbel
            // 
            this.labbel.AutoSize = true;
            this.labbel.Location = new System.Drawing.Point(36, 59);
            this.labbel.Name = "labbel";
            this.labbel.Size = new System.Drawing.Size(95, 17);
            this.labbel.TabIndex = 73;
            this.labbel.Text = "Số quyết định";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Hình thức";
            // 
            // txt_hinhthuc
            // 
            this.txt_hinhthuc.Location = new System.Drawing.Point(456, 84);
            this.txt_hinhthuc.Name = "txt_hinhthuc";
            this.txt_hinhthuc.Size = new System.Drawing.Size(177, 22);
            this.txt_hinhthuc.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Số tiền";
            // 
            // txt_sotien
            // 
            this.txt_sotien.Location = new System.Drawing.Point(456, 112);
            this.txt_sotien.Name = "txt_sotien";
            this.txt_sotien.Size = new System.Drawing.Size(177, 22);
            this.txt_sotien.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Mã nhân viên";
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(151, 140);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(177, 24);
            this.cb_manv.TabIndex = 85;
            this.cb_manv.DropDown += new System.EventHandler(this.cb_manv_DropDown);
            this.cb_manv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_manv_KeyDown);
            // 
            // dtp_ngayqd
            // 
            this.dtp_ngayqd.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayqd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayqd.Location = new System.Drawing.Point(151, 85);
            this.dtp_ngayqd.Name = "dtp_ngayqd";
            this.dtp_ngayqd.Size = new System.Drawing.Size(177, 22);
            this.dtp_ngayqd.TabIndex = 86;
            // 
            // KHENTHUONGKYLUAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.dtp_ngayqd);
            this.Controls.Add(this.cb_manv);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.txt_loaiqd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sotien);
            this.Controls.Add(this.txt_tenqd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hinhthuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soqd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labbel);
            this.Name = "KHENTHUONGKYLUAT";
            this.Text = "KHEN THƯỞNG KĨ LUẬT";
            this.Load += new System.EventHandler(this.KHENTHUONGKYLUAT_Load);
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
        private System.Windows.Forms.TextBox txt_loaiqd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenqd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soqd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labbel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hinhthuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sotien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.DateTimePicker dtp_ngayqd;
    }
}