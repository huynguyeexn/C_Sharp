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
    public partial class rpPHONGBAN : Form
    {
        public rpPHONGBAN()
        {
            InitializeComponent();
        }

        private void rpPHONGBAN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_PHONGBAN.PHONGBAN' table. You can move, or remove it, as needed.
            this.PHONGBANTableAdapter.Fill(this.DataSet_PHONGBAN.PHONGBAN);

            this.reportViewer1.RefreshReport();
        }
    }
}
