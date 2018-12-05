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
    public partial class rpCHAMCONG : Form
    {
        public rpCHAMCONG()
        {
            InitializeComponent();
        }

        private void rpCHAMCONG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_CHAMCONG.CHAMCONG' table. You can move, or remove it, as needed.
            this.CHAMCONGTableAdapter.Fill(this.DataSet_CHAMCONG.CHAMCONG);

            this.reportViewer1.RefreshReport();
        }
    }
}
