using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace WindowsForms
{
    public partial class DANGKY : Form
    {
        public DANGKY()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string s = "select * from dangnhap where username='" + txt_tendangnhap.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_tendangnhap.Clear();
                this.txt_matkhau.Clear();
                this.txt_nhaplaimatkhau.Clear();
                this.txt_tendangnhap.Focus();
            }
            else if(txt_matkhau.Text == "" || txt_nhaplaimatkhau.Text == "" || txt_tendangnhap.Text == "")
            {
                MessageBox.Show("Vui lòng ghi đầy đủ thông tin", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txt_matkhau.Text != txt_nhaplaimatkhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không giống nhau", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                kn.themdk(txt_tendangnhap.Text,txt_matkhau.Text);
                this.Close();
                MessageBox.Show("Bạn đã đăng ký thành công, hãy đăng nhập", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DANGKY_Load(object sender, EventArgs e)
        {
            kn.connect();
        }

        private void check_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hienmatkhau.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
                txt_nhaplaimatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
                txt_nhaplaimatkhau.UseSystemPasswordChar = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
