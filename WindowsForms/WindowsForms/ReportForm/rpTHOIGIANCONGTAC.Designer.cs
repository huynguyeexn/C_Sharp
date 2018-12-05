namespace WindowsForms.ReportForm
{
    partial class rpTHOIGIANCONGTAC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_THOIGIANCONGTAC = new WindowsForms.ReportForm.DataSet_THOIGIANCONGTAC();
            this.THOIGIANCONGTACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THOIGIANCONGTACTableAdapter = new WindowsForms.ReportForm.DataSet_THOIGIANCONGTACTableAdapters.THOIGIANCONGTACTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_THOIGIANCONGTAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THOIGIANCONGTACBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_THOIGIANCONGTAC";
            reportDataSource1.Value = this.THOIGIANCONGTACBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.ReportForm.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(282, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_THOIGIANCONGTAC
            // 
            this.DataSet_THOIGIANCONGTAC.DataSetName = "DataSet_THOIGIANCONGTAC";
            this.DataSet_THOIGIANCONGTAC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // THOIGIANCONGTACBindingSource
            // 
            this.THOIGIANCONGTACBindingSource.DataMember = "THOIGIANCONGTAC";
            this.THOIGIANCONGTACBindingSource.DataSource = this.DataSet_THOIGIANCONGTAC;
            // 
            // THOIGIANCONGTACTableAdapter
            // 
            this.THOIGIANCONGTACTableAdapter.ClearBeforeFill = true;
            // 
            // rpTHOIGIANCONGTAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpTHOIGIANCONGTAC";
            this.Text = "rpTHOIGIANCONGTAC";
            this.Load += new System.EventHandler(this.rpTHOIGIANCONGTAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_THOIGIANCONGTAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THOIGIANCONGTACBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource THOIGIANCONGTACBindingSource;
        private DataSet_THOIGIANCONGTAC DataSet_THOIGIANCONGTAC;
        private DataSet_THOIGIANCONGTACTableAdapters.THOIGIANCONGTACTableAdapter THOIGIANCONGTACTableAdapter;
    }
}