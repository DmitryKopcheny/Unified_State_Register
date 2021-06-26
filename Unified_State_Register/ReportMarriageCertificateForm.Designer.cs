
namespace Unified_State_Register
{
    partial class ReportMarriageCertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMarriageCertificateForm));
            this.reportMarriageCertificate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportMarriageCertificate
            // 
            this.reportMarriageCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportMarriageCertificate.LocalReport.ReportEmbeddedResource = "Unified_State_Register.MarriageCertificate.rdlc";
            this.reportMarriageCertificate.Location = new System.Drawing.Point(0, 0);
            this.reportMarriageCertificate.Name = "reportMarriageCertificate";
            this.reportMarriageCertificate.ServerReport.BearerToken = null;
            this.reportMarriageCertificate.ShowBackButton = false;
            this.reportMarriageCertificate.ShowExportButton = false;
            this.reportMarriageCertificate.ShowFindControls = false;
            this.reportMarriageCertificate.ShowPageNavigationControls = false;
            this.reportMarriageCertificate.ShowPrintButton = false;
            this.reportMarriageCertificate.ShowRefreshButton = false;
            this.reportMarriageCertificate.ShowStopButton = false;
            this.reportMarriageCertificate.ShowZoomControl = false;
            this.reportMarriageCertificate.Size = new System.Drawing.Size(800, 450);
            this.reportMarriageCertificate.TabIndex = 0;
            // 
            // ReportMarriageCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportMarriageCertificate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportMarriageCertificateForm";
            this.Text = "ReportMarriageCertificateForm";
            this.Load += new System.EventHandler(this.ReportMarriageCertificateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportMarriageCertificate;
    }
}