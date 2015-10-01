namespace PLMNFCPrototype
{
    partial class Form_RunSQLScripts
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.lblUserID_RunSQL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 382);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(19, 62);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(66, 17);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "SELECT";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(91, 62);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(68, 17);
            this.rbCreate.TabIndex = 2;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "CREATE";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // lblUserID_RunSQL
            // 
            this.lblUserID_RunSQL.AutoSize = true;
            this.lblUserID_RunSQL.Location = new System.Drawing.Point(16, 568);
            this.lblUserID_RunSQL.Name = "lblUserID_RunSQL";
            this.lblUserID_RunSQL.Size = new System.Drawing.Size(27, 13);
            this.lblUserID_RunSQL.TabIndex = 49;
            this.lblUserID_RunSQL.Text = "user";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 95);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(349, 382);
            this.dataGridView1.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.banRunSQLScripts;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1275, 50);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.Image = global::PLMNFCPrototype.Properties.Resources.btnRun;
            this.btnRun.Location = new System.Drawing.Point(289, 484);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 30);
            this.btnRun.TabIndex = 3;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form_RunSQLScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 596);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblUserID_RunSQL);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.rbCreate);
            this.Controls.Add(this.rbSelect);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form_RunSQLScripts";
            this.Text = "Form_RunSQLScripts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblUserID_RunSQL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}