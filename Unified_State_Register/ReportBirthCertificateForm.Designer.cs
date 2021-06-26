
namespace Unified_State_Register
{
    partial class ReportBirthCertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBirthCertificateForm));
            this.reportBirthCertificate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportBirthCertificate
            // 
            this.reportBirthCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBirthCertificate.LocalReport.ReportEmbeddedResource = "Unified_State_Register.BirthCertificate.rdlc";
            this.reportBirthCertificate.Location = new System.Drawing.Point(0, 0);
            this.reportBirthCertificate.Name = "reportBirthCertificate";
            this.reportBirthCertificate.ServerReport.BearerToken = null;
            this.reportBirthCertificate.ShowBackButton = false;
            this.reportBirthCertificate.ShowExportButton = false;
            this.reportBirthCertificate.ShowFindControls = false;
            this.reportBirthCertificate.ShowPageNavigationControls = false;
            this.reportBirthCertificate.ShowPrintButton = false;
            this.reportBirthCertificate.ShowRefreshButton = false;
            this.reportBirthCertificate.ShowStopButton = false;
            this.reportBirthCertificate.ShowZoomControl = false;
            this.reportBirthCertificate.Size = new System.Drawing.Size(703, 450);
            this.reportBirthCertificate.TabIndex = 0;
            // 
            // ReportBirthCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.reportBirthCertificate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportBirthCertificateForm";
            this.Text = "ReportBirthCertificateForm";
            this.Load += new System.EventHandler(this.ReportBirthCertificateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportBirthCertificate;
    }
}