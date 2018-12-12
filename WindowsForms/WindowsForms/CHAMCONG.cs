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
    public partial class CHAMCONG : Form
    {
        
        public CHAMCONG()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        SqlConnection con;
        public void Loaddulieu()
        {
            string sql = "Select * from chamcong";
            dtgv.DataSource = kn.taobang(sql);
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (cb_manv.Text == "" || txt_sonc.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập vào không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bt_them.Enabled = false;
                string s = "select * from chamcong where manv='" + cb_manv.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themcc(cb_manv.Text, txt_sonc.Text);
                    cb_manv.ResetText();
                    txt_sonc.ResetText();
                    cb_manv.Focus();
                    Loaddulieu();
                }
                else
                {
                    MessageBox.Show("Nhân viên đã được chấm công, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Loaddulieu();
            cb_manv.ResetText();
            txt_sonc.ResetText();
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
                    kn.xoacc(chon);
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
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMANV= " + cb_manv.Text +
                    "\nSONGAYCONG= " + txt_sonc.Text, "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suacc(chon, cb_manv.Text, txt_sonc.Text);
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
        private void CHAMCONG_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Loadcombobox();
            Loaddulieu();
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString();
                cb_manv.Text = row.Cells[0].Value.ToString();
                txt_sonc.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
                chon = null;
            }
        }

        private void bt_inds_Click(object sender, EventArgs e)
        {
            ReportForm.rpCHAMCONG rp = new ReportForm.rpCHAMCONG();
            rp.Show();
        }

        private void cb_manv_DropDown(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cb_manv_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
