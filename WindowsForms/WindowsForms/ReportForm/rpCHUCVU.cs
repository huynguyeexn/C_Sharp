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
    public partial class rpCHUCVU : Form
    {
        public rpCHUCVU()
        {
            InitializeComponent();
        }

        private void rpCHUCVU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_CHUCVU.CHUCVU' table. You can move, or remove it, as needed.
            this.CHUCVUTableAdapter.Fill(this.DataSet_CHUCVU.CHUCVU);

            this.reportViewer1.RefreshReport();
        }
    }
}
