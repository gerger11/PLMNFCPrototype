namespace PLMNFCPrototype
{
    partial class Form_Colleges
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCollegeID = new System.Windows.Forms.Label();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.tbCollegeID = new System.Windows.Forms.TextBox();
            this.tbCollegeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbAbbreviation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserID_Colleges = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PLMNFCPrototype.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(16, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PLMNFCPrototype.Properties.Resources.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(97, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PLMNFCPrototype.Properties.Resources.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(178, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PLMNFCPrototype.Properties.Resources.btnSave;
            this.btnSave.Location = new System.Drawing.Point(259, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::PLMNFCPrototype.Properties.Resources.btnClear;
            this.btnClear.Location = new System.Drawing.Point(340, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Image = global::PLMNFCPrototype.Properties.Resources.btnClose;
            this.button1.Location = new System.Drawing.Point(421, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCollegeID
            // 
            this.lblCollegeID.AutoSize = true;
            this.lblCollegeID.Location = new System.Drawing.Point(16, 102);
            this.lblCollegeID.Name = "lblCollegeID";
            this.lblCollegeID.Size = new System.Drawing.Size(56, 13);
            this.lblCollegeID.TabIndex = 6;
            this.lblCollegeID.Text = "College ID";
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.Location = new System.Drawing.Point(16, 129);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(73, 13);
            this.lblCollegeName.TabIndex = 7;
            this.lblCollegeName.Text = "College Name";
            // 
            // tbCollegeID
            // 
            this.tbCollegeID.Location = new System.Drawing.Point(99, 98);
            this.tbCollegeID.Name = "tbCollegeID";
            this.tbCollegeID.Size = new System.Drawing.Size(100, 20);
            this.tbCollegeID.TabIndex = 8;
            // 
            // tbCollegeName
            // 
            this.tbCollegeName.Location = new System.Drawing.Point(99, 125);
            this.tbCollegeName.Name = "tbCollegeName";
            this.tbCollegeName.Size = new System.Drawing.Size(245, 20);
            this.tbCollegeName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search by Name :";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(477, 101);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(196, 20);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 129);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(291, 214);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbAbbreviation
            // 
            this.tbAbbreviation.Location = new System.Drawing.Point(99, 153);
            this.tbAbbreviation.Name = "tbAbbreviation";
            this.tbAbbreviation.Size = new System.Drawing.Size(100, 20);
            this.tbAbbreviation.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Abbreviation";
            // 
            // lblUserID_Colleges
            // 
            this.lblUserID_Colleges.AutoSize = true;
            this.lblUserID_Colleges.Location = new System.Drawing.Point(655, 358);
            this.lblUserID_Colleges.Name = "lblUserID_Colleges";
            this.lblUserID_Colleges.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_Colleges.TabIndex = 15;
            this.lblUserID_Colleges.Text = "user";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(12, 358);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(22, 13);
            this.lblEdit.TabIndex = 16;
            this.lblEdit.Text = "-----";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.banColleges;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 50);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Colleges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblUserID_Colleges);
            this.Controls.Add(this.tbAbbreviation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCollegeName);
            this.Controls.Add(this.tbCollegeID);
            this.Controls.Add(this.lblCollegeName);
            this.Controls.Add(this.lblCollegeID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form_Colleges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colleges";
            this.Load += new System.EventHandler(this.Form_Colleges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCollegeID;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.TextBox tbCollegeID;
        private System.Windows.Forms.TextBox tbCollegeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbAbbreviation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserID_Colleges;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}