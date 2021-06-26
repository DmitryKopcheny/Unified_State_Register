
namespace Unified_State_Register
{
    partial class ReportPassportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPassportForm));
            this.reportPassport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportPassport
            // 
            this.reportPassport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPassport.LocalReport.ReportEmbeddedResource = "Unified_State_Register.Passport.rdlc";
            this.reportPassport.Location = new System.Drawing.Point(0, 0);
            this.reportPassport.Name = "reportPassport";
            this.reportPassport.ServerReport.BearerToken = null;
            this.reportPassport.ShowBackButton = false;
            this.reportPassport.ShowExportButton = false;
            this.reportPassport.ShowFindControls = false;
            this.reportPassport.ShowPageNavigationControls = false;
            this.reportPassport.ShowPrintButton = false;
            this.reportPassport.ShowRefreshButton = false;
            this.reportPassport.ShowStopButton = false;
            this.reportPassport.ShowZoomControl = false;
            this.reportPassport.Size = new System.Drawing.Size(800, 450);
            this.reportPassport.TabIndex = 0;
            // 
            // ReportPassportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportPassport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportPassportForm";
            this.Text = "Passport";
            this.Load += new System.EventHandler(this.ReportPassportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportPassport;
    }
}