namespace WindowsForms
{
    partial class LUONG
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
            this.labbel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bacluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_luongcb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hsluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hspc = new System.Windows.Forms.TextBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_inds = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // labbel
            // 
            this.labbel.AutoSize = true;
            this.labbel.Location = new System.Drawing.Point(21, 60);
            this.labbel.Name = "labbel";
            this.labbel.Size = new System.Drawing.Size(71, 17);
            this.labbel.TabIndex = 57;
            this.labbel.Text = "Bậc lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "CẬP NHẬT THÔNG TIN BẬC LƯƠNG";
            // 
            // txt_bacluong
            // 
            this.txt_bacluong.Location = new System.Drawing.Point(131, 60);
            this.txt_bacluong.Name = "txt_bacluong";
            this.txt_bacluong.Size = new System.Drawing.Size(177, 22);
            this.txt_bacluong.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Lương cơ bản";
            // 
            // txt_luongcb
            // 
            this.txt_luongcb.Location = new System.Drawing.Point(131, 88);
            this.txt_luongcb.Name = "txt_luongcb";
            this.txt_luongcb.Size = new System.Drawing.Size(177, 22);
            this.txt_luongcb.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Hệ số lương";
            // 
            // txt_hsluong
            // 
            this.txt_hsluong.Location = new System.Drawing.Point(131, 116);
            this.txt_hsluong.Name = "txt_hsluong";
            this.txt_hsluong.Size = new System.Drawing.Size(177, 22);
            this.txt_hsluong.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Hệ số phụ cấp";
            // 
            // txt_hspc
            // 
            this.txt_hspc.Location = new System.Drawing.Point(131, 144);
            this.txt_hspc.Name = "txt_hspc";
            this.txt_hspc.Size = new System.Drawing.Size(177, 22);
            this.txt_hspc.TabIndex = 58;
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(25, 181);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(597, 179);
            this.dtgv.TabIndex = 66;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(118, 380);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 33);
            this.bt_them.TabIndex = 65;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(199, 380);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 33);
            this.bt_xoa.TabIndex = 60;
            this.bt_xoa.TabStop = false;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(280, 380);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 33);
            this.bt_sua.TabIndex = 61;
            this.bt_sua.TabStop = false;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(361, 380);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 62;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // bt_inds
            // 
            this.bt_inds.Location = new System.Drawing.Point(442, 380);
            this.bt_inds.Name = "bt_inds";
            this.bt_inds.Size = new System.Drawing.Size(75, 33);
            this.bt_inds.TabIndex = 63;
            this.bt_inds.TabStop = false;
            this.bt_inds.Text = "In DS";
            this.bt_inds.UseVisualStyleBackColor = true;
            this.bt_inds.Click += new System.EventHandler(this.bt_inds_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(523, 380);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 64;
            this.bt_thoat.TabStop = false;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(37, 380);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 67;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // LUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.txt_hspc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_hsluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_luongcb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bacluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labbel);
            this.Name = "LUONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUONG";
            this.Load += new System.EventHandler(this.LUONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labbel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bacluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_luongcb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hsluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hspc;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_inds;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_luu;
    }
}