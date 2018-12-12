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
    public partial class PHONGBAN : Form
    {
        public PHONGBAN()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        public void Loaddulieu()
        {
            string sql = "Select * from PHONGBAN";
            dtgv.DataSource = kn.taobang(sql); 
        }
        private void PHONGBAN_Load(object sender, EventArgs e)
        {
            kn.connect();
            Loaddulieu();

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Loaddulieu();
            txt_diachi.ResetText();
            txt_mapb.ResetText();
            txt_sdt.ResetText();
            txt_tenpb.ResetText();
            this.bt_huy.Enabled = true;
            this.bt_luu.Enabled = true;
            this.bt_them.Enabled = true;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            
            if(txt_diachi.Text=="" || txt_mapb.Text=="" || txt_sdt.Text=="" || txt_tenpb.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập vào không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bt_them.Enabled = false;
                string s = "select * from PHONGBAN where MAPB='" + txt_mapb.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.thempb(txt_mapb.Text, txt_tenpb.Text, txt_diachi.Text, txt_sdt.Text);
                    txt_mapb.ResetText();
                    txt_diachi.ResetText();
                    txt_sdt.ResetText();
                    txt_tenpb.ResetText();
                    txt_mapb.Focus();
                    Loaddulieu();
                }
                else
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại, vui lòng nhập lại", "Thông báo",MessageBoxButtons.OK);
                }
            }

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        kn.xoapb(chon);
                    }
                    catch
                    {
                        MessageBox.Show("Mã Phòng ban đang được sử dụng trong bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Loaddulieu();
                }
                else if (result == DialogResult.No)
                {

                }
               
            }
            else
            {
                MessageBox.Show("Hãy chọn dòng cần xóa","Thông báo",MessageBoxButtons.OK);
            }
            
        }
        string chon;

        public void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv.Rows[e.RowIndex];
            chon = row.Cells[0].Value.ToString();
            txt_mapb.Text = row.Cells[0].Value.ToString();
            txt_tenpb.Text= row.Cells[1].Value.ToString();
            txt_diachi.Text = row.Cells[2].Value.ToString();
            txt_sdt.Text = row.Cells[3].Value.ToString();
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
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMAPB= " + txt_mapb.Text +
                    "\nTENPB= " + txt_tenpb.Text +
                    "\nDIACHI= " + txt_diachi.Text +
                    "\nSDT= "+txt_sdt.Text, "Chú ý",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suapb(chon, txt_mapb.Text, txt_tenpb.Text, txt_diachi.Text, txt_sdt.Text);
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

        private void bt_inds_Click(object sender, EventArgs e)
        {
            ReportForm.rpPHONGBAN rp = new ReportForm.rpPHONGBAN();
            rp.Show();
        }
    }
}
