using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.ReportForm
{
    public partial class rpKHENTHUONGKYLUAT : Form
    {
        public rpKHENTHUONGKYLUAT()
        {
            InitializeComponent();
        }

        private void rpKHENTHUONGKYLUAT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_KHENTHUONGKYLUAT.KHENTHUONGKYLUAT' table. You can move, or remove it, as needed.
            this.KHENTHUONGKYLUATTableAdapter.Fill(this.DataSet_KHENTHUONGKYLUAT.KHENTHUONGKYLUAT);

            this.reportViewer1.RefreshReport();
        }
    }
}
