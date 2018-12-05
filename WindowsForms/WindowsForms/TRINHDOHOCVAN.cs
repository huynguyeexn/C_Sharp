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

namespace WindowsForms
{
    public partial class TRINHDOHOCVAN : Form
    {
        public TRINHDOHOCVAN()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        public void Loaddulieu()
        {
            string sql = "Select * from TRINHDOHOCVAN";
            dtgv.DataSource = kn.taobang(sql);
        }
        private void TRINHDOHOCVAN_Load(object sender, EventArgs e)
        {
            kn.connect();
            Loaddulieu();
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_matdhv.Text == "" || txt_tentdhv.Text == "" || txt_chuyennganh.Text == "" )
            {
                MessageBox.Show("Dữ liệu nhập vào không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bt_them.Enabled = false;
                string s = "select * from TRINHDOHOCVAN where MATDHV='" + txt_matdhv.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themtdhv(txt_matdhv.Text, txt_tentdhv.Text, txt_chuyennganh.Text);
                    txt_matdhv.ResetText();
                    txt_tentdhv.ResetText();
                    txt_chuyennganh.ResetText();
                    txt_matdhv.Focus();
                    Loaddulieu();
                }
                else
                {
                    MessageBox.Show("Mã TRÌNH ĐỘ HỌC VẤN đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Loaddulieu();
            txt_matdhv.ResetText();
            txt_tentdhv.ResetText();
            txt_chuyennganh.ResetText();
            txt_tentdhv.ResetText();
            this.bt_huy.Enabled = true;
            this.bt_luu.Enabled = true;
            this.bt_them.Enabled = true;
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
                        kn.xoatdhv(chon);
                    }
                    catch
                    {
                        MessageBox.Show("Mã TĐHV đang được sử dụng trong bảng khác", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    Loaddulieu();
                    txt_chuyennganh.ResetText();
                    txt_matdhv.ResetText();
                    txt_tentdhv.ResetText();
                }
                else if (result == DialogResult.No)
                {

                }

            }
            else
            {
                MessageBox.Show("Hãy chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        string chon;

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMATDHV= " + txt_matdhv.Text +
                    "\nTENTDHV= " + txt_tentdhv.Text +
                    "\nCHUYENNGANH= " + txt_chuyennganh.Text, "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suatdhv(chon, txt_matdhv.Text, txt_tentdhv.Text, txt_chuyennganh.Text);
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
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString();
                txt_matdhv.Text = row.Cells[0].Value.ToString();
                txt_tentdhv.Text = row.Cells[1].Value.ToString();
                txt_chuyennganh.Text = row.Cells[2].Value.ToString();
            }
            catch
            {
                chon = null;
            }
        }

        private void bt_inds_Click(object sender, EventArgs e)
        {
            ReportForm.rpTRINHDOHOCVAN rp = new ReportForm.rpTRINHDOHOCVAN();
            rp.Show();
        }

    }
}
