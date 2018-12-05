namespace WindowsForms.ReportForm
{
    partial class rpTRINHDOHOCVAN
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
            this.DataSet_TRINHDOHOCVANxsd = new WindowsForms.ReportForm.DataSet_TRINHDOHOCVANxsd();
            this.TRINHDOHOCVANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TRINHDOHOCVANTableAdapter = new WindowsForms.ReportForm.DataSet_TRINHDOHOCVANxsdTableAdapters.TRINHDOHOCVANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_TRINHDOHOCVANxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRINHDOHOCVANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_TRINHDOHOCVAN";
            reportDataSource1.Value = this.TRINHDOHOCVANBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.ReportForm.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(282, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_TRINHDOHOCVANxsd
            // 
            this.DataSet_TRINHDOHOCVANxsd.DataSetName = "DataSet_TRINHDOHOCVANxsd";
            this.DataSet_TRINHDOHOCVANxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TRINHDOHOCVANBindingSource
            // 
            this.TRINHDOHOCVANBindingSource.DataMember = "TRINHDOHOCVAN";
            this.TRINHDOHOCVANBindingSource.DataSource = this.DataSet_TRINHDOHOCVANxsd;
            // 
            // TRINHDOHOCVANTableAdapter
            // 
            this.TRINHDOHOCVANTableAdapter.ClearBeforeFill = true;
            // 
            // rpTRINHDOHOCVAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpTRINHDOHOCVAN";
            this.Text = "rpTRINHDOHOCVAN";
            this.Load += new System.EventHandler(this.rpTRINHDOHOCVAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_TRINHDOHOCVANxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRINHDOHOCVANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TRINHDOHOCVANBindingSource;
        private DataSet_TRINHDOHOCVANxsd DataSet_TRINHDOHOCVANxsd;
        private DataSet_TRINHDOHOCVANxsdTableAdapters.TRINHDOHOCVANTableAdapter TRINHDOHOCVANTableAdapter;
    }
}