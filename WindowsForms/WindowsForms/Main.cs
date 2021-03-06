﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void chứcVựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CHUCVU().Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DOIMATKHAU().Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DANGKY().Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NHANVIEN().Show();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CHAMCONG().Show();
        }

        private void hợpĐồngLaoĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HOPDONGLAODONG().Show();
        }

        private void khenThưởngKỹLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KHENTHUONGKYLUAT().Show();

        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LUONG().Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PHONGBAN().Show();
        }

        private void thờiGianCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new THOIGIANCONGTAC().Show();
        }

        private void trìnhĐộHọcVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TRINHDOHOCVAN().Show();
        }

        private void lươngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new BaocaoLuong().Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
               this.Close();
        }
        
        public static string username = null;
        public void User(string u)
        {
            username = u;
        }
        public string getUsername()
        {
            return username;
        }
        public void Main_Load(object sender, EventArgs e)
        {
            usernameToolStripMenuItem.Text = "Xin chào! "+username.ToString();
        }
        public void hiengiaodien()
        {
            Dang_nhap gd = new Dang_nhap();
            gd.ShowDialog();
        }
        private bool dang_xuat = false;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(hiengiaodien));
            th.Start();
            dang_xuat = true;
            this.Close();
        }

        private void lươngTheoChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TK_luong_theoCV().Show();
        }

        public void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dang_xuat == true){ 
                e.Cancel = false;
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
    
}
