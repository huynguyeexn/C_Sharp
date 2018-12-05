namespace WindowsForms.ReportForm
{
    partial class rpCHAMCONG
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
            this.DataSet_CHAMCONG = new WindowsForms.ReportForm.DataSet_CHAMCONG();
            this.CHAMCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHAMCONGTableAdapter = new WindowsForms.ReportForm.DataSet_CHAMCONGTableAdapters.CHAMCONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_CHAMCONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHAMCONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_CHAMCONG";
            reportDataSource1.Value = this.CHAMCONGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.ReportForm.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(449, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_CHAMCONG
            // 
            this.DataSet_CHAMCONG.DataSetName = "DataSet_CHAMCONG";
            this.DataSet_CHAMCONG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHAMCONGBindingSource
            // 
            this.CHAMCONGBindingSource.DataMember = "CHAMCONG";
            this.CHAMCONGBindingSource.DataSource = this.DataSet_CHAMCONG;
            // 
            // CHAMCONGTableAdapter
            // 
            this.CHAMCONGTableAdapter.ClearBeforeFill = true;
            // 
            // rpCHAMCONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpCHAMCONG";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.rpCHAMCONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_CHAMCONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHAMCONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHAMCONGBindingSource;
        private DataSet_CHAMCONG DataSet_CHAMCONG;
        private DataSet_CHAMCONGTableAdapters.CHAMCONGTableAdapter CHAMCONGTableAdapter;
    }
}