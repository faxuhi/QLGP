namespace UserManager_Hieu
{
	partial class fPermission
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
			System.Windows.Forms.Label nameLabel;
			this.permissionETTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtName = new Telerik.WinControls.UI.RadTextBox();
			this.btnAddPermission = new Telerik.WinControls.UI.RadButton();
			nameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.permissionETTBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddPermission)).BeginInit();
			this.SuspendLayout();
			// 
			// permissionETTBindingSource
			// 
			this.permissionETTBindingSource.DataSource = typeof(UserManager.Models.PermissionETT);
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(52, 69);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(38, 13);
			nameLabel.TabIndex = 1;
			nameLabel.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissionETTBindingSource, "Name", true));
			this.txtName.Location = new System.Drawing.Point(119, 62);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(225, 20);
			this.txtName.TabIndex = 2;
			// 
			// btnAddPermission
			// 
			this.btnAddPermission.Location = new System.Drawing.Point(494, 210);
			this.btnAddPermission.Name = "btnAddPermission";
			this.btnAddPermission.Size = new System.Drawing.Size(128, 35);
			this.btnAddPermission.TabIndex = 17;
			this.btnAddPermission.Text = "Add Permission";
			this.btnAddPermission.Click += new System.EventHandler(this.btnAddPermission_Click);
			// 
			// fPermission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddPermission);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.txtName);
			this.Name = "fPermission";
			this.Text = "fPermission";
			((System.ComponentModel.ISupportInitialize)(this.permissionETTBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddPermission)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource permissionETTBindingSource;
		private Telerik.WinControls.UI.RadTextBox txtName;
		private Telerik.WinControls.UI.RadButton btnAddPermission;
	}
}