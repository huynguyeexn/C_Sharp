namespace WindowsForms.ReportForm
{
    partial class rpCHUCVU
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
            this.DataSet_CHUCVU = new WindowsForms.ReportForm.DataSet_CHUCVU();
            this.CHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHUCVUTableAdapter = new WindowsForms.ReportForm.DataSet_CHUCVUTableAdapters.CHUCVUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_CHUCVU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHUCVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_CHUCVU";
            reportDataSource1.Value = this.CHUCVUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.ReportForm.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(430, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_CHUCVU
            // 
            this.DataSet_CHUCVU.DataSetName = "DataSet_CHUCVU";
            this.DataSet_CHUCVU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHUCVUBindingSource
            // 
            this.CHUCVUBindingSource.DataMember = "CHUCVU";
            this.CHUCVUBindingSource.DataSource = this.DataSet_CHUCVU;
            // 
            // CHUCVUTableAdapter
            // 
            this.CHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // rpCHUCVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpCHUCVU";
            this.Text = "rpCHUCVU";
            this.Load += new System.EventHandler(this.rpCHUCVU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_CHUCVU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHUCVUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHUCVUBindingSource;
        private DataSet_CHUCVU DataSet_CHUCVU;
        private DataSet_CHUCVUTableAdapters.CHUCVUTableAdapter CHUCVUTableAdapter;
    }
}