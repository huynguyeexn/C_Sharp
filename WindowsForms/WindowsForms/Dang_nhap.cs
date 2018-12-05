using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsForms
{

    public partial class Dang_nhap : Form
    {
        
        public Dang_nhap()
        {
            InitializeComponent();

        }
        KETNOICSDL cnn = new KETNOICSDL();
        public void Loaddulieu()
        {
            //string sql = "Select * from dangnhap";
            //data
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void hiengiaodien()
        {
            Main gd = new Main();
            gd.ShowDialog();
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string s = "select * from dangnhap where username='" + txt_tendangnhap.Text + "'";
            DataTable dt = new DataTable();
            dt = cnn.taobang(s);
            string s1 = "select * from dangnhap where password='" + txt_matkhau.Text + "'";
            DataTable dt1 = new DataTable();
            dt1 = cnn.taobang(s1);
            if (dt.Rows.Count!=0 && dt1.Rows.Count!=0)
            {
                Main form_main = new Main();
                form_main.User(txt_tendangnhap.Text);
                Thread th = new Thread(new ThreadStart(hiengiaodien));
                th.Start();
                
                this.Close();
            }
            else
            {

                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txt_tendangnhap.Clear();
                this.txt_matkhau.Clear();
                this.txt_tendangnhap.Focus();
            }
        }

        private void check_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(check_hienmatkhau.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }

        private void Dang_nhap_Load(object sender, EventArgs e)
        {
            txt_tendangnhap.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DANGKY dangky = new DANGKY();
            dangky.Show();
        }

        private void txt_tendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }

        private void txt_tendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }
    }
}
