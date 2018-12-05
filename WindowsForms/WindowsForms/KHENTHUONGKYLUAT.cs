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
    public partial class KHENTHUONGKYLUAT : Form
    {
        public KHENTHUONGKYLUAT()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        SqlConnection con;
        public void Loaddulieu()
        {
            string sql = "Select * from KHENTHUONGKYLUAT";
            dtgv.DataSource = kn.taobang(sql);
        }
        public void Loadcombobox()
        {
            SqlCommand cn = new SqlCommand("Select MANV from NHANVIEN", con);
            SqlDataAdapter ad = new SqlDataAdapter(cn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "NHANVIEN");
            cb_manv.DataSource = ds.Tables[0];
            cb_manv.DisplayMember = "MANV";
            cb_manv.ValueMember = "MANV";

            cb_manv.SelectedIndex = -1;
        }
        private void KHENTHUONGKYLUAT_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Loaddulieu();
            Loadcombobox();
            dtp_ngayqd.Value = DateTime.Now;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_hinhthuc.Text == "" || txt_loaiqd.Text == "" || txt_soqd.Text == "" || txt_sotien.Text == "" || txt_tenqd.Text == "" || cb_manv.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string s = "select * from KHENTHUONGKYLUAT where SOQD='" + txt_soqd.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themktkl(txt_soqd.Text, dtp_ngayqd.Value.ToString("yyyy/MM/dd"), cb_manv.Text, txt_tenqd.Text, txt_loaiqd.Text, txt_hinhthuc.Text, txt_sotien.Text);
                    bt_them_Click(sender, e);
                    Loaddulieu();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            txt_hinhthuc.ResetText();
            txt_loaiqd.ResetText();
            txt_soqd.ResetText();
            txt_sotien.ResetText();
            txt_tenqd.ResetText();
            cb_manv.SelectedIndex = -1;
            dtp_ngayqd.Value = DateTime.Now;
            txt_soqd.Focus();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.xoaktkl(chon);
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
                chon = row.Cells[0].Value.ToString().Trim();
                txt_soqd.Text = row.Cells[0].Value.ToString().Trim();

                string dateInput = row.Cells[1].Value.ToString().Trim();
                DateTime dt = DateTime.Parse(dateInput);
                dtp_ngayqd.Value = dt;

                cb_manv.SelectedValue = row.Cells[2].Value.ToString().Trim();
                txt_tenqd.Text = row.Cells[3].Value.ToString().Trim();
                txt_loaiqd.Text = row.Cells[4].Value.ToString().Trim();
                txt_hinhthuc.Text = row.Cells[5].Value.ToString().Trim();
                txt_sotien.Text = row.Cells[6].Value.ToString().Trim();
            }
            catch
            {
                chon = null;
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nSOQD = " + txt_soqd.Text +
                    "\nNGAYQD = " + dtp_ngayqd.Text +
                    "\nMANV = " + cb_manv.SelectedItem.ToString() +
                    "\nTENQD = " + txt_tenqd.Text +
                    "\nLOAIQD = " + txt_loaiqd.Text +
                    "\nHINHTHUC = " + txt_hinhthuc.Text +
                    "\nSOTIEN = " + txt_sotien.Text
                   , "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suaktkl(chon, txt_soqd.Text, dtp_ngayqd.Value.ToString("yyyy/MM/dd"), cb_manv.GetItemText(cb_manv.SelectedItem), txt_tenqd.Text, txt_loaiqd.Text, txt_hinhthuc.Text, txt_sotien.Text);
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

        private void cb_manv_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cb_manv_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void bt_inds_Click(object sender, EventArgs e)
        {
            ReportForm.rpKHENTHUONGKYLUAT rp = new ReportForm.rpKHENTHUONGKYLUAT();
            rp.Show();
        }
    }
}
