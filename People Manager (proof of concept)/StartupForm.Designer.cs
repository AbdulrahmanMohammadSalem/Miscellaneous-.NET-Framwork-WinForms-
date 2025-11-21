namespace Windows_Forms_Application {
	partial class StartupForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_list = new System.Windows.Forms.RadioButton();
            this.radioButton_tiles = new System.Windows.Forms.RadioButton();
            this.radioButton_smallIcons = new System.Windows.Forms.RadioButton();
            this.radioButton_largeIcons = new System.Windows.Forms.RadioButton();
            this.radioButton_details = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_dateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_maritalStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_dateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_dateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.op1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.op3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_showMalesOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_showFemalesOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_showAll = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femalesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList_large = new System.Windows.Forms.ImageList(this.components);
            this.imageList_small = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.lbl_currentDateTime = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.splitContainer1.Panel1MinSize = 420;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.splitContainer1.Panel2MinSize = 800;
            this.splitContainer1.Size = new System.Drawing.Size(1482, 753);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(10, 10);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1MinSize = 350;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2MinSize = 260;
            this.splitContainer2.Size = new System.Drawing.Size(410, 733);
            this.splitContainer2.SplitterDistance = 395;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 13;
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
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
            this.comboBox_maritalStatus.Location = new System.Drawing.Point(139, 318);
            this.comboBox_maritalStatus.Name = "comboBox_maritalStatus";
            this.comboBox_maritalStatus.Size = new System.Drawing.Size(218, 30);
            this.comboBox_maritalStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 322);
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
            this.textBox_phoneNumber.Location = new System.Drawing.Point(152, 268);
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
            this.label5.Location = new System.Drawing.Point(15, 272);
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
            this.dateTimePicker_dateOfBirth.Location = new System.Drawing.Point(132, 218);
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
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender:";
            // 
            // radioButton_female
            // 
            this.radioButton_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(165, 170);
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
            this.radioButton_male.Location = new System.Drawing.Point(91, 170);
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
            this.textBox_fullName.Location = new System.Drawing.Point(112, 118);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(245, 30);
            this.textBox_fullName.TabIndex = 1;
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Location = new System.Drawing.Point(190, 68);
            this.textBox_id.MaxLength = 14;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(167, 30);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Digits_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "National ID Number:";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel1MinSize = 100;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel2MinSize = 150;
            this.splitContainer3.Size = new System.Drawing.Size(410, 333);
            this.splitContainer3.SplitterDistance = 113;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(180, 39);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(50, 50);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_edit, "Edit person");
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(327, 39);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 50);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_delete, "Delete person");
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(33, 39);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(50, 50);
            this.btn_add.TabIndex = 0;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_add, "Add person");
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_list);
            this.groupBox3.Controls.Add(this.radioButton_tiles);
            this.groupBox3.Controls.Add(this.radioButton_smallIcons);
            this.groupBox3.Controls.Add(this.radioButton_largeIcons);
            this.groupBox3.Controls.Add(this.radioButton_details);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 215);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display Style";
            // 
            // radioButton_list
            // 
            this.radioButton_list.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_list.AutoSize = true;
            this.radioButton_list.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.radioButton_list.Location = new System.Drawing.Point(180, 99);
            this.radioButton_list.Name = "radioButton_list";
            this.radioButton_list.Size = new System.Drawing.Size(56, 26);
            this.radioButton_list.TabIndex = 3;
            this.radioButton_list.Tag = "3";
            this.radioButton_list.Text = "List";
            this.radioButton_list.UseVisualStyleBackColor = true;
            this.radioButton_list.CheckedChanged += new System.EventHandler(this.radioButton_ListViewStyle_CheckedChanged);
            // 
            // radioButton_tiles
            // 
            this.radioButton_tiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_tiles.AutoSize = true;
            this.radioButton_tiles.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.radioButton_tiles.Location = new System.Drawing.Point(18, 135);
            this.radioButton_tiles.Name = "radioButton_tiles";
            this.radioButton_tiles.Size = new System.Drawing.Size(64, 26);
            this.radioButton_tiles.TabIndex = 4;
            this.radioButton_tiles.Tag = "4";
            this.radioButton_tiles.Text = "Tiles";
            this.radioButton_tiles.UseVisualStyleBackColor = true;
            this.radioButton_tiles.CheckedChanged += new System.EventHandler(this.radioButton_ListViewStyle_CheckedChanged);
            // 
            // radioButton_smallIcons
            // 
            this.radioButton_smallIcons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_smallIcons.AutoSize = true;
            this.radioButton_smallIcons.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.radioButton_smallIcons.Location = new System.Drawing.Point(18, 99);
            this.radioButton_smallIcons.Name = "radioButton_smallIcons";
            this.radioButton_smallIcons.Size = new System.Drawing.Size(116, 26);
            this.radioButton_smallIcons.TabIndex = 2;
            this.radioButton_smallIcons.Tag = "2";
            this.radioButton_smallIcons.Text = "Small icons";
            this.radioButton_smallIcons.UseVisualStyleBackColor = true;
            this.radioButton_smallIcons.CheckedChanged += new System.EventHandler(this.radioButton_ListViewStyle_CheckedChanged);
            // 
            // radioButton_largeIcons
            // 
            this.radioButton_largeIcons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_largeIcons.AutoSize = true;
            this.radioButton_largeIcons.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.radioButton_largeIcons.Location = new System.Drawing.Point(179, 63);
            this.radioButton_largeIcons.Name = "radioButton_largeIcons";
            this.radioButton_largeIcons.Size = new System.Drawing.Size(117, 26);
            this.radioButton_largeIcons.TabIndex = 1;
            this.radioButton_largeIcons.Tag = "0";
            this.radioButton_largeIcons.Text = "Large icons";
            this.radioButton_largeIcons.UseVisualStyleBackColor = true;
            this.radioButton_largeIcons.CheckedChanged += new System.EventHandler(this.radioButton_ListViewStyle_CheckedChanged);
            // 
            // radioButton_details
            // 
            this.radioButton_details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_details.AutoSize = true;
            this.radioButton_details.Checked = true;
            this.radioButton_details.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.radioButton_details.Location = new System.Drawing.Point(19, 63);
            this.radioButton_details.Name = "radioButton_details";
            this.radioButton_details.Size = new System.Drawing.Size(82, 26);
            this.radioButton_details.TabIndex = 0;
            this.radioButton_details.TabStop = true;
            this.radioButton_details.Tag = "1";
            this.radioButton_details.Text = "Details";
            this.radioButton_details.UseVisualStyleBackColor = true;
            this.radioButton_details.CheckedChanged += new System.EventHandler(this.radioButton_ListViewStyle_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_id,
            this.columnHeader_fullName,
            this.columnHeader_gender,
            this.columnHeader_dateOfBirth,
            this.columnHeader_phoneNumber,
            this.columnHeader_maritalStatus,
            this.columnHeader_dateCreated,
            this.columnHeader_dateModified});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList_large;
            this.listView1.Location = new System.Drawing.Point(0, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1047, 722);
            this.listView1.SmallImageList = this.imageList_small;
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_id
            // 
            this.columnHeader_id.Text = "ID";
            this.columnHeader_id.Width = 210;
            // 
            // columnHeader_fullName
            // 
            this.columnHeader_fullName.Text = "Full name";
            this.columnHeader_fullName.Width = 220;
            // 
            // columnHeader_gender
            // 
            this.columnHeader_gender.Text = "Gender";
            this.columnHeader_gender.Width = 90;
            // 
            // columnHeader_dateOfBirth
            // 
            this.columnHeader_dateOfBirth.Text = "Date of birth";
            this.columnHeader_dateOfBirth.Width = 140;
            // 
            // columnHeader_phoneNumber
            // 
            this.columnHeader_phoneNumber.Text = "Phone number";
            this.columnHeader_phoneNumber.Width = 160;
            // 
            // columnHeader_maritalStatus
            // 
            this.columnHeader_maritalStatus.Text = "Marital status";
            this.columnHeader_maritalStatus.Width = 140;
            // 
            // columnHeader_dateCreated
            // 
            this.columnHeader_dateCreated.Text = "Date created";
            this.columnHeader_dateCreated.Width = 166;
            // 
            // columnHeader_dateModified
            // 
            this.columnHeader_dateModified.Text = "Date modified";
            this.columnHeader_dateModified.Width = 166;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.op1ToolStripMenuItem,
            this.op3ToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.reverseSelectionToolStripMenuItem,
            this.toolStripSeparator2,
            this.filterToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.toolStripSeparator3,
            this.btn_exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 238);
            this.contextMenuStrip1.Text = "gbhnj";
            // 
            // op1ToolStripMenuItem
            // 
            this.op1ToolStripMenuItem.Name = "op1ToolStripMenuItem";
            this.op1ToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.op1ToolStripMenuItem.Text = "Add";
            this.op1ToolStripMenuItem.Click += new System.EventHandler(this.op1ToolStripMenuItem_Click);
            // 
            // op3ToolStripMenuItem
            // 
            this.op3ToolStripMenuItem.Name = "op3ToolStripMenuItem";
            this.op3ToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.op3ToolStripMenuItem.Text = "Edit";
            this.op3ToolStripMenuItem.Click += new System.EventHandler(this.op3ToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAllToolStripMenuItem,
            this.deleteSelectedRowsToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.deleteAllToolStripMenuItem.Text = "Delete all entries";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // deleteSelectedRowsToolStripMenuItem
            // 
            this.deleteSelectedRowsToolStripMenuItem.Name = "deleteSelectedRowsToolStripMenuItem";
            this.deleteSelectedRowsToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.deleteSelectedRowsToolStripMenuItem.Text = "Delete selected entries";
            this.deleteSelectedRowsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedRowsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.selectNoneToolStripMenuItem.Text = "Select none";
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // reverseSelectionToolStripMenuItem
            // 
            this.reverseSelectionToolStripMenuItem.Name = "reverseSelectionToolStripMenuItem";
            this.reverseSelectionToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.reverseSelectionToolStripMenuItem.Text = "Reverse selection";
            this.reverseSelectionToolStripMenuItem.Click += new System.EventHandler(this.reverseSelectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_showMalesOnly,
            this.btn_showFemalesOnly,
            this.btn_showAll});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // btn_showMalesOnly
            // 
            this.btn_showMalesOnly.CheckOnClick = true;
            this.btn_showMalesOnly.Name = "btn_showMalesOnly";
            this.btn_showMalesOnly.Size = new System.Drawing.Size(216, 26);
            this.btn_showMalesOnly.Text = "Show males only";
            this.btn_showMalesOnly.Click += new System.EventHandler(this.btn_showMalesOnly_Click);
            // 
            // btn_showFemalesOnly
            // 
            this.btn_showFemalesOnly.CheckOnClick = true;
            this.btn_showFemalesOnly.Name = "btn_showFemalesOnly";
            this.btn_showFemalesOnly.Size = new System.Drawing.Size(216, 26);
            this.btn_showFemalesOnly.Text = "Show females only";
            this.btn_showFemalesOnly.Click += new System.EventHandler(this.btn_showFemalesOnly_Click);
            // 
            // btn_showAll
            // 
            this.btn_showAll.Checked = true;
            this.btn_showAll.CheckOnClick = true;
            this.btn_showAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(216, 26);
            this.btn_showAll.Text = "Show all";
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malesOnlyToolStripMenuItem,
            this.femalesOnlyToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // malesOnlyToolStripMenuItem
            // 
            this.malesOnlyToolStripMenuItem.Name = "malesOnlyToolStripMenuItem";
            this.malesOnlyToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.malesOnlyToolStripMenuItem.Text = "Males only";
            this.malesOnlyToolStripMenuItem.Click += new System.EventHandler(this.btn_selectMalesOnly_Click);
            // 
            // femalesOnlyToolStripMenuItem
            // 
            this.femalesOnlyToolStripMenuItem.Name = "femalesOnlyToolStripMenuItem";
            this.femalesOnlyToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.femalesOnlyToolStripMenuItem.Text = "Females only";
            this.femalesOnlyToolStripMenuItem.Click += new System.EventHandler(this.ben_selectFemalesOnly_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(167, 24);
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // imageList_large
            // 
            this.imageList_large.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_large.ImageStream")));
            this.imageList_large.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_large.Images.SetKeyName(0, "female");
            this.imageList_large.Images.SetKeyName(1, "male");
            // 
            // imageList_small
            // 
            this.imageList_small.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_small.ImageStream")));
            this.imageList_small.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_small.Images.SetKeyName(0, "female");
            this.imageList_small.Images.SetKeyName(1, "male");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_filter);
            this.panel1.Controls.Add(this.lbl_currentDateTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 21);
            this.panel1.TabIndex = 4;
            // 
            // lbl_filter
            // 
            this.lbl_filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_filter.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Italic);
            this.lbl_filter.ForeColor = System.Drawing.Color.Black;
            this.lbl_filter.Location = new System.Drawing.Point(525, 0);
            this.lbl_filter.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(523, 21);
            this.lbl_filter.TabIndex = 5;
            this.lbl_filter.Text = "Shown: All";
            this.lbl_filter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_currentDateTime
            // 
            this.lbl_currentDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_currentDateTime.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.lbl_currentDateTime.ForeColor = System.Drawing.Color.Black;
            this.lbl_currentDateTime.Location = new System.Drawing.Point(0, 0);
            this.lbl_currentDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_currentDateTime.Name = "lbl_currentDateTime";
            this.lbl_currentDateTime.Size = new System.Drawing.Size(523, 21);
            this.lbl_currentDateTime.TabIndex = 4;
            this.lbl_currentDateTime.Text = "label7";
            this.lbl_currentDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartupForm
            // 
            this.AcceptButton = this.btn_add;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People manager";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_list;
        private System.Windows.Forms.RadioButton radioButton_tiles;
        private System.Windows.Forms.RadioButton radioButton_smallIcons;
        private System.Windows.Forms.RadioButton radioButton_largeIcons;
        private System.Windows.Forms.RadioButton radioButton_details;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader_id;
        private System.Windows.Forms.ImageList imageList_large;
        private System.Windows.Forms.ImageList imageList_small;
        private System.Windows.Forms.ColumnHeader columnHeader_fullName;
        private System.Windows.Forms.ColumnHeader columnHeader_gender;
        private System.Windows.Forms.ColumnHeader columnHeader_dateOfBirth;
        private System.Windows.Forms.ColumnHeader columnHeader_phoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeader_maritalStatus;
        private System.Windows.Forms.ColumnHeader columnHeader_dateCreated;
        private System.Windows.Forms.ColumnHeader columnHeader_dateModified;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem op1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem op3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_showMalesOnly;
        private System.Windows.Forms.ToolStripMenuItem btn_showFemalesOnly;
        private System.Windows.Forms.ToolStripMenuItem btn_showAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malesOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femalesOnlyToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.Label lbl_currentDateTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
    }
}

