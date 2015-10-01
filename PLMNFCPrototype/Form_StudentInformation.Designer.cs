namespace PLMNFCPrototype
{
    partial class Form_StudentInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbStudentNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbMName = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbSubdivision = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbZipcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbContactNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmailAdd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbAcadStatus = new System.Windows.Forms.TextBox();
            this.btnBrowsePic = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbCollege = new System.Windows.Forms.ComboBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbSmartcard = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnGetSmartcardUID = new System.Windows.Forms.Button();
            this.lblUserID_StudentInfo = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Number : ";
            // 
            // tbStudentNumber
            // 
            this.tbStudentNumber.Location = new System.Drawing.Point(118, 95);
            this.tbStudentNumber.Name = "tbStudentNumber";
            this.tbStudentNumber.Size = new System.Drawing.Size(186, 20);
            this.tbStudentNumber.TabIndex = 0;
            this.tbStudentNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbStudentNumber_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Name : ";
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(118, 124);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(124, 20);
            this.tbFName.TabIndex = 1;
            this.tbFName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFName_Validating);
            // 
            // tbMName
            // 
            this.tbMName.Location = new System.Drawing.Point(262, 124);
            this.tbMName.Name = "tbMName";
            this.tbMName.Size = new System.Drawing.Size(124, 20);
            this.tbMName.TabIndex = 2;
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(405, 124);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(124, 20);
            this.tbLName.TabIndex = 3;
            this.tbLName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.tbLName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Middle Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gender : ";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(118, 170);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(118, 188);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Birthdate : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Address : ";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(131, 215);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(100, 20);
            this.tbStreet.TabIndex = 7;
            this.tbStreet.Validating += new System.ComponentModel.CancelEventHandler(this.tbStreet_Validating);
            // 
            // tbSubdivision
            // 
            this.tbSubdivision.Location = new System.Drawing.Point(250, 215);
            this.tbSubdivision.Name = "tbSubdivision";
            this.tbSubdivision.Size = new System.Drawing.Size(100, 20);
            this.tbSubdivision.TabIndex = 8;
            this.tbSubdivision.Validating += new System.ComponentModel.CancelEventHandler(this.tbSubdivision_Validating);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(366, 215);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 9;
            this.tbCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbCity_Validating);
            // 
            // tbZipcode
            // 
            this.tbZipcode.Location = new System.Drawing.Point(483, 215);
            this.tbZipcode.Name = "tbZipcode";
            this.tbZipcode.Size = new System.Drawing.Size(59, 20);
            this.tbZipcode.TabIndex = 10;
            this.tbZipcode.Validating += new System.ComponentModel.CancelEventHandler(this.tbZipcode_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Subdivision";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "City / Province";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Zipcode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Contact Number : ";
            // 
            // tbContactNo
            // 
            this.tbContactNo.Location = new System.Drawing.Point(104, 22);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Size = new System.Drawing.Size(147, 20);
            this.tbContactNo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmailAdd);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbContactNo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(35, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 58);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Information";
            // 
            // tbEmailAdd
            // 
            this.tbEmailAdd.Location = new System.Drawing.Point(352, 22);
            this.tbEmailAdd.Name = "tbEmailAdd";
            this.tbEmailAdd.Size = new System.Drawing.Size(147, 20);
            this.tbEmailAdd.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Email Address : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Academic Status :";
            // 
            // tbAcadStatus
            // 
            this.tbAcadStatus.Location = new System.Drawing.Point(128, 259);
            this.tbAcadStatus.Name = "tbAcadStatus";
            this.tbAcadStatus.Size = new System.Drawing.Size(147, 20);
            this.tbAcadStatus.TabIndex = 11;
            this.tbAcadStatus.Validating += new System.ComponentModel.CancelEventHandler(this.tbAcadStatus_Validating);
            // 
            // btnBrowsePic
            // 
            this.btnBrowsePic.Image = global::PLMNFCPrototype.Properties.Resources.btnBrowse;
            this.btnBrowsePic.Location = new System.Drawing.Point(555, 301);
            this.btnBrowsePic.Name = "btnBrowsePic";
            this.btnBrowsePic.Size = new System.Drawing.Size(80, 30);
            this.btnBrowsePic.TabIndex = 16;
            this.btnBrowsePic.UseVisualStyleBackColor = true;
            this.btnBrowsePic.Click += new System.EventHandler(this.btnBrowsePic_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Course : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(74, 298);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "College : ";
            // 
            // cbCollege
            // 
            this.cbCollege.FormattingEnabled = true;
            this.cbCollege.Location = new System.Drawing.Point(129, 293);
            this.cbCollege.Name = "cbCollege";
            this.cbCollege.Size = new System.Drawing.Size(413, 21);
            this.cbCollege.TabIndex = 12;
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(128, 320);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(414, 21);
            this.cbCourse.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Smartcard UID : ";
            // 
            // tbSmartcard
            // 
            this.tbSmartcard.Location = new System.Drawing.Point(129, 348);
            this.tbSmartcard.Name = "tbSmartcard";
            this.tbSmartcard.Size = new System.Drawing.Size(147, 20);
            this.tbSmartcard.TabIndex = 14;
            this.tbSmartcard.TextChanged += new System.EventHandler(this.tbSmartcard_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(782, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(458, 537);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(1044, 72);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(196, 20);
            this.tbSearch.TabIndex = 15;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(779, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(263, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Search by Student Number, First Name or Last Name :";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // btnGetSmartcardUID
            // 
            this.btnGetSmartcardUID.Location = new System.Drawing.Point(283, 347);
            this.btnGetSmartcardUID.Name = "btnGetSmartcardUID";
            this.btnGetSmartcardUID.Size = new System.Drawing.Size(117, 23);
            this.btnGetSmartcardUID.TabIndex = 47;
            this.btnGetSmartcardUID.Text = "Read Smartcard";
            this.btnGetSmartcardUID.UseVisualStyleBackColor = true;
            this.btnGetSmartcardUID.Click += new System.EventHandler(this.btnGetSmartcardUID_Click);
            // 
            // lblUserID_StudentInfo
            // 
            this.lblUserID_StudentInfo.AutoSize = true;
            this.lblUserID_StudentInfo.Location = new System.Drawing.Point(1213, 665);
            this.lblUserID_StudentInfo.Name = "lblUserID_StudentInfo";
            this.lblUserID_StudentInfo.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_StudentInfo.TabIndex = 48;
            this.lblUserID_StudentInfo.Text = "user";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(12, 665);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(22, 13);
            this.lblEdit.TabIndex = 49;
            this.lblEdit.Text = "-----";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(552, 338);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "Note : Picture is a required field";
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.Image = global::PLMNFCPrototype.Properties.Resources.btnUpload;
            this.btnUploadPic.Location = new System.Drawing.Point(675, 301);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(80, 30);
            this.btnUploadPic.TabIndex = 51;
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(552, 355);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(172, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "Upload photo not more than 500kb";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.banStudentInfo;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1275, 50);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(555, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PLMNFCPrototype.Properties.Resources.btnClose;
            this.btnClose.Location = new System.Drawing.Point(425, 56);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::PLMNFCPrototype.Properties.Resources.btnClear;
            this.btnClear.Location = new System.Drawing.Point(344, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 21;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PLMNFCPrototype.Properties.Resources.btnSave;
            this.btnSave.Location = new System.Drawing.Point(262, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PLMNFCPrototype.Properties.Resources.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(181, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PLMNFCPrototype.Properties.Resources.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(100, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PLMNFCPrototype.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(19, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form_StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 687);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblUserID_StudentInfo);
            this.Controls.Add(this.btnGetSmartcardUID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbSmartcard);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.cbCollege);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnBrowsePic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbAcadStatus);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbZipcode);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbSubdivision);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbMName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStudentNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(1280, 726);
            this.Name = "Form_StudentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information Form";
            this.Load += new System.EventHandler(this.Form_StudentInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStudentNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbMName;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbSubdivision;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbZipcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbContactNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEmailAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbAcadStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowsePic;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCollege;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbSmartcard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnGetSmartcardUID;
        private System.Windows.Forms.Label lblUserID_StudentInfo;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}