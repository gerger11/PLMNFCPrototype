namespace PLMNFCPrototype
{
    partial class Form_CardActivation
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
            this.lblUserID_CardActive = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStudentNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSmartcard = new System.Windows.Forms.TextBox();
            this.btnReadSmartcard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 120);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(390, 214);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(514, 92);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(209, 20);
            this.tbSearch.TabIndex = 14;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by Last Name, Student No. :";
            // 
            // lblUserID_CardActive
            // 
            this.lblUserID_CardActive.AutoSize = true;
            this.lblUserID_CardActive.Location = new System.Drawing.Point(722, 371);
            this.lblUserID_CardActive.Name = "lblUserID_CardActive";
            this.lblUserID_CardActive.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_CardActive.TabIndex = 22;
            this.lblUserID_CardActive.Text = "user";
            // 
            // button1
            // 
            this.button1.Image = global::PLMNFCPrototype.Properties.Resources.btnClose;
            this.button1.Location = new System.Drawing.Point(183, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::PLMNFCPrototype.Properties.Resources.btnClear;
            this.btnClear.Location = new System.Drawing.Point(102, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 20;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PLMNFCPrototype.Properties.Resources.btnSave;
            this.btnSave.Location = new System.Drawing.Point(21, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 19;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Student Number :";
            // 
            // tbStudentNumber
            // 
            this.tbStudentNumber.Location = new System.Drawing.Point(125, 116);
            this.tbStudentNumber.Name = "tbStudentNumber";
            this.tbStudentNumber.Size = new System.Drawing.Size(170, 20);
            this.tbStudentNumber.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tag Smartcard";
            // 
            // tbSmartcard
            // 
            this.tbSmartcard.Enabled = false;
            this.tbSmartcard.Location = new System.Drawing.Point(111, 142);
            this.tbSmartcard.Name = "tbSmartcard";
            this.tbSmartcard.Size = new System.Drawing.Size(100, 20);
            this.tbSmartcard.TabIndex = 26;
            // 
            // btnReadSmartcard
            // 
            this.btnReadSmartcard.Location = new System.Drawing.Point(218, 141);
            this.btnReadSmartcard.Name = "btnReadSmartcard";
            this.btnReadSmartcard.Size = new System.Drawing.Size(77, 23);
            this.btnReadSmartcard.TabIndex = 27;
            this.btnReadSmartcard.Text = "Read Card";
            this.btnReadSmartcard.UseVisualStyleBackColor = true;
            this.btnReadSmartcard.Click += new System.EventHandler(this.btnReadSmartcard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.banCardActivation;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form_CardActivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReadSmartcard);
            this.Controls.Add(this.tbSmartcard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStudentNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserID_CardActive);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form_CardActivation";
            this.Text = "Form_CardActivation";
            this.Load += new System.EventHandler(this.Form_CardActivation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID_CardActive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStudentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSmartcard;
        private System.Windows.Forms.Button btnReadSmartcard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}