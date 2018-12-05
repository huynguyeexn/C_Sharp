using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class LUONG : Form
    {
        public LUONG()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        public void Loaddulieu()
        {
            string sql = "Select * from LUONG";
            dtgv.DataSource = kn.taobang(sql);
        }
        private void LUONG_Load(object sender, EventArgs e)
        {
            kn.connect();
            Loaddulieu();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            txt_bacluong.ResetText();
            txt_hspc.ResetText();
            txt_luongcb.ResetText();
            txt_hsluong.ResetText();
            txt_bacluong.Focus();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        kn.xoaluong(chon);
                    }
                    catch
                    {
                        MessageBox.Show("Bậc lương đang được sử dụng trong bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Loaddulieu();
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }
        
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nBACLUONG = " + txt_bacluong.Text +
                    "\nLUONGCB= " + txt_luongcb.Text +
                    "\nHSLUONG= " + txt_hsluong.Text +
                    "\nHSPC= " + txt_hspc.Text, "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.sualuong(chon, txt_bacluong.Text, txt_luongcb.Text, txt_hsluong.Text, txt_hspc.Text);
                    Loaddulieu();
                }
                else if (result == DialogResult.No)
                {

                }

            }
            else
            {
                MessageBox.Show("Hãy chọn dòng cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_bacluong.Text == "" || txt_hsluong.Text == "" || txt_hspc.Text == "" || txt_luongcb.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập vào không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bt_them.Enabled = false;
                string s = "select * from LUONG where BACLUONG='" + txt_bacluong.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themluong(txt_bacluong.Text,txt_luongcb.Text, txt_hsluong.Text, txt_hspc.Text);
                    txt_bacluong.ResetText();
                    txt_luongcb.ResetText();
                    txt_hsluong.ResetText();
                    txt_hspc.ResetText();
                    txt_bacluong.Focus();
                    Loaddulieu();
                }
                else
                {
                    MessageBox.Show("BẬC LUONG đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        string chon;
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString();
                txt_bacluong.Text = row.Cells[0].Value.ToString();
                txt_luongcb.Text = row.Cells[1].Value.ToString();
                txt_hsluong.Text = row.Cells[2].Value.ToString();
                txt_hspc.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                chon = null;
            }
        }

        private void bt_inds_Click(object sender, EventArgs e)
        {
            ReportForm.rpLUONG rp = new ReportForm.rpLUONG();
            rp.Show();
        }
    }
}
