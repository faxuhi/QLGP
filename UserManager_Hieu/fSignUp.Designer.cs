namespace UserManager_Hieu
{
	partial class fSignUp
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
			System.Windows.Forms.Label birthdayLabel;
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label introLabel;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label passwordLabel;
			System.Windows.Forms.Label phoneLabel;
			System.Windows.Forms.Label userNameLabel;
			System.Windows.Forms.Label label1;
			this.btnOk = new Telerik.WinControls.UI.RadButton();
			this.dtpBirthday = new Telerik.WinControls.UI.RadDateTimePicker();
			this.userValidateETTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
			this.rtbIntro = new Telerik.WinControls.UI.RadRichTextEditor();
			this.txtName = new Telerik.WinControls.UI.RadTextBox();
			this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
			this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
			this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
			this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
			this.txtConfirmPassword = new Telerik.WinControls.UI.RadTextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			birthdayLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			introLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			passwordLabel = new System.Windows.Forms.Label();
			phoneLabel = new System.Windows.Forms.Label();
			userNameLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpBirthday)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userValidateETTBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rtbIntro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
			this.radPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// birthdayLabel
			// 
			birthdayLabel.AutoSize = true;
			birthdayLabel.Location = new System.Drawing.Point(365, 67);
			birthdayLabel.Name = "birthdayLabel";
			birthdayLabel.Size = new System.Drawing.Size(53, 13);
			birthdayLabel.TabIndex = 23;
			birthdayLabel.Text = "Birthday:";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Location = new System.Drawing.Point(22, 134);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(37, 13);
			emailLabel.TabIndex = 25;
			emailLabel.Text = "Email:";
			// 
			// introLabel
			// 
			introLabel.AutoSize = true;
			introLabel.Location = new System.Drawing.Point(365, 99);
			introLabel.Name = "introLabel";
			introLabel.Size = new System.Drawing.Size(35, 13);
			introLabel.TabIndex = 27;
			introLabel.Text = "Intro:";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(365, 22);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(39, 13);
			nameLabel.TabIndex = 29;
			nameLabel.Text = "Name:";
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Location = new System.Drawing.Point(22, 60);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new System.Drawing.Size(59, 13);
			passwordLabel.TabIndex = 31;
			passwordLabel.Text = "Password:";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new System.Drawing.Point(22, 169);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new System.Drawing.Size(43, 13);
			phoneLabel.TabIndex = 33;
			phoneLabel.Text = "Phone:";
			// 
			// userNameLabel
			// 
			userNameLabel.AutoSize = true;
			userNameLabel.Location = new System.Drawing.Point(22, 22);
			userNameLabel.Name = "userNameLabel";
			userNameLabel.Size = new System.Drawing.Size(65, 13);
			userNameLabel.TabIndex = 35;
			userNameLabel.Text = "User Name:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(21, 103);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(103, 13);
			label1.TabIndex = 33;
			label1.Text = "Confirm Password:";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(511, 200);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(125, 50);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "Ok";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.btnOk.Validating += new System.ComponentModel.CancelEventHandler(this.btnOk_Validating);
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userValidateETTBindingSource, "Birthday", true));
			this.dtpBirthday.Location = new System.Drawing.Point(434, 60);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthday.TabIndex = 24;
			this.dtpBirthday.TabStop = false;
			this.dtpBirthday.Text = "Thursday, March 21, 2024";
			this.dtpBirthday.Value = new System.DateTime(2024, 3, 21, 1, 45, 22, 340);
			// 
			// userValidateETTBindingSource
			// 
			this.userValidateETTBindingSource.DataSource = typeof(DAL.Models.Entities.UserValidateETT);
			// 
			// txtEmail
			// 
			this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidateETTBindingSource, "Email", true));
			this.txtEmail.Location = new System.Drawing.Point(130, 134);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(200, 20);
			this.txtEmail.TabIndex = 26;
			// 
			// rtbIntro
			// 
			this.rtbIntro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
			this.rtbIntro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidateETTBindingSource, "Intro", true));
			this.rtbIntro.Location = new System.Drawing.Point(434, 96);
			this.rtbIntro.Name = "rtbIntro";
			this.rtbIntro.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
			this.rtbIntro.Size = new System.Drawing.Size(200, 87);
			this.rtbIntro.TabIndex = 28;
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidateETTBindingSource, "Name", true));
			this.txtName.Location = new System.Drawing.Point(434, 22);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(200, 20);
			this.txtName.TabIndex = 30;
			// 
			// txtPassword
			// 
			this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidateETTBindingSource, "Password", true));
			this.txtPassword.Location = new System.Drawing.Point(130, 60);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(200, 20);
			this.txtPassword.TabIndex = 32;
			// 
			// txtPhone
			// 
			this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidateETTBindingSource, "Phone", true));
			this.txtPhone.Location = new System.Drawing.Point(130, 169);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(200, 20);
			this.txtPhone.TabIndex = 34;
			// 
			// txtUserName
			// 
			this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidateETTBindingSource, "UserName", true));
			this.txtUserName.Location = new System.Drawing.Point(130, 22);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(200, 20);
			this.txtUserName.TabIndex = 36;
			// 
			// radPanel1
			// 
			this.radPanel1.Controls.Add(this.txtConfirmPassword);
			this.radPanel1.Controls.Add(label1);
			this.radPanel1.Controls.Add(this.txtName);
			this.radPanel1.Controls.Add(this.btnOk);
			this.radPanel1.Controls.Add(this.txtUserName);
			this.radPanel1.Controls.Add(birthdayLabel);
			this.radPanel1.Controls.Add(userNameLabel);
			this.radPanel1.Controls.Add(this.dtpBirthday);
			this.radPanel1.Controls.Add(this.txtPhone);
			this.radPanel1.Controls.Add(emailLabel);
			this.radPanel1.Controls.Add(phoneLabel);
			this.radPanel1.Controls.Add(this.txtEmail);
			this.radPanel1.Controls.Add(this.txtPassword);
			this.radPanel1.Controls.Add(introLabel);
			this.radPanel1.Controls.Add(passwordLabel);
			this.radPanel1.Controls.Add(this.rtbIntro);
			this.radPanel1.Controls.Add(nameLabel);
			this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radPanel1.Location = new System.Drawing.Point(0, 0);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new System.Drawing.Size(666, 275);
			this.radPanel1.TabIndex = 39;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(130, 96);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(200, 20);
			this.txtConfirmPassword.TabIndex = 34;
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
			this.errorProvider1.ContainerControl = this;
			this.errorProvider1.DataSource = this.userValidateETTBindingSource;
			// 
			// fSignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 275);
			this.Controls.Add(this.radPanel1);
			this.Name = "fSignUp";
			this.Text = "Đăng Ký Tài Khoản";
			this.Load += new System.EventHandler(this.fSignUp_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpBirthday)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userValidateETTBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rtbIntro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
			this.radPanel1.ResumeLayout(false);
			this.radPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Telerik.WinControls.UI.RadButton btnOk;
		private System.Windows.Forms.BindingSource userValidateETTBindingSource;
		private Telerik.WinControls.UI.RadDateTimePicker dtpBirthday;
		private Telerik.WinControls.UI.RadTextBox txtEmail;
		//private System.Windows.Forms.RichTextBox introRichTextBox;
		private Telerik.WinControls.UI.RadTextBox txtName;
		private Telerik.WinControls.UI.RadTextBox txtPhone;
		private Telerik.WinControls.UI.RadPanel radPanel1;
		private Telerik.WinControls.UI.RadRichTextEditor rtbIntro;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Telerik.WinControls.UI.RadTextBox txtPassword;
		private Telerik.WinControls.UI.RadTextBox txtUserName;
		private Telerik.WinControls.UI.RadTextBox txtConfirmPassword;
	}
}