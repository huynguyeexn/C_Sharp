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
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        SqlConnection con;
        public void Loaddulieu()
        {
            string sql = "Select * from NHANVIEN";
            dtgv.DataSource = kn.taobang(sql);
        }
        public void Loadcombobox()
        {
            
            SqlCommand cn = new SqlCommand("Select macv, tencv from chucvu", con);
            SqlDataAdapter ad = new SqlDataAdapter(cn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "chucvu");
            cb_macv.DataSource = ds.Tables[0];
            cb_macv.DisplayMember = "macv";
            cb_macv.ValueMember = "macv";

            SqlCommand cn1 = new SqlCommand("Select MAPB, TENPB from PHONGBAN", con);
            SqlDataAdapter ad1 = new SqlDataAdapter(cn1);
            DataSet ds1 = new DataSet();
            ad1.Fill(ds1, "PHONGBAN");
            cb_mapb.DataSource = ds1.Tables[0];
            cb_mapb.DisplayMember = "MAPB";
            cb_mapb.ValueMember = "MAPB";

            SqlCommand cn2 = new SqlCommand("Select MATDHV, TENTDHV from TRINHDOHOCVAN", con);
            SqlDataAdapter ad2 = new SqlDataAdapter(cn2);
            DataSet ds2 = new DataSet();
            ad2.Fill(ds2, "TRINHDOHOCVAN");
            cb_matdhv.DataSource = ds2.Tables[0];
            cb_matdhv.DisplayMember = "MATDHV";
            cb_matdhv.ValueMember = "MATDHV";

            SqlCommand cn3 = new SqlCommand("Select BACLUONG from LUONG", con);
            SqlDataAdapter ad3 = new SqlDataAdapter(cn3);
            DataSet ds3 = new DataSet();
            ad3.Fill(ds3, "LUONG");
            cb_bacluong.DataSource = ds3.Tables[0];
            cb_bacluong.DisplayMember = "BACLUONG";
            cb_bacluong.ValueMember = "BACLUONG";

            cb_gioitinh.SelectedIndex = 0;
        }
        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Loaddulieu();
            Loadcombobox();
            ngaysinh.Value = DateTime.Now;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            
            if (txt_hoten.Text == "" || txt_dantoc.Text == "" || txt_manv.Text == "" || txt_quequan.Text == "" || txt_sdt.Text == "" || cb_bacluong.Text == "" || cb_gioitinh.Text == "" || cb_macv.Text == "" || cb_mapb.Text == "" || cb_matdhv.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string s = "select * from NHANVIEN where MANV='" + txt_manv.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themnv(txt_manv.Text, txt_hoten.Text, ngaysinh.Value.ToString("yyyy/MM/dd"), txt_quequan.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), txt_dantoc.Text, txt_sdt.Text, cb_mapb.GetItemText(cb_mapb.SelectedItem), cb_macv.GetItemText(cb_macv.SelectedItem), cb_matdhv.GetItemText(cb_matdhv.SelectedItem), cb_bacluong.GetItemText(cb_bacluong.SelectedItem));
                    txt_dantoc.ResetText();
                    txt_hoten.ResetText();
                    txt_manv.ResetText();
                    txt_quequan.ResetText();
                    txt_sdt.Focus();
                    Loaddulieu();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.xoanv(chon);
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
        string chon;
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString().Trim();
                txt_manv.Text = row.Cells[0].Value.ToString().Trim();
                txt_hoten.Text = row.Cells[1].Value.ToString().Trim();
                string dateInput = row.Cells[2].Value.ToString().Trim();
                DateTime dt = DateTime.Parse(dateInput); ngaysinh.Value = dt;
                txt_quequan.Text = row.Cells[3].Value.ToString().Trim();
                if (row.Cells[4].Value.ToString().Trim() == "Nam")
                {
                    cb_gioitinh.SelectedIndex = 0;
                }
                else
                {
                    cb_gioitinh.SelectedIndex = 1;
                }
                txt_dantoc.Text = row.Cells[5].Value.ToString().Trim();
                txt_sdt.Text = row.Cells[6].Value.ToString().Trim();
                cb_mapb.SelectedValue = row.Cells[7].Value.ToString().Trim();
                cb_macv.SelectedValue = row.Cells[8].Value.ToString().Trim();
                cb_matdhv.SelectedValue = row.Cells[9].Value.ToString().Trim();
                cb_bacluong.SelectedValue = row.Cells[10].Value.ToString();
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
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMANV = " + txt_manv.Text +
                    "\nHOTENNV = " + txt_hoten.Text +
                    "\nNGAYSINH = " + ngaysinh.Text +
                    "\nQUEQUAN = " + txt_quequan.Text +
                    "\nGIOITINH = " + cb_gioitinh.SelectedItem.ToString() +
                    "\nDANTOC = " + txt_dantoc.Text +
                    "\nSODT = " + txt_sdt.Text +
                    "\nMAPB = " + cb_mapb.SelectedValue.ToString() +
                    "\nMACV = " + cb_macv.SelectedValue.ToString() +
                    "\nMATDHV = " + cb_matdhv.SelectedValue.ToString() +
                    "\nBACLUONG = " + cb_bacluong.SelectedValue.ToString()
                   , "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suanv(chon, txt_manv.Text, txt_hoten.Text, ngaysinh.Value.ToString("yyyy/MM/dd"), txt_quequan.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), txt_dantoc.Text, txt_sdt.Text, cb_mapb.GetItemText(cb_mapb.SelectedItem), cb_macv.GetItemText(cb_macv.SelectedItem), cb_matdhv.GetItemText(cb_matdhv.SelectedItem), cb_bacluong.GetItemText(cb_bacluong.SelectedItem));
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

        private void bt_them_Click(object sender, EventArgs e)
        {
            txt_dantoc.ResetText();
            txt_hoten.ResetText();
            txt_manv.ResetText();
            txt_quequan.ResetText();
            txt_sdt.ResetText();
            cb_gioitinh.SelectedIndex = 0;
            cb_bacluong.SelectedIndex = 0;
            cb_macv.SelectedIndex = 0;
            cb_mapb.SelectedIndex = 0;
            cb_matdhv.SelectedIndex = 0;
            ngaysinh.Value = DateTime.Now;
        }

        private void cb_mapb_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cb_macv_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cb_matdhv_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cb_bacluong_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cb_mapb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cb_macv_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cb_matdhv_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cb_bacluong_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cb_gioitinh_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void bt_inds_Click(object sender, EventArgs e)
        {
            ReportForm.rpNHANVIEN rp = new ReportForm.rpNHANVIEN();
            rp.Show();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
