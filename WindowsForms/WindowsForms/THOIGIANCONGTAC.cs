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
    public partial class THOIGIANCONGTAC : Form
    {
        public THOIGIANCONGTAC()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        SqlConnection con;
        public void Loaddulieu()
        {
            string sql = "Select * from THOIGIANCONGTAC";
            dtgv.DataSource = kn.taobang(sql);
        }

        int cb_manv_Drop, cb_macv_Drop = -1;
        public void Loadcombobox()
        {
            cb_macv_Drop = cb_macv.SelectedIndex;
            cb_manv_Drop = cb_manv.SelectedIndex;

            SqlCommand cn = new SqlCommand("Select MANV from NHANVIEN", con);
            SqlDataAdapter ad = new SqlDataAdapter(cn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "NHANVIEN");
            cb_manv.DataSource = ds.Tables[0];
            cb_manv.DisplayMember = "MANV";
            cb_manv.ValueMember = "MANV";
            cb_manv.SelectedIndex = cb_manv_Drop;

            SqlCommand cn1  = new SqlCommand("Select MACV from CHUCVU", con);
            SqlDataAdapter ad1 = new SqlDataAdapter(cn1);
            DataSet ds1 = new DataSet();
            ad1.Fill(ds1, "CHUCVU");
            cb_macv.DataSource = ds1.Tables[0];
            cb_macv.DisplayMember = "MACV";
            cb_macv.ValueMember = "MACV";
            cb_macv.SelectedIndex = cb_macv_Drop;
            
        }
       
        private void THOIGIANCONGTAC_Load(object sender, EventArgs e)
        {
                con = kn.ketnoi;
                con.Open();
                Loaddulieu();
                Loadcombobox();
                dtp_ngaynhamchuc.Value = DateTime.Now;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (cb_macv.Text == "" || cb_manv.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string s = "select * from THOIGIANCONGTAC where MANV='" + cb_manv.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themtgct(cb_manv.Text, cb_macv.Text,dtp_ngaynhamchuc.Value.ToString("yyyy/MM/dd"));
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
            cb_macv.SelectedIndex = -1;
            cb_manv.SelectedIndex = -1;
            dtp_ngaynhamchuc.Value = DateTime.Now;
        }
        string chon;
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.xoatgct(chon);
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
        

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString().Trim();
                cb_manv.SelectedValue = row.Cells[0].Value.ToString().Trim();
                cb_macv.SelectedValue = row.Cells[1].Value.ToString().Trim();

                string dateInput = row.Cells[2].Value.ToString().Trim();
                DateTime dt = DateTime.Parse(dateInput);
                dtp_ngaynhamchuc.Value = dt;
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
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMANV = " + cb_manv.Text +
                    "\nMACV = " + cb_macv.Text +
                    "\nNGAYNHAMCHUC = " + dtp_ngaynhamchuc.Value.ToString("dd/MM/yyyy")
                   , "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suatgct(chon, cb_manv.GetItemText(cb_manv.SelectedItem), cb_macv.GetItemText(cb_manv.SelectedItem), dtp_ngaynhamchuc.Value.ToString("yyyy/MM/dd"));
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

        private void bt_inds_Click(object sender, EventArgs e)
        {
            ReportForm.rpTHOIGIANCONGTAC rp = new ReportForm.rpTHOIGIANCONGTAC();
            rp.Show();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_manv_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cb_macv_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cb_macv_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cb_manv_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
