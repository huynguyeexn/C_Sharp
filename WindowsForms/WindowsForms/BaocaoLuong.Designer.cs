namespace WindowsForms
{
    partial class BaocaoLuong
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
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_maphongban = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sonv = new System.Windows.Forms.TextBox();
            this.txt_tongluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(52, 205);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(562, 186);
            this.dtgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phòng ban";
            // 
            // cb_maphongban
            // 
            this.cb_maphongban.FormattingEnabled = true;
            this.cb_maphongban.Location = new System.Drawing.Point(148, 71);
            this.cb_maphongban.Name = "cb_maphongban";
            this.cb_maphongban.Size = new System.Drawing.Size(121, 24);
            this.cb_maphongban.TabIndex = 1;
            this.cb_maphongban.SelectedIndexChanged += new System.EventHandler(this.cb_maphongban_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(202, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "BÁO CÁO LƯƠNG";
            // 
            // txt_sonv
            // 
            this.txt_sonv.Location = new System.Drawing.Point(148, 117);
            this.txt_sonv.Name = "txt_sonv";
            this.txt_sonv.Size = new System.Drawing.Size(121, 22);
            this.txt_sonv.TabIndex = 3;
            this.txt_sonv.TextChanged += new System.EventHandler(this.txt_sonv_TextChanged);
            this.txt_sonv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sonv_KeyDown);
            // 
            // txt_tongluong
            // 
            this.txt_tongluong.Location = new System.Drawing.Point(148, 161);
            this.txt_tongluong.Name = "txt_tongluong";
            this.txt_tongluong.Size = new System.Drawing.Size(121, 22);
            this.txt_tongluong.TabIndex = 3;
            this.txt_tongluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sonv_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng lương";
            // 
            // BaocaoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 416);
            this.Controls.Add(this.txt_tongluong);
            this.Controls.Add(this.txt_sonv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_maphongban);
            this.Controls.Add(this.dtgv);
            this.Name = "BaocaoLuong";
            this.Text = "BaocaoLuong";
            this.Load += new System.EventHandler(this.BaocaoLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_maphongban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sonv;
        private System.Windows.Forms.TextBox txt_tongluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}