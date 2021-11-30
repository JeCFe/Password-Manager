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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.txtBxMasterPassword = new System.Windows.Forms.TextBox();
            this.txtBxAccountName = new System.Windows.Forms.TextBox();
            this.txtBxAccountEmail = new System.Windows.Forms.TextBox();
            this.txtBxAccountPassword = new System.Windows.Forms.TextBox();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblAccountEmail = new System.Windows.Forms.Label();
            this.lblAccountPass = new System.Windows.Forms.Label();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ltBxAccounts = new System.Windows.Forms.ListBox();
            this.ckBxLowChars = new System.Windows.Forms.CheckBox();
            this.ckBxNumbers = new System.Windows.Forms.CheckBox();
            this.ckBxSpecial = new System.Windows.Forms.CheckBox();
            this.lblMaster = new System.Windows.Forms.Label();
            this.numPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.ckBxUpperChar = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.btnShowAccount, "btnShowAccount");
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.UseVisualStyleBackColor = false;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnDeleteSelected
            // 
            resources.ApplyResources(this.btnDeleteSelected, "btnDeleteSelected");
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // txtBxMasterPassword
            // 
            resources.ApplyResources(this.txtBxMasterPassword, "txtBxMasterPassword");
            this.txtBxMasterPassword.Name = "txtBxMasterPassword";
            // 
            // txtBxAccountName
            // 
            resources.ApplyResources(this.txtBxAccountName, "txtBxAccountName");
            this.txtBxAccountName.Name = "txtBxAccountName";
            // 
            // txtBxAccountEmail
            // 
            resources.ApplyResources(this.txtBxAccountEmail, "txtBxAccountEmail");
            this.txtBxAccountEmail.Name = "txtBxAccountEmail";
            // 
            // txtBxAccountPassword
            // 
            resources.ApplyResources(this.txtBxAccountPassword, "txtBxAccountPassword");
            this.txtBxAccountPassword.Name = "txtBxAccountPassword";
            // 
            // lblAccName
            // 
            resources.ApplyResources(this.lblAccName, "lblAccName");
            this.lblAccName.Name = "lblAccName";
            // 
            // lblAccountEmail
            // 
            resources.ApplyResources(this.lblAccountEmail, "lblAccountEmail");
            this.lblAccountEmail.Name = "lblAccountEmail";
            // 
            // lblAccountPass
            // 
            resources.ApplyResources(this.lblAccountPass, "lblAccountPass");
            this.lblAccountPass.Name = "lblAccountPass";
            // 
            // btnAddAcc
            // 
            resources.ApplyResources(this.btnAddAcc, "btnAddAcc");
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ltBxAccounts
            // 
            this.ltBxAccounts.FormattingEnabled = true;
            resources.ApplyResources(this.ltBxAccounts, "ltBxAccounts");
            this.ltBxAccounts.Name = "ltBxAccounts";
            // 
            // ckBxLowChars
            // 
            resources.ApplyResources(this.ckBxLowChars, "ckBxLowChars");
            this.ckBxLowChars.Name = "ckBxLowChars";
            this.ckBxLowChars.UseVisualStyleBackColor = true;
            // 
            // ckBxNumbers
            // 
            resources.ApplyResources(this.ckBxNumbers, "ckBxNumbers");
            this.ckBxNumbers.Name = "ckBxNumbers";
            this.ckBxNumbers.UseVisualStyleBackColor = true;
            // 
            // ckBxSpecial
            // 
            resources.ApplyResources(this.ckBxSpecial, "ckBxSpecial");
            this.ckBxSpecial.Name = "ckBxSpecial";
            this.ckBxSpecial.UseVisualStyleBackColor = true;
            // 
            // lblMaster
            // 
            resources.ApplyResources(this.lblMaster, "lblMaster");
            this.lblMaster.Name = "lblMaster";
            // 
            // numPasswordLength
            // 
            resources.ApplyResources(this.numPasswordLength, "numPasswordLength");
            this.numPasswordLength.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numPasswordLength.Name = "numPasswordLength";
            // 
            // ckBxUpperChar
            // 
            resources.ApplyResources(this.ckBxUpperChar, "ckBxUpperChar");
            this.ckBxUpperChar.Name = "ckBxUpperChar";
            this.ckBxUpperChar.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtNewPassword
            // 
            resources.ApplyResources(this.txtNewPassword, "txtNewPassword");
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.ckBxUpperChar);
            this.Controls.Add(this.numPasswordLength);
            this.Controls.Add(this.lblMaster);
            this.Controls.Add(this.ckBxSpecial);
            this.Controls.Add(this.ckBxNumbers);
            this.Controls.Add(this.ckBxLowChars);
            this.Controls.Add(this.ltBxAccounts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.lblAccountPass);
            this.Controls.Add(this.lblAccountEmail);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.txtBxAccountPassword);
            this.Controls.Add(this.txtBxAccountEmail);
            this.Controls.Add(this.txtBxAccountName);
            this.Controls.Add(this.txtBxMasterPassword);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnShowAccount);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.TextBox txtBxMasterPassword;
        private System.Windows.Forms.TextBox txtBxAccountName;
        private System.Windows.Forms.TextBox txtBxAccountEmail;
        private System.Windows.Forms.TextBox txtBxAccountPassword;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblAccountEmail;
        private System.Windows.Forms.Label lblAccountPass;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox ltBxAccounts;
        private System.Windows.Forms.CheckBox ckBxLowChars;
        private System.Windows.Forms.CheckBox ckBxNumbers;
        private System.Windows.Forms.CheckBox ckBxSpecial;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.NumericUpDown numPasswordLength;
        private System.Windows.Forms.CheckBox ckBxUpperChar;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPassword;
    }
}

