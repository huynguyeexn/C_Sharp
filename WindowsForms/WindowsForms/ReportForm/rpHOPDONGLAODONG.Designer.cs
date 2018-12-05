namespace WindowsForms.ReportForm
{
    partial class rpHOPDONGLAODONG
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
            this.DataSet_HOPDONGLAODONG = new WindowsForms.ReportForm.DataSet_HOPDONGLAODONG();
            this.HOPDONGLAODONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOPDONGLAODONGTableAdapter = new WindowsForms.ReportForm.DataSet_HOPDONGLAODONGTableAdapters.HOPDONGLAODONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_HOPDONGLAODONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOPDONGLAODONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_HOPDONGLAODONG";
            reportDataSource1.Value = this.HOPDONGLAODONGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.ReportForm.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(506, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_HOPDONGLAODONG
            // 
            this.DataSet_HOPDONGLAODONG.DataSetName = "DataSet_HOPDONGLAODONG";
            this.DataSet_HOPDONGLAODONG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOPDONGLAODONGBindingSource
            // 
            this.HOPDONGLAODONGBindingSource.DataMember = "HOPDONGLAODONG";
            this.HOPDONGLAODONGBindingSource.DataSource = this.DataSet_HOPDONGLAODONG;
            // 
            // HOPDONGLAODONGTableAdapter
            // 
            this.HOPDONGLAODONGTableAdapter.ClearBeforeFill = true;
            // 
            // rpHOPDONGLAODONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpHOPDONGLAODONG";
            this.Text = "rpHOPDONGLAODONG";
            this.Load += new System.EventHandler(this.rpHOPDONGLAODONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_HOPDONGLAODONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOPDONGLAODONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOPDONGLAODONGBindingSource;
        private DataSet_HOPDONGLAODONG DataSet_HOPDONGLAODONG;
        private DataSet_HOPDONGLAODONGTableAdapters.HOPDONGLAODONGTableAdapter HOPDONGLAODONGTableAdapter;
    }
}