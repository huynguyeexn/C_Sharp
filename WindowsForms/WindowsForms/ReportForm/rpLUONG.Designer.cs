namespace WindowsForms.ReportForm
{
    partial class rpLUONG
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
            this.DataSet_LUONG = new WindowsForms.ReportForm.DataSet_LUONG();
            this.LUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LUONGTableAdapter = new WindowsForms.ReportForm.DataSet_LUONGTableAdapters.LUONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_LUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_LUONG";
            reportDataSource1.Value = this.LUONGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.ReportForm.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(282, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_LUONG
            // 
            this.DataSet_LUONG.DataSetName = "DataSet_LUONG";
            this.DataSet_LUONG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LUONGBindingSource
            // 
            this.LUONGBindingSource.DataMember = "LUONG";
            this.LUONGBindingSource.DataSource = this.DataSet_LUONG;
            // 
            // LUONGTableAdapter
            // 
            this.LUONGTableAdapter.ClearBeforeFill = true;
            // 
            // rpLUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpLUONG";
            this.Text = "rpLUONG";
            this.Load += new System.EventHandler(this.rpLUONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_LUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LUONGBindingSource;
        private DataSet_LUONG DataSet_LUONG;
        private DataSet_LUONGTableAdapters.LUONGTableAdapter LUONGTableAdapter;
    }
}