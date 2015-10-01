namespace PLMNFCPrototype
{
    partial class Form_StudentViolation
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearchStud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSettled = new System.Windows.Forms.CheckBox();
            this.chkUnsettled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbSearchStudVio = new System.Windows.Forms.TextBox();
            this.tbStudentNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbViolation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtViolationDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDateSettled = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rbSettled = new System.Windows.Forms.RadioButton();
            this.rbUnsettled = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbViolationID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUserID_StudVio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(433, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(352, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(109, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(368, 172);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbSearchStud
            // 
            this.tbSearchStud.Location = new System.Drawing.Point(214, 17);
            this.tbSearchStud.Name = "tbSearchStud";
            this.tbSearchStud.Size = new System.Drawing.Size(163, 20);
            this.tbSearchStud.TabIndex = 35;
            this.tbSearchStud.TextChanged += new System.EventHandler(this.tbSearchStud_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search by Student Number / Last Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tbSearchStud);
            this.groupBox1.Location = new System.Drawing.Point(557, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 225);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Student :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Student Number : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSettled);
            this.groupBox2.Controls.Add(this.chkUnsettled);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.tbSearchStudVio);
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 225);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Student Violations";
            // 
            // chkSettled
            // 
            this.chkSettled.AutoSize = true;
            this.chkSettled.Location = new System.Drawing.Point(592, 19);
            this.chkSettled.Name = "chkSettled";
            this.chkSettled.Size = new System.Drawing.Size(59, 17);
            this.chkSettled.TabIndex = 38;
            this.chkSettled.Text = "Settled";
            this.chkSettled.UseVisualStyleBackColor = true;
            this.chkSettled.CheckedChanged += new System.EventHandler(this.chkSettled_CheckedChanged);
            // 
            // chkUnsettled
            // 
            this.chkUnsettled.AutoSize = true;
            this.chkUnsettled.Location = new System.Drawing.Point(515, 19);
            this.chkUnsettled.Name = "chkUnsettled";
            this.chkUnsettled.Size = new System.Drawing.Size(71, 17);
            this.chkUnsettled.TabIndex = 37;
            this.chkUnsettled.Text = "Unsettled";
            this.chkUnsettled.UseVisualStyleBackColor = true;
            this.chkUnsettled.CheckedChanged += new System.EventHandler(this.chkUnsettled_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Student Number :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 43);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(913, 172);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tbSearchStudVio
            // 
            this.tbSearchStudVio.Enabled = false;
            this.tbSearchStudVio.Location = new System.Drawing.Point(98, 16);
            this.tbSearchStudVio.Name = "tbSearchStudVio";
            this.tbSearchStudVio.Size = new System.Drawing.Size(163, 20);
            this.tbSearchStudVio.TabIndex = 35;
            this.tbSearchStudVio.TextChanged += new System.EventHandler(this.tbSearchStudVio_TextChanged);
            // 
            // tbStudentNumber
            // 
            this.tbStudentNumber.Location = new System.Drawing.Point(130, 61);
            this.tbStudentNumber.Name = "tbStudentNumber";
            this.tbStudentNumber.Size = new System.Drawing.Size(236, 20);
            this.tbStudentNumber.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Violation :";
            // 
            // cbViolation
            // 
            this.cbViolation.FormattingEnabled = true;
            this.cbViolation.Location = new System.Drawing.Point(72, 46);
            this.cbViolation.Name = "cbViolation";
            this.cbViolation.Size = new System.Drawing.Size(420, 21);
            this.cbViolation.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Violation Date/Time";
            // 
            // dtViolationDateTime
            // 
            this.dtViolationDateTime.Location = new System.Drawing.Point(120, 75);
            this.dtViolationDateTime.Name = "dtViolationDateTime";
            this.dtViolationDateTime.Size = new System.Drawing.Size(236, 20);
            this.dtViolationDateTime.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Violation Status :";
            // 
            // dtDateSettled
            // 
            this.dtDateSettled.Location = new System.Drawing.Point(120, 130);
            this.dtDateSettled.Name = "dtDateSettled";
            this.dtDateSettled.Size = new System.Drawing.Size(236, 20);
            this.dtDateSettled.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Date Settled :";
            // 
            // rbSettled
            // 
            this.rbSettled.AutoSize = true;
            this.rbSettled.Location = new System.Drawing.Point(220, 107);
            this.rbSettled.Name = "rbSettled";
            this.rbSettled.Size = new System.Drawing.Size(58, 17);
            this.rbSettled.TabIndex = 49;
            this.rbSettled.TabStop = true;
            this.rbSettled.Text = "Settled";
            this.rbSettled.UseVisualStyleBackColor = true;
            this.rbSettled.CheckedChanged += new System.EventHandler(this.rbSettled_CheckedChanged);
            // 
            // rbUnsettled
            // 
            this.rbUnsettled.AutoSize = true;
            this.rbUnsettled.Location = new System.Drawing.Point(120, 107);
            this.rbUnsettled.Name = "rbUnsettled";
            this.rbUnsettled.Size = new System.Drawing.Size(70, 17);
            this.rbUnsettled.TabIndex = 50;
            this.rbUnsettled.TabStop = true;
            this.rbUnsettled.Text = "Unsettled";
            this.rbUnsettled.UseVisualStyleBackColor = true;
            this.rbUnsettled.CheckedChanged += new System.EventHandler(this.rbUnsettled_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Violation ID :";
            // 
            // tbViolationID
            // 
            this.tbViolationID.Location = new System.Drawing.Point(379, 17);
            this.tbViolationID.Name = "tbViolationID";
            this.tbViolationID.Size = new System.Drawing.Size(113, 20);
            this.tbViolationID.TabIndex = 52;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbViolationID);
            this.groupBox3.Controls.Add(this.cbViolation);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rbUnsettled);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rbSettled);
            this.groupBox3.Controls.Add(this.dtViolationDateTime);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtDateSettled);
            this.groupBox3.Location = new System.Drawing.Point(16, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 168);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Violation";
            // 
            // lblUserID_StudVio
            // 
            this.lblUserID_StudVio.AutoSize = true;
            this.lblUserID_StudVio.Location = new System.Drawing.Point(944, 6);
            this.lblUserID_StudVio.Name = "lblUserID_StudVio";
            this.lblUserID_StudVio.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_StudVio.TabIndex = 54;
            this.lblUserID_StudVio.Text = "user";
            // 
            // Form_StudentViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 508);
            this.Controls.Add(this.lblUserID_StudVio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tbStudentNumber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form_StudentViolation";
            this.Text = "Form_StudentViolation";
            this.Load += new System.EventHandler(this.Form_StudentViolation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearchStud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tbSearchStudVio;
        private System.Windows.Forms.TextBox tbStudentNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbViolation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtViolationDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDateSettled;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbSettled;
        private System.Windows.Forms.RadioButton rbUnsettled;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbViolationID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSettled;
        private System.Windows.Forms.CheckBox chkUnsettled;
        private System.Windows.Forms.Label lblUserID_StudVio;
    }
}