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
    public partial class rpTRINHDOHOCVAN : Form
    {
        public rpTRINHDOHOCVAN()
        {
            InitializeComponent();
        }

        private void rpTRINHDOHOCVAN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_TRINHDOHOCVANxsd.TRINHDOHOCVAN' table. You can move, or remove it, as needed.
            this.TRINHDOHOCVANTableAdapter.Fill(this.DataSet_TRINHDOHOCVANxsd.TRINHDOHOCVAN);

            this.reportViewer1.RefreshReport();
        }
    }
}
