namespace PLMNFCPrototype
{
    partial class Form_EmployeeType
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
            this.tbEmpTypeName = new System.Windows.Forms.TextBox();
            this.tbEmpTypeID = new System.Windows.Forms.TextBox();
            this.lblEmpTypeName = new System.Windows.Forms.Label();
            this.lblEmpTypeID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID_EmpType = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmpTypeName
            // 
            this.tbEmpTypeName.Location = new System.Drawing.Point(135, 124);
            this.tbEmpTypeName.Name = "tbEmpTypeName";
            this.tbEmpTypeName.Size = new System.Drawing.Size(245, 20);
            this.tbEmpTypeName.TabIndex = 23;
            // 
            // tbEmpTypeID
            // 
            this.tbEmpTypeID.Location = new System.Drawing.Point(135, 98);
            this.tbEmpTypeID.Name = "tbEmpTypeID";
            this.tbEmpTypeID.Size = new System.Drawing.Size(100, 20);
            this.tbEmpTypeID.TabIndex = 22;
            // 
            // lblEmpTypeName
            // 
            this.lblEmpTypeName.AutoSize = true;
            this.lblEmpTypeName.Location = new System.Drawing.Point(20, 128);
            this.lblEmpTypeName.Name = "lblEmpTypeName";
            this.lblEmpTypeName.Size = new System.Drawing.Size(111, 13);
            this.lblEmpTypeName.TabIndex = 21;
            this.lblEmpTypeName.Text = "Employee Type Name";
            // 
            // lblEmpTypeID
            // 
            this.lblEmpTypeID.AutoSize = true;
            this.lblEmpTypeID.Location = new System.Drawing.Point(20, 101);
            this.lblEmpTypeID.Name = "lblEmpTypeID";
            this.lblEmpTypeID.Size = new System.Drawing.Size(94, 13);
            this.lblEmpTypeID.TabIndex = 20;
            this.lblEmpTypeID.Text = "Employee Type ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(486, 122);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(291, 214);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(581, 94);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(196, 20);
            this.tbSearch.TabIndex = 25;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search by Name :";
            // 
            // lblUserID_EmpType
            // 
            this.lblUserID_EmpType.AutoSize = true;
            this.lblUserID_EmpType.Location = new System.Drawing.Point(762, 358);
            this.lblUserID_EmpType.Name = "lblUserID_EmpType";
            this.lblUserID_EmpType.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_EmpType.TabIndex = 27;
            this.lblUserID_EmpType.Text = "user";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(12, 358);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(22, 13);
            this.lblEdit.TabIndex = 28;
            this.lblEdit.Text = "-----";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.banEmployeeType;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 50);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
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
            // Form_EmployeeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblUserID_EmpType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmpTypeName);
            this.Controls.Add(this.tbEmpTypeID);
            this.Controls.Add(this.lblEmpTypeName);
            this.Controls.Add(this.lblEmpTypeID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form_EmployeeType";
            this.Text = "Form_EmployeeType";
            this.Load += new System.EventHandler(this.Form_EmployeeType_Load);
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
        private System.Windows.Forms.TextBox tbEmpTypeName;
        private System.Windows.Forms.TextBox tbEmpTypeID;
        private System.Windows.Forms.Label lblEmpTypeName;
        private System.Windows.Forms.Label lblEmpTypeID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID_EmpType;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}