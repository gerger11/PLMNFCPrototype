namespace PLMNFCPrototype
{
    partial class Form_CardDeactivation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadCard = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblUserID_CardDeactive = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbActivate = new System.Windows.Forms.RadioButton();
            this.rbDeactivate = new System.Windows.Forms.RadioButton();
            this.tbStudentNo = new System.Windows.Forms.TextBox();
            this.tbSmartcardUID = new System.Windows.Forms.TextBox();
            this.grpDeactivationReason = new System.Windows.Forms.GroupBox();
            this.tbRemarks = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbStolen = new System.Windows.Forms.RadioButton();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDeactivationReason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 144);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(262, 262);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(314, 20);
            this.tbSearch.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by Smartcard/Student Number/Last Name";
            // 
            // btnReadCard
            // 
            this.btnReadCard.Location = new System.Drawing.Point(582, 260);
            this.btnReadCard.Name = "btnReadCard";
            this.btnReadCard.Size = new System.Drawing.Size(75, 23);
            this.btnReadCard.TabIndex = 16;
            this.btnReadCard.Text = "Read Card";
            this.btnReadCard.UseVisualStyleBackColor = true;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(10, 447);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(22, 13);
            this.lblEdit.TabIndex = 20;
            this.lblEdit.Text = "-----";
            // 
            // lblUserID_CardDeactive
            // 
            this.lblUserID_CardDeactive.AutoSize = true;
            this.lblUserID_CardDeactive.Location = new System.Drawing.Point(1033, 447);
            this.lblUserID_CardDeactive.Name = "lblUserID_CardDeactive";
            this.lblUserID_CardDeactive.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_CardDeactive.TabIndex = 19;
            this.lblUserID_CardDeactive.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Smartcard UID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Smartcard Status";
            // 
            // rbActivate
            // 
            this.rbActivate.AutoSize = true;
            this.rbActivate.Location = new System.Drawing.Point(54, 171);
            this.rbActivate.Name = "rbActivate";
            this.rbActivate.Size = new System.Drawing.Size(70, 17);
            this.rbActivate.TabIndex = 30;
            this.rbActivate.TabStop = true;
            this.rbActivate.Text = "Activated";
            this.rbActivate.UseVisualStyleBackColor = true;
            this.rbActivate.CheckedChanged += new System.EventHandler(this.rbActivate_CheckedChanged);
            // 
            // rbDeactivate
            // 
            this.rbDeactivate.AutoSize = true;
            this.rbDeactivate.Location = new System.Drawing.Point(54, 194);
            this.rbDeactivate.Name = "rbDeactivate";
            this.rbDeactivate.Size = new System.Drawing.Size(83, 17);
            this.rbDeactivate.TabIndex = 31;
            this.rbDeactivate.TabStop = true;
            this.rbDeactivate.Text = "Deactivated";
            this.rbDeactivate.UseVisualStyleBackColor = true;
            this.rbDeactivate.CheckedChanged += new System.EventHandler(this.rbDeactivate_CheckedChanged);
            // 
            // tbStudentNo
            // 
            this.tbStudentNo.Location = new System.Drawing.Point(138, 99);
            this.tbStudentNo.Name = "tbStudentNo";
            this.tbStudentNo.Size = new System.Drawing.Size(145, 20);
            this.tbStudentNo.TabIndex = 32;
            // 
            // tbSmartcardUID
            // 
            this.tbSmartcardUID.Location = new System.Drawing.Point(138, 126);
            this.tbSmartcardUID.Name = "tbSmartcardUID";
            this.tbSmartcardUID.Size = new System.Drawing.Size(145, 20);
            this.tbSmartcardUID.TabIndex = 33;
            // 
            // grpDeactivationReason
            // 
            this.grpDeactivationReason.Controls.Add(this.tbRemarks);
            this.grpDeactivationReason.Controls.Add(this.label6);
            this.grpDeactivationReason.Controls.Add(this.label5);
            this.grpDeactivationReason.Controls.Add(this.dateTimePicker1);
            this.grpDeactivationReason.Controls.Add(this.rbStolen);
            this.grpDeactivationReason.Controls.Add(this.rbLost);
            this.grpDeactivationReason.Controls.Add(this.rbDamaged);
            this.grpDeactivationReason.Location = new System.Drawing.Point(171, 171);
            this.grpDeactivationReason.Name = "grpDeactivationReason";
            this.grpDeactivationReason.Size = new System.Drawing.Size(486, 83);
            this.grpDeactivationReason.TabIndex = 34;
            this.grpDeactivationReason.TabStop = false;
            this.grpDeactivationReason.Text = "Reason for Deactivation";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(63, 37);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(417, 33);
            this.tbRemarks.TabIndex = 31;
            this.tbRemarks.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Remarks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // rbStolen
            // 
            this.rbStolen.AutoSize = true;
            this.rbStolen.Location = new System.Drawing.Point(138, 16);
            this.rbStolen.Name = "rbStolen";
            this.rbStolen.Size = new System.Drawing.Size(55, 17);
            this.rbStolen.TabIndex = 2;
            this.rbStolen.TabStop = true;
            this.rbStolen.Text = "Stolen";
            this.rbStolen.UseVisualStyleBackColor = true;
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Location = new System.Drawing.Point(87, 16);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(45, 17);
            this.rbLost.TabIndex = 1;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost";
            this.rbLost.UseVisualStyleBackColor = true;
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Location = new System.Drawing.Point(10, 16);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(71, 17);
            this.rbDamaged.TabIndex = 0;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "Damaged";
            this.rbDamaged.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PLMNFCPrototype.Properties.Resources.btnClose;
            this.btnClose.Location = new System.Drawing.Point(423, 56);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::PLMNFCPrototype.Properties.Resources.btnClear;
            this.btnClear.Location = new System.Drawing.Point(342, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 25;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PLMNFCPrototype.Properties.Resources.btnSave;
            this.btnSave.Location = new System.Drawing.Point(261, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 24;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PLMNFCPrototype.Properties.Resources.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(180, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PLMNFCPrototype.Properties.Resources.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(99, 56);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.banCardDeactivation;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PLMNFCPrototype.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(18, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(783, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 361);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Deactivated Smartcards";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 296);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form_CardDeactivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbDeactivate);
            this.Controls.Add(this.grpDeactivationReason);
            this.Controls.Add(this.tbSmartcardUID);
            this.Controls.Add(this.tbStudentNo);
            this.Controls.Add(this.rbActivate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblUserID_CardDeactive);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReadCard);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form_CardDeactivation";
            this.Text = "Form_CardDeactivation";
            this.Load += new System.EventHandler(this.Form_CardDeactivation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDeactivationReason.ResumeLayout(false);
            this.grpDeactivationReason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblUserID_CardDeactive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbActivate;
        private System.Windows.Forms.RadioButton rbDeactivate;
        private System.Windows.Forms.TextBox tbStudentNo;
        private System.Windows.Forms.TextBox tbSmartcardUID;
        private System.Windows.Forms.GroupBox grpDeactivationReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbStolen;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.RichTextBox tbRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}