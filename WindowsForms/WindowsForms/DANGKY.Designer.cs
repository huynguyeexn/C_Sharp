namespace WindowsForms
{
    partial class DANGKY
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.check_hienmatkhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(182, 234);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(101, 35);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangky
            // 
            this.btn_dangky.Location = new System.Drawing.Point(51, 234);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(101, 35);
            this.btn_dangky.TabIndex = 13;
            this.btn_dangky.Text = "Đăng ký";
            this.btn_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(138, 97);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(179, 22);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(138, 53);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(181, 22);
            this.txt_tendangnhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đăng ký hệ thống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // txt_nhaplaimatkhau
            // 
            this.txt_nhaplaimatkhau.Location = new System.Drawing.Point(138, 146);
            this.txt_nhaplaimatkhau.Name = "txt_nhaplaimatkhau";
            this.txt_nhaplaimatkhau.Size = new System.Drawing.Size(179, 22);
            this.txt_nhaplaimatkhau.TabIndex = 3;
            this.txt_nhaplaimatkhau.UseSystemPasswordChar = true;
            // 
            // check_hienmatkhau
            // 
            this.check_hienmatkhau.AutoSize = true;
            this.check_hienmatkhau.Location = new System.Drawing.Point(138, 190);
            this.check_hienmatkhau.Name = "check_hienmatkhau";
            this.check_hienmatkhau.Size = new System.Drawing.Size(121, 21);
            this.check_hienmatkhau.TabIndex = 19;
            this.check_hienmatkhau.TabStop = false;
            this.check_hienmatkhau.Text = "Hiện mật khẩu";
            this.check_hienmatkhau.UseVisualStyleBackColor = false;
            this.check_hienmatkhau.CheckedChanged += new System.EventHandler(this.check_hienmatkhau_CheckedChanged);
            // 
            // DANGKY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 293);
            this.Controls.Add(this.check_hienmatkhau);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.txt_nhaplaimatkhau);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DANGKY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANGKY";
            this.Load += new System.EventHandler(this.DANGKY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nhaplaimatkhau;
        private System.Windows.Forms.CheckBox check_hienmatkhau;
    }
}