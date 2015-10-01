namespace PLMNFCPrototype
{
    partial class Form_ViolationMemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPendingViolation = new System.Windows.Forms.Label();
            this.violationCounter = new System.Windows.Forms.Label();
            this.tbSearchStudVio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveMemo = new System.Windows.Forms.Button();
            this.tbMemoTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMemoFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbInactiveMemo = new System.Windows.Forms.RadioButton();
            this.rbActiveMemo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgStudentMemo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserID_VioMemo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblPendingViolation);
            this.groupBox1.Controls.Add(this.violationCounter);
            this.groupBox1.Controls.Add(this.tbSearchStudVio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student violation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(348, 203);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblPendingViolation
            // 
            this.lblPendingViolation.AutoSize = true;
            this.lblPendingViolation.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingViolation.Location = new System.Drawing.Point(61, 249);
            this.lblPendingViolation.Name = "lblPendingViolation";
            this.lblPendingViolation.Size = new System.Drawing.Size(233, 32);
            this.lblPendingViolation.TabIndex = 39;
            this.lblPendingViolation.Text = "Unsettled Violations";
            // 
            // violationCounter
            // 
            this.violationCounter.AutoSize = true;
            this.violationCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.violationCounter.Location = new System.Drawing.Point(19, 246);
            this.violationCounter.Name = "violationCounter";
            this.violationCounter.Size = new System.Drawing.Size(32, 37);
            this.violationCounter.TabIndex = 38;
            this.violationCounter.Text = "0";
            // 
            // tbSearchStudVio
            // 
            this.tbSearchStudVio.Location = new System.Drawing.Point(203, 17);
            this.tbSearchStudVio.Name = "tbSearchStudVio";
            this.tbSearchStudVio.Size = new System.Drawing.Size(155, 20);
            this.tbSearchStudVio.TabIndex = 1;
            this.tbSearchStudVio.TextChanged += new System.EventHandler(this.tbSearchStudVio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Student Number, Last name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveMemo);
            this.groupBox2.Controls.Add(this.tbMemoTo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbRemarks);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbMemoFrom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(421, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remarks";
            // 
            // btnSaveMemo
            // 
            this.btnSaveMemo.Location = new System.Drawing.Point(227, 242);
            this.btnSaveMemo.Name = "btnSaveMemo";
            this.btnSaveMemo.Size = new System.Drawing.Size(131, 23);
            this.btnSaveMemo.TabIndex = 6;
            this.btnSaveMemo.Text = "Save Memo";
            this.btnSaveMemo.UseVisualStyleBackColor = true;
            this.btnSaveMemo.Click += new System.EventHandler(this.btnSaveMemo_Click);
            // 
            // tbMemoTo
            // 
            this.tbMemoTo.Location = new System.Drawing.Point(71, 13);
            this.tbMemoTo.Name = "tbMemoTo";
            this.tbMemoTo.Size = new System.Drawing.Size(155, 20);
            this.tbMemoTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "To";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(71, 75);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(287, 161);
            this.tbRemarks.TabIndex = 3;
            this.tbRemarks.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remarks";
            // 
            // tbMemoFrom
            // 
            this.tbMemoFrom.Location = new System.Drawing.Point(71, 44);
            this.tbMemoFrom.Name = "tbMemoFrom";
            this.tbMemoFrom.Size = new System.Drawing.Size(155, 20);
            this.tbMemoFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.rbInactiveMemo);
            this.groupBox3.Controls.Add(this.rbActiveMemo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.dgStudentMemo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(26, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 169);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memo Activation / Deactivation";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PLMNFCPrototype.Properties.Resources.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(192, 133);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PLMNFCPrototype.Properties.Resources.btnSave;
            this.btnSave.Location = new System.Drawing.Point(290, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rbInactiveMemo
            // 
            this.rbInactiveMemo.AutoSize = true;
            this.rbInactiveMemo.Location = new System.Drawing.Point(84, 77);
            this.rbInactiveMemo.Name = "rbInactiveMemo";
            this.rbInactiveMemo.Size = new System.Drawing.Size(63, 17);
            this.rbInactiveMemo.TabIndex = 10;
            this.rbInactiveMemo.TabStop = true;
            this.rbInactiveMemo.Text = "Inactive";
            this.rbInactiveMemo.UseVisualStyleBackColor = true;
            // 
            // rbActiveMemo
            // 
            this.rbActiveMemo.AutoSize = true;
            this.rbActiveMemo.Location = new System.Drawing.Point(84, 54);
            this.rbActiveMemo.Name = "rbActiveMemo";
            this.rbActiveMemo.Size = new System.Drawing.Size(55, 17);
            this.rbActiveMemo.TabIndex = 9;
            this.rbActiveMemo.TabStop = true;
            this.rbActiveMemo.Text = "Active";
            this.rbActiveMemo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(596, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 4;
            // 
            // dgStudentMemo
            // 
            this.dgStudentMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudentMemo.Location = new System.Drawing.Point(395, 54);
            this.dgStudentMemo.Name = "dgStudentMemo";
            this.dgStudentMemo.Size = new System.Drawing.Size(358, 109);
            this.dgStudentMemo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Search Stud Memo\'s by Stud. No. / Date";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PLMNFCPrototype.Properties.Resources.btnClose;
            this.btnClose.Location = new System.Drawing.Point(718, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 23;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserID_VioMemo
            // 
            this.lblUserID_VioMemo.AutoSize = true;
            this.lblUserID_VioMemo.Location = new System.Drawing.Point(12, 590);
            this.lblUserID_VioMemo.Name = "lblUserID_VioMemo";
            this.lblUserID_VioMemo.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_VioMemo.TabIndex = 24;
            this.lblUserID_VioMemo.Text = "user";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.banStudentVioMemo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 50);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ViolationMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUserID_VioMemo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ViolationMemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Violation_Memo";
            this.Load += new System.EventHandler(this.Form_ViolationMemo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSearchStudVio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveMemo;
        private System.Windows.Forms.TextBox tbMemoTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMemoFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgStudentMemo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbInactiveMemo;
        private System.Windows.Forms.RadioButton rbActiveMemo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label violationCounter;
        private System.Windows.Forms.Label lblPendingViolation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUserID_VioMemo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}