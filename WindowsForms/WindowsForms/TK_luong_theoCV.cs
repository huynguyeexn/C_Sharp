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
    public partial class TK_luong_theoCV : Form
    {
        public TK_luong_theoCV()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        SqlConnection con;
        public void Loadcombobox()
        {

            SqlCommand cn1 = new SqlCommand("Select macv from chucvu", con);
            SqlDataAdapter ad1 = new SqlDataAdapter(cn1);
            DataSet ds1 = new DataSet();
            ad1.Fill(ds1, "chucvu");
            cb_macv.DataSource = ds1.Tables[0];
            cb_macv.DisplayMember = "macv".Trim();
            cb_macv.ValueMember = "macv".Trim();
        }
        private void cb_macv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string macv = cb_macv.GetItemText(cb_macv.SelectedItem);
            string sql = "Select manv,hotennv,CHUCVU.MACV,TENCV,luong = luong.luongCB * (luong.HSPC + luong.HSLUONG) " +
                "from NHANVIEN,CHUCVU,LUONG " +
                "WHERE nhanvien.MACV = CHUCVU.MACV and nhanvien.BACLUONG = luong.BACLUONG and CHUCVU.MACV='" + macv + "'";
            dtgv.DataSource = kn.taobang(sql);

            int row = dtgv.RowCount;
            int s = 0;
            for (int i = 0; i < row; i++)
            {
                try
                {
                    if (dtgv.Rows[i].Cells[0].Value.ToString().Trim() == "")
                    {

                    }
                    else
                    {
                        s = s + int.Parse(this.dtgv.Rows[i].Cells[4].Value.ToString().Trim());
                    }
                }
                catch
                {
                }
            }

            txt_tongNV.Text = (row - 1).ToString();
            txt_tongLuong.Text = s.ToString();
        }

        private void TK_luong_theoCV_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Loadcombobox();
            cb_macv.SelectedIndex = -1;
        }
    }
}
