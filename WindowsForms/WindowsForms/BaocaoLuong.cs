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
    public partial class BaocaoLuong : Form
    {
        public BaocaoLuong()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        SqlConnection con;
        public void Loadcombobox()
        {

            SqlCommand cn1 = new SqlCommand("Select mapb from phongban", con);
            SqlDataAdapter ad1 = new SqlDataAdapter(cn1);
            DataSet ds1 = new DataSet();
            ad1.Fill(ds1, "phongban");
            cb_maphongban.DataSource = ds1.Tables[0];
            cb_maphongban.DisplayMember = "mapb";
            cb_maphongban.ValueMember = "mapb";
        }
        private void BaocaoLuong_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Loadcombobox();
            cb_maphongban.SelectedIndex = -1;
        }

        private void cb_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_maphongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mapb = cb_maphongban.GetItemText(cb_maphongban.SelectedItem);
            string sql = "Select manv,hotennv,phongban.MAPB,tenpb,luong = luong.luongCB * (luong.HSPC + luong.HSLUONG) "+
                "from NHANVIEN,PHONGBAN,LUONG "+
                "WHERE nhanvien.mapb = phongban.mapb and nhanvien.BACLUONG = luong.BACLUONG and phongban.mapb='"+mapb+"'";
            dtgv.DataSource = kn.taobang(sql);

            int row = dtgv.RowCount;
            int s=0;
            for (int i = 0; i < row; i++)
            {
                try
                {
                    if (dtgv.Rows[i].Cells[0].Value.ToString().Trim() == "")
                    {

                    }
                    else { 
                        s = s + int.Parse(this.dtgv.Rows[i].Cells[4].Value.ToString().Trim());
                    }
                }
                catch {
                }
            }

            txt_sonv.Text = (row-1).ToString();
            txt_tongluong.Text = s.ToString();
        }

        private void txt_sonv_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txt_sonv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
