namespace PLMNFCPrototype
{
    partial class Form_ViolationInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblViolationSanction = new System.Windows.Forms.Label();
            this.lblViolationType = new System.Windows.Forms.Label();
            this.lblViolationName = new System.Windows.Forms.Label();
            this.lblViolationInfoID = new System.Windows.Forms.Label();
            this.tbViolationName = new System.Windows.Forms.TextBox();
            this.tbViolationInfoID = new System.Windows.Forms.TextBox();
            this.cbxViolationType = new System.Windows.Forms.ComboBox();
            this.tbSanction = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID_ViolationInfo = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::PLMNFCPrototype.Properties.Resources.btnClose;
            this.button1.Location = new System.Drawing.Point(423, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::PLMNFCPrototype.Properties.Resources.btnClear;
            this.btnClear.Location = new System.Drawing.Point(342, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 16;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PLMNFCPrototype.Properties.Resources.btnSave;
            this.btnSave.Location = new System.Drawing.Point(261, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 15;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PLMNFCPrototype.Properties.Resources.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(180, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PLMNFCPrototype.Properties.Resources.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(99, 56);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PLMNFCPrototype.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(18, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblViolationSanction
            // 
            this.lblViolationSanction.AutoSize = true;
            this.lblViolationSanction.Location = new System.Drawing.Point(29, 189);
            this.lblViolationSanction.Name = "lblViolationSanction";
            this.lblViolationSanction.Size = new System.Drawing.Size(95, 13);
            this.lblViolationSanction.TabIndex = 26;
            this.lblViolationSanction.Text = "Sanction / Penalty";
            // 
            // lblViolationType
            // 
            this.lblViolationType.AutoSize = true;
            this.lblViolationType.Location = new System.Drawing.Point(30, 161);
            this.lblViolationType.Name = "lblViolationType";
            this.lblViolationType.Size = new System.Drawing.Size(74, 13);
            this.lblViolationType.TabIndex = 25;
            this.lblViolationType.Text = "Violation Type";
            // 
            // lblViolationName
            // 
            this.lblViolationName.AutoSize = true;
            this.lblViolationName.Location = new System.Drawing.Point(30, 133);
            this.lblViolationName.Name = "lblViolationName";
            this.lblViolationName.Size = new System.Drawing.Size(78, 13);
            this.lblViolationName.TabIndex = 24;
            this.lblViolationName.Text = "Violation Name";
            // 
            // lblViolationInfoID
            // 
            this.lblViolationInfoID.AutoSize = true;
            this.lblViolationInfoID.Location = new System.Drawing.Point(30, 106);
            this.lblViolationInfoID.Name = "lblViolationInfoID";
            this.lblViolationInfoID.Size = new System.Drawing.Size(82, 13);
            this.lblViolationInfoID.TabIndex = 23;
            this.lblViolationInfoID.Text = "Violation Info ID";
            // 
            // tbViolationName
            // 
            this.tbViolationName.Location = new System.Drawing.Point(127, 129);
            this.tbViolationName.Name = "tbViolationName";
            this.tbViolationName.Size = new System.Drawing.Size(245, 20);
            this.tbViolationName.TabIndex = 28;
            // 
            // tbViolationInfoID
            // 
            this.tbViolationInfoID.Location = new System.Drawing.Point(127, 102);
            this.tbViolationInfoID.Name = "tbViolationInfoID";
            this.tbViolationInfoID.Size = new System.Drawing.Size(100, 20);
            this.tbViolationInfoID.TabIndex = 27;
            // 
            // cbxViolationType
            // 
            this.cbxViolationType.FormattingEnabled = true;
            this.cbxViolationType.Location = new System.Drawing.Point(127, 155);
            this.cbxViolationType.Name = "cbxViolationType";
            this.cbxViolationType.Size = new System.Drawing.Size(100, 21);
            this.cbxViolationType.TabIndex = 29;
            // 
            // tbSanction
            // 
            this.tbSanction.Location = new System.Drawing.Point(127, 182);
            this.tbSanction.Name = "tbSanction";
            this.tbSanction.Size = new System.Drawing.Size(245, 20);
            this.tbSanction.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(563, 96);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(291, 214);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(658, 68);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(196, 20);
            this.tbSearch.TabIndex = 32;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Search by Name :";
            // 
            // lblUserID_ViolationInfo
            // 
            this.lblUserID_ViolationInfo.AutoSize = true;
            this.lblUserID_ViolationInfo.Location = new System.Drawing.Point(834, 329);
            this.lblUserID_ViolationInfo.Name = "lblUserID_ViolationInfo";
            this.lblUserID_ViolationInfo.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_ViolationInfo.TabIndex = 34;
            this.lblUserID_ViolationInfo.Text = "user";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(15, 329);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(22, 13);
            this.lblEdit.TabIndex = 35;
            this.lblEdit.Text = "-----";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.banViolationInfo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 50);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ViolationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblUserID_ViolationInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSanction);
            this.Controls.Add(this.cbxViolationType);
            this.Controls.Add(this.tbViolationName);
            this.Controls.Add(this.tbViolationInfoID);
            this.Controls.Add(this.lblViolationSanction);
            this.Controls.Add(this.lblViolationType);
            this.Controls.Add(this.lblViolationName);
            this.Controls.Add(this.lblViolationInfoID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form_ViolationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ViolationInfo";
            this.Load += new System.EventHandler(this.Form_ViolationInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblViolationSanction;
        private System.Windows.Forms.Label lblViolationType;
        private System.Windows.Forms.Label lblViolationName;
        private System.Windows.Forms.Label lblViolationInfoID;
        private System.Windows.Forms.TextBox tbViolationName;
        private System.Windows.Forms.TextBox tbViolationInfoID;
        private System.Windows.Forms.ComboBox cbxViolationType;
        private System.Windows.Forms.TextBox tbSanction;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID_ViolationInfo;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}