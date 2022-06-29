namespace QLNS
{
    partial class bcnv
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
            this.TblTTNVCoBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QLNS.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblTTNVCoBanTableAdapter = new QLNS.DataSet1TableAdapters.TblTTNVCoBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblTTNVCoBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TblTTNVCoBanBindingSource
            // 
            this.TblTTNVCoBanBindingSource.DataMember = "TblTTNVCoBan";
            this.TblTTNVCoBanBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblTTNVCoBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(628, 394);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // TblTTNVCoBanTableAdapter
            // 
            this.TblTTNVCoBanTableAdapter.ClearBeforeFill = true;
            // 
            // bcnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 394);
            this.Controls.Add(this.reportViewer1);
            this.Name = "bcnv";
            this.Text = "bcnv";
            this.Load += new System.EventHandler(this.bcnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblTTNVCoBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblTTNVCoBanBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.TblTTNVCoBanTableAdapter TblTTNVCoBanTableAdapter;
    }
}