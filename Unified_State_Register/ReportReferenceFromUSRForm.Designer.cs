
namespace Unified_State_Register
{
    partial class ReportReferenceFromUSRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportReferenceFromUSRForm));
            this.reportReferenceFromUSR = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportReferenceFromUSR
            // 
            this.reportReferenceFromUSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportReferenceFromUSR.LocalReport.ReportEmbeddedResource = "Unified_State_Register.ReferenceFromUSR.rdlc";
            this.reportReferenceFromUSR.Location = new System.Drawing.Point(0, 0);
            this.reportReferenceFromUSR.Name = "reportReferenceFromUSR";
            this.reportReferenceFromUSR.ServerReport.BearerToken = null;
            this.reportReferenceFromUSR.ShowBackButton = false;
            this.reportReferenceFromUSR.ShowExportButton = false;
            this.reportReferenceFromUSR.ShowFindControls = false;
            this.reportReferenceFromUSR.ShowPageNavigationControls = false;
            this.reportReferenceFromUSR.ShowPrintButton = false;
            this.reportReferenceFromUSR.ShowRefreshButton = false;
            this.reportReferenceFromUSR.ShowStopButton = false;
            this.reportReferenceFromUSR.ShowZoomControl = false;
            this.reportReferenceFromUSR.Size = new System.Drawing.Size(800, 450);
            this.reportReferenceFromUSR.TabIndex = 0;
            // 
            // ReportReferenceFromUSRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportReferenceFromUSR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportReferenceFromUSRForm";
            this.Text = "ReportReferenceFromUSRForm";
            this.Load += new System.EventHandler(this.ReportReferenceFromUSRForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportReferenceFromUSR;
    }
}