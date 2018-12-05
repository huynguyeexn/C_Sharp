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
    public partial class rpTHOIGIANCONGTAC : Form
    {
        public rpTHOIGIANCONGTAC()
        {
            InitializeComponent();
        }

        private void rpTHOIGIANCONGTAC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_THOIGIANCONGTAC.THOIGIANCONGTAC' table. You can move, or remove it, as needed.
            this.THOIGIANCONGTACTableAdapter.Fill(this.DataSet_THOIGIANCONGTAC.THOIGIANCONGTAC);

            this.reportViewer1.RefreshReport();
        }
    }
}
