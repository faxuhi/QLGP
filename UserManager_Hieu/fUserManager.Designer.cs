namespace UserManager_Hieu
{
	partial class fUserManager
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
			this.grbAdmin = new Telerik.WinControls.UI.RadGroupBox();
			this.btnPermissions = new Telerik.WinControls.UI.RadButton();
			this.btnRoles = new Telerik.WinControls.UI.RadButton();
			this.btnUsers = new Telerik.WinControls.UI.RadButton();
			this.grbManagement = new Telerik.WinControls.UI.RadGroupBox();
			this.btnMembers = new Telerik.WinControls.UI.RadButton();
			this.btnFamilies = new Telerik.WinControls.UI.RadButton();
			this.pnlSetting = new Telerik.WinControls.UI.RadPanel();
			this.btnSettings = new Telerik.WinControls.UI.RadButton();
			this.btnPersonalInfo = new Telerik.WinControls.UI.RadButton();
			this.btnLogInOut = new Telerik.WinControls.UI.RadButton();
			this.lblHello = new Telerik.WinControls.UI.RadLabel();
			((System.ComponentModel.ISupportInitialize)(this.grbAdmin)).BeginInit();
			this.grbAdmin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnPermissions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRoles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grbManagement)).BeginInit();
			this.grbManagement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMembers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFamilies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlSetting)).BeginInit();
			this.pnlSetting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPersonalInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLogInOut)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblHello)).BeginInit();
			this.SuspendLayout();
			// 
			// grbAdmin
			// 
			this.grbAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.grbAdmin.Controls.Add(this.btnPermissions);
			this.grbAdmin.Controls.Add(this.btnRoles);
			this.grbAdmin.Controls.Add(this.btnUsers);
			this.grbAdmin.HeaderText = "Admin";
			this.grbAdmin.Location = new System.Drawing.Point(24, 25);
			this.grbAdmin.Name = "grbAdmin";
			this.grbAdmin.Size = new System.Drawing.Size(477, 111);
			this.grbAdmin.TabIndex = 0;
			this.grbAdmin.Text = "Admin";
			this.grbAdmin.EnabledChanged += new System.EventHandler(this.grbAdmin_EnabledChanged);
			// 
			// btnPermissions
			// 
			this.btnPermissions.Location = new System.Drawing.Point(316, 32);
			this.btnPermissions.Name = "btnPermissions";
			this.btnPermissions.Size = new System.Drawing.Size(125, 50);
			this.btnPermissions.TabIndex = 1;
			this.btnPermissions.Text = "Permissions";
			this.btnPermissions.Click += new System.EventHandler(this.btnPermissons_Click);
			// 
			// btnRoles
			// 
			this.btnRoles.Location = new System.Drawing.Point(170, 32);
			this.btnRoles.Name = "btnRoles";
			this.btnRoles.Size = new System.Drawing.Size(125, 50);
			this.btnRoles.TabIndex = 1;
			this.btnRoles.Text = "Roles";
			this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
			// 
			// btnUsers
			// 
			this.btnUsers.Location = new System.Drawing.Point(24, 32);
			this.btnUsers.Name = "btnUsers";
			this.btnUsers.Size = new System.Drawing.Size(125, 50);
			this.btnUsers.TabIndex = 0;
			this.btnUsers.Text = "Users";
			this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
			// 
			// grbManagement
			// 
			this.grbManagement.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.grbManagement.Controls.Add(this.btnMembers);
			this.grbManagement.Controls.Add(this.btnFamilies);
			this.grbManagement.HeaderText = "Management";
			this.grbManagement.Location = new System.Drawing.Point(24, 162);
			this.grbManagement.Name = "grbManagement";
			this.grbManagement.Size = new System.Drawing.Size(477, 100);
			this.grbManagement.TabIndex = 1;
			this.grbManagement.Text = "Management";
			// 
			// btnMembers
			// 
			this.btnMembers.Location = new System.Drawing.Point(170, 30);
			this.btnMembers.Name = "btnMembers";
			this.btnMembers.Size = new System.Drawing.Size(125, 50);
			this.btnMembers.TabIndex = 1;
			this.btnMembers.Text = "Members";
			this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
			// 
			// btnFamilies
			// 
			this.btnFamilies.Location = new System.Drawing.Point(24, 30);
			this.btnFamilies.Name = "btnFamilies";
			this.btnFamilies.Size = new System.Drawing.Size(125, 50);
			this.btnFamilies.TabIndex = 1;
			this.btnFamilies.Text = "Families";
			// 
			// pnlSetting
			// 
			this.pnlSetting.Controls.Add(this.btnSettings);
			this.pnlSetting.Controls.Add(this.btnPersonalInfo);
			this.pnlSetting.Controls.Add(this.btnLogInOut);
			this.pnlSetting.Location = new System.Drawing.Point(532, 34);
			this.pnlSetting.Name = "pnlSetting";
			this.pnlSetting.Size = new System.Drawing.Size(165, 225);
			this.pnlSetting.TabIndex = 2;
			// 
			// btnSettings
			// 
			this.btnSettings.Location = new System.Drawing.Point(20, 161);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(125, 35);
			this.btnSettings.TabIndex = 1;
			this.btnSettings.Text = "Setting";
			// 
			// btnPersonalInfo
			// 
			this.btnPersonalInfo.Location = new System.Drawing.Point(20, 89);
			this.btnPersonalInfo.Name = "btnPersonalInfo";
			this.btnPersonalInfo.Size = new System.Drawing.Size(125, 35);
			this.btnPersonalInfo.TabIndex = 1;
			this.btnPersonalInfo.Text = "Personal Info";
			this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
			// 
			// btnLogInOut
			// 
			this.btnLogInOut.Location = new System.Drawing.Point(20, 20);
			this.btnLogInOut.Name = "btnLogInOut";
			this.btnLogInOut.Size = new System.Drawing.Size(125, 35);
			this.btnLogInOut.TabIndex = 1;
			this.btnLogInOut.Text = "Login/Logout";
			this.btnLogInOut.Click += new System.EventHandler(this.btnLogInOut_Click);
			// 
			// lblHello
			// 
			this.lblHello.Location = new System.Drawing.Point(532, 10);
			this.lblHello.Name = "lblHello";
			this.lblHello.Size = new System.Drawing.Size(35, 18);
			this.lblHello.TabIndex = 3;
			this.lblHello.Text = "Guest";
			// 
			// fUserManager
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 289);
			this.Controls.Add(this.lblHello);
			this.Controls.Add(this.pnlSetting);
			this.Controls.Add(this.grbManagement);
			this.Controls.Add(this.grbAdmin);
			this.Name = "fUserManager";
			this.Text = "Hi Guest";
			this.Load += new System.EventHandler(this.fUserManager_Load);
			this.Shown += new System.EventHandler(this.fUserManager_Shown);
			((System.ComponentModel.ISupportInitialize)(this.grbAdmin)).EndInit();
			this.grbAdmin.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnPermissions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRoles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grbManagement)).EndInit();
			this.grbManagement.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnMembers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFamilies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlSetting)).EndInit();
			this.pnlSetting.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPersonalInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLogInOut)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblHello)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadGroupBox grbAdmin;
		private Telerik.WinControls.UI.RadGroupBox grbManagement;
		private Telerik.WinControls.UI.RadPanel pnlSetting;
		private Telerik.WinControls.UI.RadButton btnPermissions;
		private Telerik.WinControls.UI.RadButton btnRoles;
		private Telerik.WinControls.UI.RadButton btnUsers;
		private Telerik.WinControls.UI.RadButton btnMembers;
		private Telerik.WinControls.UI.RadButton btnFamilies;
		private Telerik.WinControls.UI.RadButton btnSettings;
		private Telerik.WinControls.UI.RadButton btnPersonalInfo;
		private Telerik.WinControls.UI.RadButton btnLogInOut;
		private Telerik.WinControls.UI.RadLabel lblHello;
	}
}