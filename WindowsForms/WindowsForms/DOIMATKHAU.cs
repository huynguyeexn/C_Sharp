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
    public partial class DOIMATKHAU : Form
    {
        public DOIMATKHAU()
        {
            InitializeComponent();
        }
        KETNOICSDL kn = new KETNOICSDL();
        string username;
        private void btn_dmk_Click(object sender, EventArgs e)
        {
            if (txt_xacnhanmk.Text != txt_mkmoi.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không giống nhau", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string s = "select * from dangnhap where username='" + username.Trim() + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                string s2 = "select * from dangnhap where username='" + username.Trim() + "'and password='"+txt_mkcu.Text+"'";
                DataTable dt2 = new DataTable();
                dt2 = kn.taobang(s2);
                if(dt2.Rows.Count != 0)
                {
                    kn.doimk(username, txt_mkmoi.Text);
                    this.Close();
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }
                //else if (dt.Rows.Count != 0)
                //{
                //    kn.doimk(username, txt_xacnhanmk.Text);
                //    this.Close();
                //    MessageBox.Show("Bạn đã dổi mật khẩu thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
            }
        }

        private void DOIMATKHAU_Load(object sender, EventArgs e)
        {
            kn.connect();
            Main form_main= new Main();
            username = form_main.getUsername();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
