namespace UserManager_Hieu
{
	partial class fLogin
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
			this.lblUserName = new Telerik.WinControls.UI.RadLabel();
			this.lblPassword = new Telerik.WinControls.UI.RadLabel();
			this.btnLogOut = new Telerik.WinControls.UI.RadButton();
			this.btnLogIn = new Telerik.WinControls.UI.RadButton();
			this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
			this.chkRememberMe = new Telerik.WinControls.UI.RadCheckBox();
			this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
			this.llbSignUp = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.lblUserName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLogIn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkRememberMe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
			this.SuspendLayout();
			// 
			// lblUserName
			// 
			this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.Location = new System.Drawing.Point(25, 23);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(75, 21);
			this.lblUserName.TabIndex = 0;
			this.lblUserName.Text = "User Name:";
			// 
			// lblPassword
			// 
			this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(25, 86);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(65, 21);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password:";
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(192, 189);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(125, 50);
			this.btnLogOut.TabIndex = 3;
			this.btnLogOut.Text = "Logout";
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// btnLogIn
			// 
			this.btnLogIn.Location = new System.Drawing.Point(25, 189);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(125, 50);
			this.btnLogIn.TabIndex = 4;
			this.btnLogIn.Text = "Login";
			this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(126, 18);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Padding = new System.Windows.Forms.Padding(3);
			this.txtUserName.Size = new System.Drawing.Size(191, 26);
			this.txtUserName.TabIndex = 5;
			// 
			// chkRememberMe
			// 
			this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkRememberMe.Location = new System.Drawing.Point(25, 143);
			this.chkRememberMe.Name = "chkRememberMe";
			this.chkRememberMe.Size = new System.Drawing.Size(108, 21);
			this.chkRememberMe.TabIndex = 6;
			this.chkRememberMe.Text = "Remember Me";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(126, 81);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(191, 26);
			this.txtPassword.TabIndex = 7;
			// 
			// llbSignUp
			// 
			this.llbSignUp.AutoSize = true;
			this.llbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llbSignUp.Location = new System.Drawing.Point(180, 143);
			this.llbSignUp.Name = "llbSignUp";
			this.llbSignUp.Size = new System.Drawing.Size(125, 16);
			this.llbSignUp.TabIndex = 8;
			this.llbSignUp.TabStop = true;
			this.llbSignUp.Text = "Sign-Up an Account";
			this.llbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignUp_LinkClicked);
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 261);
			this.Controls.Add(this.llbSignUp);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.chkRememberMe);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.btnLogIn);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Name = "fLogin";
			this.Text = "Login";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fLogin_FormClosed);
			this.Load += new System.EventHandler(this.fLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.lblUserName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLogIn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkRememberMe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadLabel lblUserName;
		private Telerik.WinControls.UI.RadLabel lblPassword;
		private Telerik.WinControls.UI.RadButton btnLogOut;
		private Telerik.WinControls.UI.RadButton btnLogIn;
		private Telerik.WinControls.UI.RadTextBox txtUserName;
		private Telerik.WinControls.UI.RadCheckBox chkRememberMe;
		private Telerik.WinControls.UI.RadTextBox txtPassword;
		private System.Windows.Forms.LinkLabel llbSignUp;
	}
}