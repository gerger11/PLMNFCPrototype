namespace PLMNFCPrototype
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violationInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSQLScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentViolationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentViolationMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardActivationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardDeactivationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentSwipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPLMSIMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblLongTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.queriesToolStripMenuItem,
            this.aboutTheSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collegesToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.employeeTypeToolStripMenuItem,
            this.violationInformationToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.runSQLScriptsToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // collegesToolStripMenuItem
            // 
            this.collegesToolStripMenuItem.Name = "collegesToolStripMenuItem";
            this.collegesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.collegesToolStripMenuItem.Text = "Colleges";
            this.collegesToolStripMenuItem.Click += new System.EventHandler(this.collegesToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // employeeTypeToolStripMenuItem
            // 
            this.employeeTypeToolStripMenuItem.Name = "employeeTypeToolStripMenuItem";
            this.employeeTypeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.employeeTypeToolStripMenuItem.Text = "Employee Type";
            this.employeeTypeToolStripMenuItem.Click += new System.EventHandler(this.employeeTypeToolStripMenuItem_Click);
            // 
            // violationInformationToolStripMenuItem
            // 
            this.violationInformationToolStripMenuItem.Name = "violationInformationToolStripMenuItem";
            this.violationInformationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.violationInformationToolStripMenuItem.Text = "Violation Information";
            this.violationInformationToolStripMenuItem.Click += new System.EventHandler(this.violationInformationToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.accountsToolStripMenuItem.Text = "Accounts";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // runSQLScriptsToolStripMenuItem
            // 
            this.runSQLScriptsToolStripMenuItem.Name = "runSQLScriptsToolStripMenuItem";
            this.runSQLScriptsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.runSQLScriptsToolStripMenuItem.Text = "Run SQL Scripts";
            this.runSQLScriptsToolStripMenuItem.Click += new System.EventHandler(this.runSQLScriptsToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInformationToolStripMenuItem,
            this.emToolStripMenuItem,
            this.studentViolationsToolStripMenuItem,
            this.studentViolationMemoToolStripMenuItem,
            this.cardActivationToolStripMenuItem,
            this.cardDeactivationToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // emToolStripMenuItem
            // 
            this.emToolStripMenuItem.Name = "emToolStripMenuItem";
            this.emToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.emToolStripMenuItem.Text = "Employee Information";
            this.emToolStripMenuItem.Click += new System.EventHandler(this.emToolStripMenuItem_Click);
            // 
            // studentViolationsToolStripMenuItem
            // 
            this.studentViolationsToolStripMenuItem.Name = "studentViolationsToolStripMenuItem";
            this.studentViolationsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.studentViolationsToolStripMenuItem.Text = "Student Violations";
            this.studentViolationsToolStripMenuItem.Click += new System.EventHandler(this.studentViolationsToolStripMenuItem_Click);
            // 
            // studentViolationMemoToolStripMenuItem
            // 
            this.studentViolationMemoToolStripMenuItem.Name = "studentViolationMemoToolStripMenuItem";
            this.studentViolationMemoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.studentViolationMemoToolStripMenuItem.Text = "Student Violation Memo";
            this.studentViolationMemoToolStripMenuItem.Click += new System.EventHandler(this.studentViolationMemoToolStripMenuItem_Click);
            // 
            // cardActivationToolStripMenuItem
            // 
            this.cardActivationToolStripMenuItem.Name = "cardActivationToolStripMenuItem";
            this.cardActivationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cardActivationToolStripMenuItem.Text = "Card Activation";
            this.cardActivationToolStripMenuItem.Click += new System.EventHandler(this.cardActivationToolStripMenuItem_Click);
            // 
            // cardDeactivationToolStripMenuItem
            // 
            this.cardDeactivationToolStripMenuItem.Name = "cardDeactivationToolStripMenuItem";
            this.cardDeactivationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cardDeactivationToolStripMenuItem.Text = "Card Deactivation";
            this.cardDeactivationToolStripMenuItem.Click += new System.EventHandler(this.cardDeactivationToolStripMenuItem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentSwipesToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // studentSwipesToolStripMenuItem
            // 
            this.studentSwipesToolStripMenuItem.Name = "studentSwipesToolStripMenuItem";
            this.studentSwipesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.studentSwipesToolStripMenuItem.Text = "Student Swipes";
            this.studentSwipesToolStripMenuItem.Click += new System.EventHandler(this.studentSwipesToolStripMenuItem_Click);
            // 
            // aboutTheSystemToolStripMenuItem
            // 
            this.aboutTheSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPLMSIMSToolStripMenuItem});
            this.aboutTheSystemToolStripMenuItem.Name = "aboutTheSystemToolStripMenuItem";
            this.aboutTheSystemToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.aboutTheSystemToolStripMenuItem.Text = "About the System";
            // 
            // aboutPLMSIMSToolStripMenuItem
            // 
            this.aboutPLMSIMSToolStripMenuItem.Name = "aboutPLMSIMSToolStripMenuItem";
            this.aboutPLMSIMSToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aboutPLMSIMSToolStripMenuItem.Text = "About PLM-SIMS";
            this.aboutPLMSIMSToolStripMenuItem.Click += new System.EventHandler(this.aboutPLMSIMSToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblLongTime
            // 
            this.lblLongTime.AutoSize = true;
            this.lblLongTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLongTime.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLongTime.ForeColor = System.Drawing.Color.White;
            this.lblLongTime.Location = new System.Drawing.Point(875, 161);
            this.lblLongTime.Name = "lblLongTime";
            this.lblLongTime.Size = new System.Drawing.Size(98, 30);
            this.lblLongTime.TabIndex = 18;
            this.lblLongTime.Text = "DynTime";
            this.lblLongTime.Click += new System.EventHandler(this.lblLongTime_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(875, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 30);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "DynDate";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(0, 658);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(58, 13);
            this.lblWelcome.TabIndex = 19;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Location = new System.Drawing.Point(53, 658);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(27, 13);
            this.lblUserID.TabIndex = 20;
            this.lblUserID.Text = "user";
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEmpLastName.ForeColor = System.Drawing.Color.White;
            this.lblEmpLastName.Location = new System.Drawing.Point(842, 271);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(174, 30);
            this.lblEmpLastName.TabIndex = 21;
            this.lblEmpLastName.Text = "lblEmpLastName";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(842, 303);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(96, 21);
            this.lblUserType.TabIndex = 22;
            this.lblUserType.Text = "lblUserType";
            // 
            // pbEmployee
            // 
            this.pbEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pbEmployee.Location = new System.Drawing.Point(1145, 243);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(90, 90);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 23;
            this.pbEmployee.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(1155, 358);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PLMNFCPrototype.Properties.Resources.PLMSIMS_MainForm2;
            this.ClientSize = new System.Drawing.Size(1264, 671);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblEmpLastName);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblLongTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1280, 710);
            this.MinimumSize = new System.Drawing.Size(1280, 710);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pamantasan ng Lungsod ng Maynila - Smartcard Identification Management System (PL" +
    "M-SIMS)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem violationInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentViolationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardActivationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardDeactivationToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblLongTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolStripMenuItem studentViolationMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPLMSIMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentSwipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runSQLScriptsToolStripMenuItem;
    }
}

