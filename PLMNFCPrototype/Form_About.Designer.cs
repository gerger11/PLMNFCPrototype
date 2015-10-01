namespace PLMNFCPrototype
{
    partial class Form_About
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
            this.lblEmpTypeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmpTypeID
            // 
            this.lblEmpTypeID.AutoSize = true;
            this.lblEmpTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpTypeID.Location = new System.Drawing.Point(121, 104);
            this.lblEmpTypeID.Name = "lblEmpTypeID";
            this.lblEmpTypeID.Size = new System.Drawing.Size(108, 13);
            this.lblEmpTypeID.TabIndex = 21;
            this.lblEmpTypeID.Text = "by Macopa Carabaos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(120, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "All Rights Reserved 2015";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.about;
            this.ClientSize = new System.Drawing.Size(399, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpTypeID);
            this.Name = "Form_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About PLM-SIMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpTypeID;
        private System.Windows.Forms.Label label1;
    }
}