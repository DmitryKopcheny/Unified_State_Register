
namespace Unified_State_Register
{
    partial class ReportTransportCertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTransportCertificateForm));
            this.reportTransportCertificate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportTransportCertificate
            // 
            this.reportTransportCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTransportCertificate.LocalReport.ReportEmbeddedResource = "Unified_State_Register.TransportCertificate.rdlc";
            this.reportTransportCertificate.Location = new System.Drawing.Point(0, 0);
            this.reportTransportCertificate.Name = "reportTransportCertificate";
            this.reportTransportCertificate.ServerReport.BearerToken = null;
            this.reportTransportCertificate.ShowBackButton = false;
            this.reportTransportCertificate.ShowExportButton = false;
            this.reportTransportCertificate.ShowFindControls = false;
            this.reportTransportCertificate.ShowPageNavigationControls = false;
            this.reportTransportCertificate.ShowPrintButton = false;
            this.reportTransportCertificate.ShowRefreshButton = false;
            this.reportTransportCertificate.ShowStopButton = false;
            this.reportTransportCertificate.ShowZoomControl = false;
            this.reportTransportCertificate.Size = new System.Drawing.Size(800, 450);
            this.reportTransportCertificate.TabIndex = 0;
            // 
            // ReportTransportCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportTransportCertificate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportTransportCertificateForm";
            this.Text = "ReportTransportCertificateForm";
            this.Load += new System.EventHandler(this.ReportTransportCertificateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportTransportCertificate;
    }
}