namespace UserManager_Hieu
{
	partial class fImportUser
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
			Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
			this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
			this.btnExport = new Telerik.WinControls.UI.RadButton();
			this.btnImportToDatabase = new Telerik.WinControls.UI.RadButton();
			this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
			this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
			this.rbnGhiDe = new Telerik.WinControls.UI.RadRadioButton();
			this.rbnNoGhiDe = new Telerik.WinControls.UI.RadRadioButton();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
			this.btnImport = new Telerik.WinControls.UI.RadButton();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
			this.dgvImport = new Telerik.WinControls.UI.RadGridView();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
			this.radPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
			this.radPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnImportToDatabase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
			this.radPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rbnGhiDe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rbnNoGhiDe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
			this.radPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvImport.MasterTemplate)).BeginInit();
			this.SuspendLayout();
			// 
			// radPanel1
			// 
			this.radPanel1.Controls.Add(this.tableLayoutPanel1);
			this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radPanel1.Location = new System.Drawing.Point(0, 0);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new System.Drawing.Size(654, 490);
			this.radPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.radPanel4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.radPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.radPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 490);
			this.tableLayoutPanel1.TabIndex = 24;
			// 
			// radPanel4
			// 
			this.radPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.radPanel4.Controls.Add(this.btnExport);
			this.radPanel4.Controls.Add(this.btnImportToDatabase);
			this.radPanel4.Location = new System.Drawing.Point(15, 413);
			this.radPanel4.Name = "radPanel4";
			this.radPanel4.Size = new System.Drawing.Size(624, 65);
			this.radPanel4.TabIndex = 1;
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(25, 16);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(96, 35);
			this.btnExport.TabIndex = 16;
			this.btnExport.Text = "Export File Lỗi";
			// 
			// btnImportToDatabase
			// 
			this.btnImportToDatabase.Location = new System.Drawing.Point(475, 16);
			this.btnImportToDatabase.Name = "btnImportToDatabase";
			this.btnImportToDatabase.Size = new System.Drawing.Size(129, 35);
			this.btnImportToDatabase.TabIndex = 23;
			this.btnImportToDatabase.Text = "Import vào Database";
			this.btnImportToDatabase.Click += new System.EventHandler(this.btnImportToDatabase_Click);
			// 
			// radPanel2
			// 
			this.radPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.radPanel2.Controls.Add(this.radGroupBox1);
			this.radPanel2.Controls.Add(this.radLabel1);
			this.radPanel2.Controls.Add(this.txtPassword);
			this.radPanel2.Controls.Add(this.btnImport);
			this.radPanel2.Controls.Add(this.radLabel2);
			this.radPanel2.Location = new System.Drawing.Point(15, 3);
			this.radPanel2.Name = "radPanel2";
			this.radPanel2.Size = new System.Drawing.Size(624, 114);
			this.radPanel2.TabIndex = 1;
			// 
			// radGroupBox1
			// 
			this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.rbnGhiDe);
			this.radGroupBox1.Controls.Add(this.rbnNoGhiDe);
			this.radGroupBox1.HeaderText = "Chế Độ Import";
			this.radGroupBox1.Location = new System.Drawing.Point(25, 20);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new System.Drawing.Size(273, 79);
			this.radGroupBox1.TabIndex = 20;
			this.radGroupBox1.Text = "Chế Độ Import";
			// 
			// rbnGhiDe
			// 
			this.rbnGhiDe.CheckState = System.Windows.Forms.CheckState.Checked;
			this.rbnGhiDe.Location = new System.Drawing.Point(19, 35);
			this.rbnGhiDe.Name = "rbnGhiDe";
			this.rbnGhiDe.Size = new System.Drawing.Size(109, 18);
			this.rbnGhiDe.TabIndex = 17;
			this.rbnGhiDe.Text = "Ghi đè User đã có";
			this.rbnGhiDe.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
			// 
			// rbnNoGhiDe
			// 
			this.rbnNoGhiDe.Location = new System.Drawing.Point(145, 35);
			this.rbnNoGhiDe.Name = "rbnNoGhiDe";
			this.rbnNoGhiDe.Size = new System.Drawing.Size(113, 18);
			this.rbnNoGhiDe.TabIndex = 18;
			this.rbnNoGhiDe.TabStop = false;
			this.rbnNoGhiDe.Text = "Không ghi đè User";
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(319, 28);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(90, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Mật Khẩu Chung";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(415, 28);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(190, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(509, 64);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(96, 35);
			this.btnImport.TabIndex = 15;
			this.btnImport.Text = "File to Import";
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// radLabel2
			// 
			this.radLabel2.AutoSize = false;
			this.radLabel2.Location = new System.Drawing.Point(319, 52);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(172, 56);
			this.radLabel2.TabIndex = 16;
			this.radLabel2.Text = "Chỉ import đúng định dạng Excel ở phân Export bên ngoài";
			// 
			// radPanel3
			// 
			this.radPanel3.Controls.Add(this.dgvImport);
			this.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radPanel3.Location = new System.Drawing.Point(3, 123);
			this.radPanel3.Name = "radPanel3";
			this.radPanel3.Size = new System.Drawing.Size(648, 284);
			this.radPanel3.TabIndex = 2;
			// 
			// dgvImport
			// 
			this.dgvImport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvImport.Location = new System.Drawing.Point(0, 0);
			// 
			// 
			// 
			this.dgvImport.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.dgvImport.Name = "dgvImport";
			this.dgvImport.Size = new System.Drawing.Size(648, 284);
			this.dgvImport.TabIndex = 21;
			this.dgvImport.Click += new System.EventHandler(this.dgvImport_Click);
			// 
			// fImportUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 490);
			this.Controls.Add(this.radPanel1);
			this.Name = "fImportUser";
			this.Text = "fImportUser";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fImportUser_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
			this.radPanel1.ResumeLayout(false);
			this.radPanel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
			this.radPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnImportToDatabase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
			this.radPanel2.ResumeLayout(false);
			this.radPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rbnGhiDe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rbnNoGhiDe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
			this.radPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvImport.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadPanel radPanel1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadTextBox txtPassword;
		private Telerik.WinControls.UI.RadButton btnImport;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadRadioButton rbnNoGhiDe;
		private Telerik.WinControls.UI.RadRadioButton rbnGhiDe;
		private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
		private Telerik.WinControls.UI.RadGridView dgvImport;
		private Telerik.WinControls.UI.RadButton btnExport;
		private Telerik.WinControls.UI.RadButton btnImportToDatabase;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Telerik.WinControls.UI.RadPanel radPanel2;
		private Telerik.WinControls.UI.RadPanel radPanel3;
		private Telerik.WinControls.UI.RadPanel radPanel4;
	}
}