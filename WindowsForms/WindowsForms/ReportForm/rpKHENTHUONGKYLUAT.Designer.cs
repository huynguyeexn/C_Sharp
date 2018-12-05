namespace WindowsForms.ReportForm
{
    partial class rpKHENTHUONGKYLUAT
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
            this.DataSet_KHENTHUONGKYLUAT = new WindowsForms.ReportForm.DataSet_KHENTHUONGKYLUAT();
            this.KHENTHUONGKYLUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHENTHUONGKYLUATTableAdapter = new WindowsForms.ReportForm.DataSet_KHENTHUONGKYLUATTableAdapters.KHENTHUONGKYLUATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_KHENTHUONGKYLUAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHENTHUONGKYLUATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_KHENTHUONGKYLUAT";
            reportDataSource1.Value = this.KHENTHUONGKYLUATBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.ReportForm.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(567, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_KHENTHUONGKYLUAT
            // 
            this.DataSet_KHENTHUONGKYLUAT.DataSetName = "DataSet_KHENTHUONGKYLUAT";
            this.DataSet_KHENTHUONGKYLUAT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHENTHUONGKYLUATBindingSource
            // 
            this.KHENTHUONGKYLUATBindingSource.DataMember = "KHENTHUONGKYLUAT";
            this.KHENTHUONGKYLUATBindingSource.DataSource = this.DataSet_KHENTHUONGKYLUAT;
            // 
            // KHENTHUONGKYLUATTableAdapter
            // 
            this.KHENTHUONGKYLUATTableAdapter.ClearBeforeFill = true;
            // 
            // rpKHENTHUONGKYLUAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 253);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpKHENTHUONGKYLUAT";
            this.Text = "rpKHENTHUONGKYLUAT";
            this.Load += new System.EventHandler(this.rpKHENTHUONGKYLUAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_KHENTHUONGKYLUAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHENTHUONGKYLUATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KHENTHUONGKYLUATBindingSource;
        private DataSet_KHENTHUONGKYLUAT DataSet_KHENTHUONGKYLUAT;
        private DataSet_KHENTHUONGKYLUATTableAdapters.KHENTHUONGKYLUATTableAdapter KHENTHUONGKYLUATTableAdapter;
    }
}