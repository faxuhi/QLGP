namespace UserManager_Hieu
{
	partial class test
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label passWordLabel;
			System.Windows.Forms.Label phoneLabel;
			System.Windows.Forms.Label userNameLabel;
			this.userDTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.userDTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
			this.txtName = new Telerik.WinControls.UI.RadTextBox();
			this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
			this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
			this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
			this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnAddUser = new System.Windows.Forms.Button();
			emailLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			passWordLabel = new System.Windows.Forms.Label();
			phoneLabel = new System.Windows.Forms.Label();
			userNameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.userDTOBindingNavigator)).BeginInit();
			this.userDTOBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// userDTOBindingNavigator
			// 
			this.userDTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.userDTOBindingNavigator.BindingSource = this.userDTOBindingSource;
			this.userDTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.userDTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.userDTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userDTOBindingNavigatorSaveItem});
			this.userDTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.userDTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.userDTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.userDTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.userDTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.userDTOBindingNavigator.Name = "userDTOBindingNavigator";
			this.userDTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.userDTOBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.userDTOBindingNavigator.TabIndex = 0;
			this.userDTOBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// userDTOBindingNavigatorSaveItem
			// 
			this.userDTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.userDTOBindingNavigatorSaveItem.Enabled = false;
			this.userDTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userDTOBindingNavigatorSaveItem.Image")));
			this.userDTOBindingNavigatorSaveItem.Name = "userDTOBindingNavigatorSaveItem";
			this.userDTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.userDTOBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Location = new System.Drawing.Point(92, 51);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(35, 13);
			emailLabel.TabIndex = 1;
			emailLabel.Text = "Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Email", true));
			this.txtEmail.Location = new System.Drawing.Point(161, 51);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(250, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(92, 77);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(38, 13);
			nameLabel.TabIndex = 3;
			nameLabel.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Name", true));
			this.txtName.Location = new System.Drawing.Point(161, 77);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(250, 20);
			this.txtName.TabIndex = 4;
			// 
			// passWordLabel
			// 
			passWordLabel.AutoSize = true;
			passWordLabel.Location = new System.Drawing.Point(92, 103);
			passWordLabel.Name = "passWordLabel";
			passWordLabel.Size = new System.Drawing.Size(62, 13);
			passWordLabel.TabIndex = 5;
			passWordLabel.Text = "Pass Word:";
			// 
			// txtPassword
			// 
			this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "PassWord", true));
			this.txtPassword.Location = new System.Drawing.Point(161, 103);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(250, 20);
			this.txtPassword.TabIndex = 6;
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new System.Drawing.Point(92, 129);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new System.Drawing.Size(41, 13);
			phoneLabel.TabIndex = 7;
			phoneLabel.Text = "Phone:";
			// 
			// txtPhone
			// 
			this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Phone", true));
			this.txtPhone.Location = new System.Drawing.Point(161, 129);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(250, 20);
			this.txtPhone.TabIndex = 8;
			// 
			// userNameLabel
			// 
			userNameLabel.AutoSize = true;
			userNameLabel.Location = new System.Drawing.Point(92, 155);
			userNameLabel.Name = "userNameLabel";
			userNameLabel.Size = new System.Drawing.Size(63, 13);
			userNameLabel.TabIndex = 9;
			userNameLabel.Text = "User Name:";
			// 
			// txtUserName
			// 
			this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "UserName", true));
			this.txtUserName.Location = new System.Drawing.Point(161, 155);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(250, 20);
			this.txtUserName.TabIndex = 10;
			// 
			// userDTOBindingSource
			// 
			this.userDTOBindingSource.DataSource = typeof(DTO.UserDTO);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Location = new System.Drawing.Point(335, 218);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(75, 23);
			this.btnAddUser.TabIndex = 11;
			this.btnAddUser.Text = "button1";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(emailLabel);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.txtName);
			this.Controls.Add(passWordLabel);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(phoneLabel);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(userNameLabel);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.userDTOBindingNavigator);
			this.Name = "test";
			this.Text = "test";
			((System.ComponentModel.ISupportInitialize)(this.userDTOBindingNavigator)).EndInit();
			this.userDTOBindingNavigator.ResumeLayout(false);
			this.userDTOBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource userDTOBindingSource;
		private System.Windows.Forms.BindingNavigator userDTOBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton userDTOBindingNavigatorSaveItem;
		private Telerik.WinControls.UI.RadTextBox txtEmail;
		private Telerik.WinControls.UI.RadTextBox txtName;
		private Telerik.WinControls.UI.RadTextBox txtPassword;
		private Telerik.WinControls.UI.RadTextBox txtPhone;
		private Telerik.WinControls.UI.RadTextBox txtUserName;
		private System.Windows.Forms.Button btnAddUser;
	}
}