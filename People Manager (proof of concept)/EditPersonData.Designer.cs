namespace Windows_Forms_Application {
    partial class EditPersonData {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_maritalStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Windows_Forms_Application.Properties.Resources.male;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_maritalStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_phoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker_dateOfBirth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton_female);
            this.groupBox1.Controls.Add(this.radioButton_male);
            this.groupBox1.Controls.Add(this.textBox_fullName);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.groupBox1.Location = new System.Drawing.Point(10, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 395);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter new information:";
            // 
            // comboBox_maritalStatus
            // 
            this.comboBox_maritalStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_maritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_maritalStatus.DropDownWidth = 240;
            this.comboBox_maritalStatus.FormattingEnabled = true;
            this.comboBox_maritalStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
            this.comboBox_maritalStatus.Location = new System.Drawing.Point(149, 318);
            this.comboBox_maritalStatus.Name = "comboBox_maritalStatus";
            this.comboBox_maritalStatus.Size = new System.Drawing.Size(218, 30);
            this.comboBox_maritalStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Marital Status:";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_phoneNumber.AsciiOnly = true;
            this.textBox_phoneNumber.BeepOnError = true;
            this.textBox_phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_phoneNumber.Culture = new System.Globalization.CultureInfo("ar-EG");
            this.textBox_phoneNumber.HidePromptOnLeave = true;
            this.textBox_phoneNumber.Location = new System.Drawing.Point(162, 268);
            this.textBox_phoneNumber.Mask = "+2 0000 000 0000";
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.PromptChar = '-';
            this.textBox_phoneNumber.RejectInputOnFirstFailure = true;
            this.textBox_phoneNumber.ResetOnPrompt = false;
            this.textBox_phoneNumber.ResetOnSpace = false;
            this.textBox_phoneNumber.Size = new System.Drawing.Size(205, 30);
            this.textBox_phoneNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number:";
            // 
            // dateTimePicker_dateOfBirth
            // 
            this.dateTimePicker_dateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_dateOfBirth.CustomFormat = "ddd, MMM dd, yyyy";
            this.dateTimePicker_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateOfBirth.Location = new System.Drawing.Point(142, 218);
            this.dateTimePicker_dateOfBirth.MaxDate = new System.DateTime(2025, 11, 19, 0, 0, 0, 0);
            this.dateTimePicker_dateOfBirth.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_dateOfBirth.Name = "dateTimePicker_dateOfBirth";
            this.dateTimePicker_dateOfBirth.Size = new System.Drawing.Size(225, 30);
            this.dateTimePicker_dateOfBirth.TabIndex = 4;
            this.dateTimePicker_dateOfBirth.Value = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender:";
            // 
            // radioButton_female
            // 
            this.radioButton_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(175, 170);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(85, 26);
            this.radioButton_female.TabIndex = 3;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Checked = true;
            this.radioButton_male.Location = new System.Drawing.Point(101, 170);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(68, 26);
            this.radioButton_male.TabIndex = 2;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_fullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fullName.Location = new System.Drawing.Point(122, 118);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(245, 30);
            this.textBox_fullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.button1.Location = new System.Drawing.Point(180, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.button2.Location = new System.Drawing.Point(320, 547);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Location = new System.Drawing.Point(200, 68);
            this.textBox_id.MaxLength = 14;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(167, 30);
            this.textBox_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "National ID Number:";
            // 
            // EditPersonData
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(450, 599);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPersonData";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Edit entry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_maritalStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox textBox_phoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
    }
}