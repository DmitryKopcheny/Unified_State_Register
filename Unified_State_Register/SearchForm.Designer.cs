
namespace Unified_State_Register
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.btnSignOut = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPassport = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPatronimic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridPassport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbBirth = new System.Windows.Forms.CheckBox();
            this.chbMarriage = new System.Windows.Forms.CheckBox();
            this.chbPassport = new System.Windows.Forms.CheckBox();
            this.chbTaxpayer = new System.Windows.Forms.CheckBox();
            this.chbLive = new System.Windows.Forms.CheckBox();
            this.tbAppartment = new System.Windows.Forms.TextBox();
            this.tbHouse = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbDocType = new System.Windows.Forms.ComboBox();
            this.tbDocId = new System.Windows.Forms.TextBox();
            this.tabTransport = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTransportRegId = new System.Windows.Forms.TextBox();
            this.dataGridCar = new System.Windows.Forms.DataGridView();
            this.tabProperty = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridProperty = new System.Windows.Forms.DataGridView();
            this.tbpropertyDocId = new System.Windows.Forms.TextBox();
            this.tabDeath = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDeath = new System.Windows.Forms.DataGridView();
            this.tbDeathId = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPassport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPassport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabTransport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).BeginInit();
            this.tabProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).BeginInit();
            this.tabDeath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeath)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(132, 30);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Вийти";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPassport);
            this.tabControl.Controls.Add(this.tabTransport);
            this.tabControl.Controls.Add(this.tabProperty);
            this.tabControl.Controls.Add(this.tabDeath);
            this.tabControl.Location = new System.Drawing.Point(150, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(712, 557);
            this.tabControl.TabIndex = 8;
            // 
            // tabPassport
            // 
            this.tabPassport.Controls.Add(this.label11);
            this.tabPassport.Controls.Add(this.label10);
            this.tabPassport.Controls.Add(this.label9);
            this.tabPassport.Controls.Add(this.label8);
            this.tabPassport.Controls.Add(this.label7);
            this.tabPassport.Controls.Add(this.label6);
            this.tabPassport.Controls.Add(this.tbPatronimic);
            this.tabPassport.Controls.Add(this.label5);
            this.tabPassport.Controls.Add(this.label4);
            this.tabPassport.Controls.Add(this.label3);
            this.tabPassport.Controls.Add(this.label2);
            this.tabPassport.Controls.Add(this.dataGridPassport);
            this.tabPassport.Controls.Add(this.groupBox1);
            this.tabPassport.Controls.Add(this.tbAppartment);
            this.tabPassport.Controls.Add(this.tbHouse);
            this.tabPassport.Controls.Add(this.tbStreet);
            this.tabPassport.Controls.Add(this.tbPlace);
            this.tabPassport.Controls.Add(this.tbRegion);
            this.tabPassport.Controls.Add(this.tbFirstName);
            this.tabPassport.Controls.Add(this.tbLastName);
            this.tabPassport.Controls.Add(this.cbDocType);
            this.tabPassport.Controls.Add(this.tbDocId);
            this.tabPassport.Location = new System.Drawing.Point(4, 22);
            this.tabPassport.Name = "tabPassport";
            this.tabPassport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPassport.Size = new System.Drawing.Size(704, 531);
            this.tabPassport.TabIndex = 0;
            this.tabPassport.Text = "Паспортні данні";
            this.tabPassport.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Документ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Квартира";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Будинок";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Вулиця";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Населений пункт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Область";
            // 
            // tbPatronimic
            // 
            this.tbPatronimic.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPatronimic.Location = new System.Drawing.Point(301, 56);
            this.tbPatronimic.Name = "tbPatronimic";
            this.tbPatronimic.Size = new System.Drawing.Size(117, 20);
            this.tbPatronimic.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "По Батькові";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Номер документу";
            // 
            // dataGridPassport
            // 
            this.dataGridPassport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPassport.Location = new System.Drawing.Point(6, 166);
            this.dataGridPassport.Name = "dataGridPassport";
            this.dataGridPassport.Size = new System.Drawing.Size(692, 359);
            this.dataGridPassport.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbBirth);
            this.groupBox1.Controls.Add(this.chbMarriage);
            this.groupBox1.Controls.Add(this.chbPassport);
            this.groupBox1.Controls.Add(this.chbTaxpayer);
            this.groupBox1.Controls.Add(this.chbLive);
            this.groupBox1.Location = new System.Drawing.Point(547, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 128);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вивести";
            // 
            // chbBirth
            // 
            this.chbBirth.AutoSize = true;
            this.chbBirth.Location = new System.Drawing.Point(18, 41);
            this.chbBirth.Name = "chbBirth";
            this.chbBirth.Size = new System.Drawing.Size(120, 17);
            this.chbBirth.TabIndex = 14;
            this.chbBirth.Text = "Місце народження";
            this.chbBirth.UseVisualStyleBackColor = true;
            this.chbBirth.CheckedChanged += new System.EventHandler(this.chbBirth_CheckedChanged);
            // 
            // chbMarriage
            // 
            this.chbMarriage.AutoSize = true;
            this.chbMarriage.Location = new System.Drawing.Point(18, 110);
            this.chbMarriage.Name = "chbMarriage";
            this.chbMarriage.Size = new System.Drawing.Size(99, 17);
            this.chbMarriage.TabIndex = 17;
            this.chbMarriage.Text = "Сімейний стан";
            this.chbMarriage.UseVisualStyleBackColor = true;
            this.chbMarriage.CheckedChanged += new System.EventHandler(this.chbMarriage_CheckedChanged);
            // 
            // chbPassport
            // 
            this.chbPassport.AutoSize = true;
            this.chbPassport.Checked = true;
            this.chbPassport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPassport.Location = new System.Drawing.Point(18, 20);
            this.chbPassport.Name = "chbPassport";
            this.chbPassport.Size = new System.Drawing.Size(106, 17);
            this.chbPassport.TabIndex = 13;
            this.chbPassport.Text = "Паспортні данні";
            this.chbPassport.UseVisualStyleBackColor = true;
            this.chbPassport.CheckedChanged += new System.EventHandler(this.chbPassport_CheckedChanged);
            // 
            // chbTaxpayer
            // 
            this.chbTaxpayer.AutoSize = true;
            this.chbTaxpayer.Location = new System.Drawing.Point(18, 87);
            this.chbTaxpayer.Name = "chbTaxpayer";
            this.chbTaxpayer.Size = new System.Drawing.Size(49, 17);
            this.chbTaxpayer.TabIndex = 16;
            this.chbTaxpayer.Text = "КПП";
            this.chbTaxpayer.UseVisualStyleBackColor = true;
            this.chbTaxpayer.CheckedChanged += new System.EventHandler(this.chbTaxpayer_CheckedChanged);
            // 
            // chbLive
            // 
            this.chbLive.AutoSize = true;
            this.chbLive.Location = new System.Drawing.Point(18, 64);
            this.chbLive.Name = "chbLive";
            this.chbLive.Size = new System.Drawing.Size(120, 17);
            this.chbLive.TabIndex = 15;
            this.chbLive.Text = "Місце проживання";
            this.chbLive.UseVisualStyleBackColor = true;
            this.chbLive.CheckedChanged += new System.EventHandler(this.chbLive_CheckedChanged);
            // 
            // tbAppartment
            // 
            this.tbAppartment.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbAppartment.Location = new System.Drawing.Point(165, 129);
            this.tbAppartment.Name = "tbAppartment";
            this.tbAppartment.Size = new System.Drawing.Size(117, 20);
            this.tbAppartment.TabIndex = 11;
            // 
            // tbHouse
            // 
            this.tbHouse.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbHouse.Location = new System.Drawing.Point(25, 129);
            this.tbHouse.Name = "tbHouse";
            this.tbHouse.Size = new System.Drawing.Size(117, 20);
            this.tbHouse.TabIndex = 10;
            // 
            // tbStreet
            // 
            this.tbStreet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbStreet.Location = new System.Drawing.Point(301, 93);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(117, 20);
            this.tbStreet.TabIndex = 9;
            // 
            // tbPlace
            // 
            this.tbPlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPlace.Location = new System.Drawing.Point(165, 93);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(117, 20);
            this.tbPlace.TabIndex = 8;
            // 
            // tbRegion
            // 
            this.tbRegion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbRegion.Location = new System.Drawing.Point(25, 93);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(117, 20);
            this.tbRegion.TabIndex = 7;
            // 
            // tbFirstName
            // 
            this.tbFirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbFirstName.Location = new System.Drawing.Point(165, 57);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(117, 20);
            this.tbFirstName.TabIndex = 5;
            // 
            // tbLastName
            // 
            this.tbLastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbLastName.Location = new System.Drawing.Point(25, 57);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(117, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // cbDocType
            // 
            this.cbDocType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbDocType.FormattingEnabled = true;
            this.cbDocType.Items.AddRange(new object[] {
            "Паспорт",
            "КПП",
            "Витяг з ЄДР"});
            this.cbDocType.Location = new System.Drawing.Point(424, 20);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Size = new System.Drawing.Size(117, 21);
            this.cbDocType.TabIndex = 3;
            // 
            // tbDocId
            // 
            this.tbDocId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDocId.Location = new System.Drawing.Point(25, 21);
            this.tbDocId.Name = "tbDocId";
            this.tbDocId.Size = new System.Drawing.Size(393, 20);
            this.tbDocId.TabIndex = 0;
            // 
            // tabTransport
            // 
            this.tabTransport.Controls.Add(this.label12);
            this.tabTransport.Controls.Add(this.tbTransportRegId);
            this.tabTransport.Controls.Add(this.dataGridCar);
            this.tabTransport.Location = new System.Drawing.Point(4, 22);
            this.tabTransport.Name = "tabTransport";
            this.tabTransport.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransport.Size = new System.Drawing.Size(704, 531);
            this.tabTransport.TabIndex = 1;
            this.tabTransport.Text = "Транспорт";
            this.tabTransport.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Реєстраційний номер";
            // 
            // tbTransportRegId
            // 
            this.tbTransportRegId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTransportRegId.Location = new System.Drawing.Point(6, 23);
            this.tbTransportRegId.Name = "tbTransportRegId";
            this.tbTransportRegId.Size = new System.Drawing.Size(188, 20);
            this.tbTransportRegId.TabIndex = 1;
            // 
            // dataGridCar
            // 
            this.dataGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCar.Location = new System.Drawing.Point(6, 69);
            this.dataGridCar.Name = "dataGridCar";
            this.dataGridCar.Size = new System.Drawing.Size(692, 456);
            this.dataGridCar.TabIndex = 0;
            // 
            // tabProperty
            // 
            this.tabProperty.Controls.Add(this.label13);
            this.tabProperty.Controls.Add(this.dataGridProperty);
            this.tabProperty.Controls.Add(this.tbpropertyDocId);
            this.tabProperty.Location = new System.Drawing.Point(4, 22);
            this.tabProperty.Name = "tabProperty";
            this.tabProperty.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperty.Size = new System.Drawing.Size(704, 531);
            this.tabProperty.TabIndex = 2;
            this.tabProperty.Text = "Нерухомість";
            this.tabProperty.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Номер паспорту володаря";
            // 
            // dataGridProperty
            // 
            this.dataGridProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProperty.Location = new System.Drawing.Point(20, 70);
            this.dataGridProperty.Name = "dataGridProperty";
            this.dataGridProperty.Size = new System.Drawing.Size(672, 451);
            this.dataGridProperty.TabIndex = 1;
            // 
            // tbpropertyDocId
            // 
            this.tbpropertyDocId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbpropertyDocId.Location = new System.Drawing.Point(21, 23);
            this.tbpropertyDocId.Name = "tbpropertyDocId";
            this.tbpropertyDocId.Size = new System.Drawing.Size(171, 20);
            this.tbpropertyDocId.TabIndex = 0;
            // 
            // tabDeath
            // 
            this.tabDeath.Controls.Add(this.label14);
            this.tabDeath.Controls.Add(this.label1);
            this.tabDeath.Controls.Add(this.dataGridDeath);
            this.tabDeath.Controls.Add(this.tbDeathId);
            this.tabDeath.Location = new System.Drawing.Point(4, 22);
            this.tabDeath.Name = "tabDeath";
            this.tabDeath.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeath.Size = new System.Drawing.Size(704, 531);
            this.tabDeath.TabIndex = 3;
            this.tabDeath.Text = "Свідоцтво про смерть";
            this.tabDeath.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Номер документу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нащадки";
            // 
            // dataGridDeath
            // 
            this.dataGridDeath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeath.Location = new System.Drawing.Point(19, 77);
            this.dataGridDeath.Name = "dataGridDeath";
            this.dataGridDeath.Size = new System.Drawing.Size(675, 444);
            this.dataGridDeath.TabIndex = 1;
            // 
            // tbDeathId
            // 
            this.tbDeathId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDeathId.Location = new System.Drawing.Point(21, 23);
            this.tbDeathId.Name = "tbDeathId";
            this.tbDeathId.Size = new System.Drawing.Size(205, 20);
            this.tbDeathId.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 121);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 30);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Відобразити";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 574);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnSignOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.tabControl.ResumeLayout(false);
            this.tabPassport.ResumeLayout(false);
            this.tabPassport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPassport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTransport.ResumeLayout(false);
            this.tabTransport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).EndInit();
            this.tabProperty.ResumeLayout(false);
            this.tabProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).EndInit();
            this.tabDeath.ResumeLayout(false);
            this.tabDeath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPassport;
        private System.Windows.Forms.TextBox tbDocId;
        private System.Windows.Forms.TabPage tabTransport;
        private System.Windows.Forms.TabPage tabProperty;
        private System.Windows.Forms.TabPage tabDeath;
        private System.Windows.Forms.TextBox tbPatronimic;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ComboBox cbDocType;
        private System.Windows.Forms.TextBox tbAppartment;
        private System.Windows.Forms.TextBox tbHouse;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.DataGridView dataGridPassport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbBirth;
        private System.Windows.Forms.CheckBox chbMarriage;
        private System.Windows.Forms.CheckBox chbPassport;
        private System.Windows.Forms.CheckBox chbTaxpayer;
        private System.Windows.Forms.CheckBox chbLive;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbTransportRegId;
        private System.Windows.Forms.DataGridView dataGridCar;
        private System.Windows.Forms.DataGridView dataGridProperty;
        private System.Windows.Forms.TextBox tbpropertyDocId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDeath;
        private System.Windows.Forms.TextBox tbDeathId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}