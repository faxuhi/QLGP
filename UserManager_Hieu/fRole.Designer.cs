namespace UserManager_Hieu
{
	partial class fRole
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
			System.Windows.Forms.Label activeLabel;
			System.Windows.Forms.Label descriptionLabel;
			System.Windows.Forms.Label nameLabel;
			this.btnAddRole = new Telerik.WinControls.UI.RadButton();
			this.grbPermission = new Telerik.WinControls.UI.RadGroupBox();
			this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
			this.roleETTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rbtActive = new System.Windows.Forms.RadioButton();
			this.rtxDescription = new System.Windows.Forms.RichTextBox();
			this.txtName = new Telerik.WinControls.UI.RadTextBox();
			activeLabel = new System.Windows.Forms.Label();
			descriptionLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.btnAddRole)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grbPermission)).BeginInit();
			this.grbPermission.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roleETTBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddRole
			// 
			this.btnAddRole.Location = new System.Drawing.Point(724, 372);
			this.btnAddRole.Name = "btnAddRole";
			this.btnAddRole.Size = new System.Drawing.Size(83, 35);
			this.btnAddRole.TabIndex = 16;
			this.btnAddRole.Text = "Add Role";
			this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
			// 
			// grbPermission
			// 
			this.grbPermission.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.grbPermission.Controls.Add(this.radCheckBox1);
			this.grbPermission.HeaderText = "Permission";
			this.grbPermission.Location = new System.Drawing.Point(81, 158);
			this.grbPermission.Name = "grbPermission";
			this.grbPermission.Size = new System.Drawing.Size(726, 186);
			this.grbPermission.TabIndex = 19;
			this.grbPermission.Text = "Permission";
			// 
			// radCheckBox1
			// 
			this.radCheckBox1.Location = new System.Drawing.Point(17, 40);
			this.radCheckBox1.Name = "radCheckBox1";
			this.radCheckBox1.Size = new System.Drawing.Size(91, 18);
			this.radCheckBox1.TabIndex = 0;
			this.radCheckBox1.Text = "radCheckBox1";
			// 
			// roleETTBindingSource
			// 
			this.roleETTBindingSource.DataSource = typeof(UserManager.Models.RoleETT);
			// 
			// activeLabel
			// 
			activeLabel.AutoSize = true;
			activeLabel.Location = new System.Drawing.Point(284, 31);
			activeLabel.Name = "activeLabel";
			activeLabel.Size = new System.Drawing.Size(40, 13);
			activeLabel.TabIndex = 20;
			activeLabel.Text = "Active:";
			// 
			// rbtActive
			// 
			this.rbtActive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.roleETTBindingSource, "Active", true));
			this.rbtActive.Location = new System.Drawing.Point(343, 25);
			this.rbtActive.Name = "rbtActive";
			this.rbtActive.Size = new System.Drawing.Size(104, 24);
			this.rbtActive.TabIndex = 21;
			this.rbtActive.TabStop = true;
			this.rbtActive.Text = "Active";
			this.rbtActive.UseVisualStyleBackColor = true;
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Location = new System.Drawing.Point(439, 31);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new System.Drawing.Size(63, 13);
			descriptionLabel.TabIndex = 22;
			descriptionLabel.Text = "Description:";
			// 
			// rtxDescription
			// 
			this.rtxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roleETTBindingSource, "Description", true));
			this.rtxDescription.Location = new System.Drawing.Point(523, 31);
			this.rtxDescription.Name = "rtxDescription";
			this.rtxDescription.Size = new System.Drawing.Size(284, 96);
			this.rtxDescription.TabIndex = 23;
			this.rtxDescription.Text = "";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(27, 31);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(38, 13);
			nameLabel.TabIndex = 24;
			nameLabel.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roleETTBindingSource, "Name", true));
			this.txtName.Location = new System.Drawing.Point(81, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(179, 20);
			this.txtName.TabIndex = 25;
			// 
			// fRole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 431);
			this.Controls.Add(activeLabel);
			this.Controls.Add(this.rbtActive);
			this.Controls.Add(descriptionLabel);
			this.Controls.Add(this.rtxDescription);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.grbPermission);
			this.Controls.Add(this.btnAddRole);
			this.Name = "fRole";
			this.Text = "fRole";
			((System.ComponentModel.ISupportInitialize)(this.btnAddRole)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grbPermission)).EndInit();
			this.grbPermission.ResumeLayout(false);
			this.grbPermission.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roleETTBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadButton btnAddRole;
		private Telerik.WinControls.UI.RadGroupBox grbPermission;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
		private System.Windows.Forms.BindingSource roleETTBindingSource;
		private System.Windows.Forms.RadioButton rbtActive;
		private System.Windows.Forms.RichTextBox rtxDescription;
		private Telerik.WinControls.UI.RadTextBox txtName;
	}
}