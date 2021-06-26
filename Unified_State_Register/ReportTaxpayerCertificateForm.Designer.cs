
namespace Unified_State_Register
{
    partial class ReportTaxpayerCertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTaxpayerCertificateForm));
            this.reportTaxpayerCertificate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportTaxpayerCertificate
            // 
            this.reportTaxpayerCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTaxpayerCertificate.LocalReport.ReportEmbeddedResource = "Unified_State_Register.TaxpayerCertificate.rdlc";
            this.reportTaxpayerCertificate.Location = new System.Drawing.Point(0, 0);
            this.reportTaxpayerCertificate.Name = "reportTaxpayerCertificate";
            this.reportTaxpayerCertificate.ServerReport.BearerToken = null;
            this.reportTaxpayerCertificate.ShowBackButton = false;
            this.reportTaxpayerCertificate.ShowExportButton = false;
            this.reportTaxpayerCertificate.ShowFindControls = false;
            this.reportTaxpayerCertificate.ShowPageNavigationControls = false;
            this.reportTaxpayerCertificate.ShowPrintButton = false;
            this.reportTaxpayerCertificate.ShowRefreshButton = false;
            this.reportTaxpayerCertificate.ShowStopButton = false;
            this.reportTaxpayerCertificate.ShowZoomControl = false;
            this.reportTaxpayerCertificate.Size = new System.Drawing.Size(800, 450);
            this.reportTaxpayerCertificate.TabIndex = 0;
            // 
            // ReportTaxpayerCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportTaxpayerCertificate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportTaxpayerCertificateForm";
            this.Text = "ReportTaxpayerCertificateForm";
            this.Load += new System.EventHandler(this.ReportTaxpayerCertificateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportTaxpayerCertificate;
    }
}