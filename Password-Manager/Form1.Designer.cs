namespace Password_Manager
{
    partial class Form1
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
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.txtBxMasterPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBxAccountName = new System.Windows.Forms.TextBox();
            this.txtBxAccountEmail = new System.Windows.Forms.TextBox();
            this.txtBxAccountPassword = new System.Windows.Forms.TextBox();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblAccountEmail = new System.Windows.Forms.Label();
            this.lblAccountPass = new System.Windows.Forms.Label();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ltBxAccounts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(580, 415);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(101, 23);
            this.btnShowAccount.TabIndex = 1;
            this.btnShowAccount.Text = "Show Selected";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(687, 415);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(101, 23);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // txtBxMasterPassword
            // 
            this.txtBxMasterPassword.Location = new System.Drawing.Point(472, 13);
            this.txtBxMasterPassword.Name = "txtBxMasterPassword";
            this.txtBxMasterPassword.Size = new System.Drawing.Size(102, 20);
            this.txtBxMasterPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBxAccountName
            // 
            this.txtBxAccountName.Location = new System.Drawing.Point(472, 96);
            this.txtBxAccountName.Name = "txtBxAccountName";
            this.txtBxAccountName.Size = new System.Drawing.Size(102, 20);
            this.txtBxAccountName.TabIndex = 5;
            // 
            // txtBxAccountEmail
            // 
            this.txtBxAccountEmail.Location = new System.Drawing.Point(472, 135);
            this.txtBxAccountEmail.Name = "txtBxAccountEmail";
            this.txtBxAccountEmail.Size = new System.Drawing.Size(101, 20);
            this.txtBxAccountEmail.TabIndex = 6;
            // 
            // txtBxAccountPassword
            // 
            this.txtBxAccountPassword.Location = new System.Drawing.Point(472, 174);
            this.txtBxAccountPassword.Name = "txtBxAccountPassword";
            this.txtBxAccountPassword.Size = new System.Drawing.Size(102, 20);
            this.txtBxAccountPassword.TabIndex = 7;
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(486, 80);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(78, 13);
            this.lblAccName.TabIndex = 8;
            this.lblAccName.Text = "Account Name";
            // 
            // lblAccountEmail
            // 
            this.lblAccountEmail.AutoSize = true;
            this.lblAccountEmail.Location = new System.Drawing.Point(486, 119);
            this.lblAccountEmail.Name = "lblAccountEmail";
            this.lblAccountEmail.Size = new System.Drawing.Size(75, 13);
            this.lblAccountEmail.TabIndex = 9;
            this.lblAccountEmail.Text = "Account Email";
            // 
            // lblAccountPass
            // 
            this.lblAccountPass.AutoSize = true;
            this.lblAccountPass.Location = new System.Drawing.Point(477, 158);
            this.lblAccountPass.Name = "lblAccountPass";
            this.lblAccountPass.Size = new System.Drawing.Size(96, 13);
            this.lblAccountPass.TabIndex = 10;
            this.lblAccountPass.Text = "Account Password";
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(472, 200);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(102, 23);
            this.btnAddAcc.TabIndex = 11;
            this.btnAddAcc.Text = "Add Account";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(472, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(472, 383);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // ltBxAccounts
            // 
            this.ltBxAccounts.FormattingEnabled = true;
            this.ltBxAccounts.Location = new System.Drawing.Point(580, 12);
            this.ltBxAccounts.Name = "ltBxAccounts";
            this.ltBxAccounts.Size = new System.Drawing.Size(208, 394);
            this.ltBxAccounts.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltBxAccounts);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.lblAccountPass);
            this.Controls.Add(this.lblAccountEmail);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.txtBxAccountPassword);
            this.Controls.Add(this.txtBxAccountEmail);
            this.Controls.Add(this.txtBxAccountName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxMasterPassword);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnShowAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.TextBox txtBxMasterPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxAccountName;
        private System.Windows.Forms.TextBox txtBxAccountEmail;
        private System.Windows.Forms.TextBox txtBxAccountPassword;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblAccountEmail;
        private System.Windows.Forms.Label lblAccountPass;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox ltBxAccounts;
    }
}

