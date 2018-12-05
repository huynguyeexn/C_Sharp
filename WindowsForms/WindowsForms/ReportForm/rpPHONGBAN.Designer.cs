namespace WindowsForms.ReportForm
{
    partial class rpPHONGBAN
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
            this.DataSet_PHONGBAN = new WindowsForms.ReportForm.DataSet_PHONGBAN();
            this.PHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PHONGBANTableAdapter = new WindowsForms.ReportForm.DataSet_PHONGBANTableAdapters.PHONGBANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_PHONGBAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHONGBANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_PHONGBAN";
            reportDataSource1.Value = this.PHONGBANBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.ReportForm.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(282, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_PHONGBAN
            // 
            this.DataSet_PHONGBAN.DataSetName = "DataSet_PHONGBAN";
            this.DataSet_PHONGBAN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PHONGBANBindingSource
            // 
            this.PHONGBANBindingSource.DataMember = "PHONGBAN";
            this.PHONGBANBindingSource.DataSource = this.DataSet_PHONGBAN;
            // 
            // PHONGBANTableAdapter
            // 
            this.PHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // rpPHONGBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpPHONGBAN";
            this.Text = "rpPHONGBAN";
            this.Load += new System.EventHandler(this.rpPHONGBAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_PHONGBAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHONGBANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PHONGBANBindingSource;
        private DataSet_PHONGBAN DataSet_PHONGBAN;
        private DataSet_PHONGBANTableAdapters.PHONGBANTableAdapter PHONGBANTableAdapter;
    }
}