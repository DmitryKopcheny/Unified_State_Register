
namespace Unified_State_Register
{
    partial class PersonalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalForm));
            this.btnPassport = new System.Windows.Forms.Button();
            this.btnPropertyRightCertificate = new System.Windows.Forms.Button();
            this.btnTransportCertificate = new System.Windows.Forms.Button();
            this.btnMarriageCertificate = new System.Windows.Forms.Button();
            this.btnBirthCertificate = new System.Windows.Forms.Button();
            this.btnReference = new System.Windows.Forms.Button();
            this.btnTaxpayer = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPassport
            // 
            this.btnPassport.Location = new System.Drawing.Point(76, 37);
            this.btnPassport.Name = "btnPassport";
            this.btnPassport.Size = new System.Drawing.Size(211, 36);
            this.btnPassport.TabIndex = 0;
            this.btnPassport.Text = "Паспорт";
            this.btnPassport.UseVisualStyleBackColor = true;
            this.btnPassport.Click += new System.EventHandler(this.btnPassport_Click);
            // 
            // btnPropertyRightCertificate
            // 
            this.btnPropertyRightCertificate.Location = new System.Drawing.Point(76, 289);
            this.btnPropertyRightCertificate.Name = "btnPropertyRightCertificate";
            this.btnPropertyRightCertificate.Size = new System.Drawing.Size(211, 36);
            this.btnPropertyRightCertificate.TabIndex = 1;
            this.btnPropertyRightCertificate.Text = "Свідоцтво про володіння";
            this.btnPropertyRightCertificate.UseVisualStyleBackColor = true;
            this.btnPropertyRightCertificate.Click += new System.EventHandler(this.btnPropertyRightCertificate_Click);
            // 
            // btnTransportCertificate
            // 
            this.btnTransportCertificate.Location = new System.Drawing.Point(76, 247);
            this.btnTransportCertificate.Name = "btnTransportCertificate";
            this.btnTransportCertificate.Size = new System.Drawing.Size(211, 36);
            this.btnTransportCertificate.TabIndex = 2;
            this.btnTransportCertificate.Text = "Свідоцтво про реєстрацію транспорту";
            this.btnTransportCertificate.UseVisualStyleBackColor = true;
            this.btnTransportCertificate.Click += new System.EventHandler(this.btnTransportCertificate_Click);
            // 
            // btnMarriageCertificate
            // 
            this.btnMarriageCertificate.Location = new System.Drawing.Point(76, 205);
            this.btnMarriageCertificate.Name = "btnMarriageCertificate";
            this.btnMarriageCertificate.Size = new System.Drawing.Size(211, 36);
            this.btnMarriageCertificate.TabIndex = 3;
            this.btnMarriageCertificate.Text = "Свідоцтво про шлюб";
            this.btnMarriageCertificate.UseVisualStyleBackColor = true;
            this.btnMarriageCertificate.Click += new System.EventHandler(this.btnMarriageCertificate_Click);
            // 
            // btnBirthCertificate
            // 
            this.btnBirthCertificate.Location = new System.Drawing.Point(76, 163);
            this.btnBirthCertificate.Name = "btnBirthCertificate";
            this.btnBirthCertificate.Size = new System.Drawing.Size(211, 36);
            this.btnBirthCertificate.TabIndex = 4;
            this.btnBirthCertificate.Text = "Свідоцтво про народження";
            this.btnBirthCertificate.UseVisualStyleBackColor = true;
            this.btnBirthCertificate.Click += new System.EventHandler(this.btnBirthCertificate_Click);
            // 
            // btnReference
            // 
            this.btnReference.Location = new System.Drawing.Point(76, 121);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(211, 36);
            this.btnReference.TabIndex = 5;
            this.btnReference.Text = "Витяг з ЄДР";
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnTaxpayer
            // 
            this.btnTaxpayer.Location = new System.Drawing.Point(76, 79);
            this.btnTaxpayer.Name = "btnTaxpayer";
            this.btnTaxpayer.Size = new System.Drawing.Size(211, 36);
            this.btnTaxpayer.TabIndex = 6;
            this.btnTaxpayer.Text = "КПП";
            this.btnTaxpayer.UseVisualStyleBackColor = true;
            this.btnTaxpayer.Click += new System.EventHandler(this.btnTaxpayer_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(76, 390);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(211, 36);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Вийти";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnTaxpayer);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.btnBirthCertificate);
            this.Controls.Add(this.btnMarriageCertificate);
            this.Controls.Add(this.btnTransportCertificate);
            this.Controls.Add(this.btnPropertyRightCertificate);
            this.Controls.Add(this.btnPassport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPassport;
        private System.Windows.Forms.Button btnPropertyRightCertificate;
        private System.Windows.Forms.Button btnTransportCertificate;
        private System.Windows.Forms.Button btnMarriageCertificate;
        private System.Windows.Forms.Button btnBirthCertificate;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Button btnTaxpayer;
        private System.Windows.Forms.Button btnSignOut;
    }
}