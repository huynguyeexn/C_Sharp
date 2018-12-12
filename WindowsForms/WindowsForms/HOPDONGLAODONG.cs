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
    public partial class HOPDONGLAODONG : Form
    {
        public HOPDONGLAODONG()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        SqlConnection con;
        public void Loaddulieu()
        {
            string sql = "Select * from HOPDONGLAODONG";
            dtgv.DataSource = kn.taobang(sql);
        }
        public void Loadcombobox()
        {
            SqlCommand cn = new SqlCommand("Select manv from nhanvien", con);
            SqlDataAdapter ad = new SqlDataAdapter(cn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "nhanvien");
            cb_manv.DataSource = ds.Tables[0];
            cb_manv.DisplayMember = "manv";
            cb_manv.ValueMember = "manv";
        }
        private void HOPDONGLAODONG_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Loadcombobox();
            Loaddulieu();
            bt_them_Click(sender, e);
        }
        private void cb_manv_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text == "" || cb_manv.Text == "" || cb_loaihd.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string s = "select * from HOPDONGLAODONG where MAHD='" + txt_mahd.Text + "'";
                string s1 = "select * from HOPDONGLAODONG where MANV='" + cb_manv.Text + "'";
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                dt = kn.taobang(s);
                dt1 = kn.taobang(s1);
                if (dt.Rows.Count == 0 && dt1.Rows.Count == 0)
                {
                    kn.themhd(txt_mahd.Text, cb_manv.Text, cb_loaihd.Text, dtp_tungay.Value.ToString("yyyy/MM/dd"), dtp_denngay.Value.ToString("yyyy/MM/dd"));
                    bt_them_Click(sender, e);
                    Loaddulieu();
                }
                else if (dt.Rows.Count != 0 && dt1.Rows.Count == 0)
                {
                    MessageBox.Show("Mã hợp đồng đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }
                else if (dt.Rows.Count == 0 && dt1.Rows.Count != 0)
                {
                    MessageBox.Show("Nhân viên đã có hợp đồng, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void cb_manv_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cb_loaihd_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.xoahd(chon);
                    Loaddulieu();
                    bt_them_Click(sender, e);
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
        string chon;

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString();
                txt_mahd.Text = row.Cells[0].Value.ToString().Trim();
                cb_manv.SelectedValue = row.Cells[1].Value.ToString().Trim();
                if (row.Cells[2].Value.ToString().Trim() == "Dài hạn")
                {
                    cb_loaihd.SelectedIndex = 0;
                }
                else
                {
                    cb_loaihd.SelectedIndex = 1;
                }
                string dateInput = row.Cells[3].Value.ToString().Trim();
                DateTime dt = DateTime.Parse(dateInput); dtp_tungay.Value = dt;
                string dateInput1 = row.Cells[4].Value.ToString().Trim();
                DateTime dt1 = DateTime.Parse(dateInput1); dtp_denngay.Value = dt1;
            }
            catch
            {
                chon = null;
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMAHD = " + txt_mahd.Text +
                    "\nMANV = " + cb_manv.Text +
                    "\nLOAIHD = " + cb_loaihd.Text +
                    "\nTUNGAY = " + dtp_tungay.Text +
                    "\nDENNGAY = " + dtp_denngay.Text
                   , "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suahd(chon, txt_mahd.Text, cb_manv.Text, cb_loaihd.Text, dtp_tungay.Value.ToString("yyyy/MM/dd"), dtp_denngay.Value.ToString("yyyy/MM/dd"));
                    Loaddulieu();
                    bt_them_Click(sender, e);
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

        private void bt_them_Click(object sender, EventArgs e)
        {
            txt_mahd.ResetText();
            cb_loaihd.ResetText();
            cb_manv.ResetText();
            dtp_tungay.Value = DateTime.Now;
            dtp_denngay.Value = DateTime.Now;
            txt_mahd.Focus();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_inds_Click(object sender, EventArgs e)
        {
            ReportForm.rpHOPDONGLAODONG rp = new ReportForm.rpHOPDONGLAODONG();
            rp.Show();
        }

        private void cb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
