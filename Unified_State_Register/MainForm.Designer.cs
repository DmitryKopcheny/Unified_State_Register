
namespace Unified_State_Register
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tbSignInName = new System.Windows.Forms.TextBox();
            this.tbSignInPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSignUpPassword = new System.Windows.Forms.TextBox();
            this.tbSignUpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSignUpPassportId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSignUpPasswordRepeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(175, 144);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(120, 28);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Увійти";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(172, 363);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(120, 28);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Зареєструватися";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbSignInName
            // 
            this.tbSignInName.Location = new System.Drawing.Point(175, 67);
            this.tbSignInName.Name = "tbSignInName";
            this.tbSignInName.Size = new System.Drawing.Size(120, 20);
            this.tbSignInName.TabIndex = 2;
            // 
            // tbSignInPassword
            // 
            this.tbSignInPassword.Location = new System.Drawing.Point(175, 109);
            this.tbSignInPassword.Name = "tbSignInPassword";
            this.tbSignInPassword.Size = new System.Drawing.Size(120, 20);
            this.tbSignInPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ім\'я Користувача";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ім\'я Користувача";
            // 
            // tbSignUpPassword
            // 
            this.tbSignUpPassword.Location = new System.Drawing.Point(175, 248);
            this.tbSignUpPassword.Name = "tbSignUpPassword";
            this.tbSignUpPassword.Size = new System.Drawing.Size(120, 20);
            this.tbSignUpPassword.TabIndex = 7;
            // 
            // tbSignUpName
            // 
            this.tbSignUpName.Location = new System.Drawing.Point(175, 209);
            this.tbSignUpName.Name = "tbSignUpName";
            this.tbSignUpName.Size = new System.Drawing.Size(120, 20);
            this.tbSignUpName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер Паспорту";
            // 
            // tbSignUpPassportId
            // 
            this.tbSignUpPassportId.Location = new System.Drawing.Point(172, 325);
            this.tbSignUpPassportId.Name = "tbSignUpPassportId";
            this.tbSignUpPassportId.Size = new System.Drawing.Size(120, 20);
            this.tbSignUpPassportId.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Повторіть пароль";
            // 
            // tbSignUpPasswordRepeat
            // 
            this.tbSignUpPasswordRepeat.Location = new System.Drawing.Point(175, 287);
            this.tbSignUpPasswordRepeat.Name = "tbSignUpPasswordRepeat";
            this.tbSignUpPasswordRepeat.Size = new System.Drawing.Size(120, 20);
            this.tbSignUpPasswordRepeat.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 573);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSignUpPasswordRepeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSignUpPassportId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSignUpPassword);
            this.Controls.Add(this.tbSignUpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSignInPassword);
            this.Controls.Add(this.tbSignInName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Unified_State_Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbSignInName;
        private System.Windows.Forms.TextBox tbSignInPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSignUpPassword;
        private System.Windows.Forms.TextBox tbSignUpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSignUpPassportId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSignUpPasswordRepeat;
    }
}

