
namespace Unified_State_Register
{
    partial class ReportPropertyOwnershipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPropertyOwnershipForm));
            this.reportPropertyOwnership = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportPropertyOwnership
            // 
            this.reportPropertyOwnership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPropertyOwnership.LocalReport.ReportEmbeddedResource = "Unified_State_Register.PropertyOwnership.rdlc";
            this.reportPropertyOwnership.Location = new System.Drawing.Point(0, 0);
            this.reportPropertyOwnership.Name = "reportPropertyOwnership";
            this.reportPropertyOwnership.ServerReport.BearerToken = null;
            this.reportPropertyOwnership.ShowBackButton = false;
            this.reportPropertyOwnership.ShowExportButton = false;
            this.reportPropertyOwnership.ShowFindControls = false;
            this.reportPropertyOwnership.ShowPageNavigationControls = false;
            this.reportPropertyOwnership.ShowPrintButton = false;
            this.reportPropertyOwnership.ShowRefreshButton = false;
            this.reportPropertyOwnership.ShowStopButton = false;
            this.reportPropertyOwnership.ShowZoomControl = false;
            this.reportPropertyOwnership.Size = new System.Drawing.Size(800, 450);
            this.reportPropertyOwnership.TabIndex = 0;
            // 
            // ReportPropertyOwnershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportPropertyOwnership);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportPropertyOwnershipForm";
            this.Text = "ReportPropertyOwnershipForm";
            this.Load += new System.EventHandler(this.ReportPropertyOwnershipForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportPropertyOwnership;
    }
}