namespace UserManager_Hieu
{
	partial class fUsers
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
			Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
			this.btnSearch = new Telerik.WinControls.UI.RadButton();
			this.lblUserName = new Telerik.WinControls.UI.RadLabel();
			this.ddlsearch = new Telerik.WinControls.UI.RadDropDownList();
			this.btnAdd = new Telerik.WinControls.UI.RadButton();
			this.btnDelete = new Telerik.WinControls.UI.RadButton();
			this.btnExport = new Telerik.WinControls.UI.RadButton();
			this.btnImport = new Telerik.WinControls.UI.RadButton();
			this.btnPrint = new Telerik.WinControls.UI.RadButton();
			this.dgvUsers = new Telerik.WinControls.UI.RadGridView();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnImportCustom = new Telerik.WinControls.UI.RadButton();
			this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
			this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
			this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
			this.ddlNumRecord = new Telerik.WinControls.UI.RadDropDownList();
			this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
			this.btnPrevious = new Telerik.WinControls.UI.RadButton();
			this.btnNext = new Telerik.WinControls.UI.RadButton();
			this.printDocUser = new Telerik.WinControls.UI.RadPrintDocument();
			this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
			this.lblPages = new Telerik.WinControls.UI.RadLabel();
			((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUserName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ddlsearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnImportCustom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
			this.radPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
			this.radPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
			this.radPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlNumRecord)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPages)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(600, 18);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(83, 35);
			this.btnSearch.TabIndex = 13;
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblUserName
			// 
			this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.Location = new System.Drawing.Point(17, 29);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(65, 21);
			this.lblUserName.TabIndex = 14;
			this.lblUserName.Text = "Tìm Kiếm:";
			// 
			// ddlsearch
			// 
			this.ddlsearch.DropDownAnimationEnabled = true;
			this.ddlsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ddlsearch.Location = new System.Drawing.Point(392, 22);
			this.ddlsearch.Name = "ddlsearch";
			this.ddlsearch.Padding = new System.Windows.Forms.Padding(3);
			this.ddlsearch.Size = new System.Drawing.Size(187, 29);
			this.ddlsearch.TabIndex = 21;
			this.ddlsearch.Text = "radDropDownList1";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(17, 72);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(83, 35);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(122, 72);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(83, 35);
			this.btnDelete.TabIndex = 22;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(600, 72);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(83, 35);
			this.btnExport.TabIndex = 23;
			this.btnExport.Text = "Export";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(496, 72);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(83, 35);
			this.btnImport.TabIndex = 14;
			this.btnImport.Text = "Import";
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(392, 72);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(83, 35);
			this.btnPrint.TabIndex = 24;
			this.btnPrint.Text = "Print";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// dgvUsers
			// 
			this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUsers.Location = new System.Drawing.Point(0, 0);
			// 
			// 
			// 
			this.dgvUsers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
			this.dgvUsers.MasterTemplate.ViewDefinition = tableViewDefinition1;
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.Size = new System.Drawing.Size(741, 352);
			this.dgvUsers.TabIndex = 26;
			this.dgvUsers.PrintCellFormatting += new Telerik.WinControls.UI.PrintCellFormattingEventHandler(this.dgvUsers_PrintCellFormatting);
			this.dgvUsers.DoubleClick += new System.EventHandler(this.dgvUsers_DoubleClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnImportCustom
			// 
			this.btnImportCustom.Location = new System.Drawing.Point(288, 72);
			this.btnImportCustom.Name = "btnImportCustom";
			this.btnImportCustom.Size = new System.Drawing.Size(83, 35);
			this.btnImportCustom.TabIndex = 15;
			this.btnImportCustom.Text = "Import Plus";
			this.btnImportCustom.Click += new System.EventHandler(this.btnImportCustom_Click);
			// 
			// radPanel1
			// 
			this.radPanel1.Controls.Add(this.dgvUsers);
			this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radPanel1.Location = new System.Drawing.Point(3, 153);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new System.Drawing.Size(741, 352);
			this.radPanel1.TabIndex = 27;
			// 
			// radPanel2
			// 
			this.radPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.radPanel2.Controls.Add(this.txtSearch);
			this.radPanel2.Controls.Add(this.btnImportCustom);
			this.radPanel2.Controls.Add(this.lblUserName);
			this.radPanel2.Controls.Add(this.btnPrint);
			this.radPanel2.Controls.Add(this.btnSearch);
			this.radPanel2.Controls.Add(this.btnImport);
			this.radPanel2.Controls.Add(this.ddlsearch);
			this.radPanel2.Controls.Add(this.btnExport);
			this.radPanel2.Controls.Add(this.btnAdd);
			this.radPanel2.Controls.Add(this.btnDelete);
			this.radPanel2.Location = new System.Drawing.Point(24, 3);
			this.radPanel2.Name = "radPanel2";
			this.radPanel2.Size = new System.Drawing.Size(698, 123);
			this.radPanel2.TabIndex = 28;
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(96, 24);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
			this.txtSearch.Size = new System.Drawing.Size(275, 26);
			this.txtSearch.TabIndex = 15;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.radPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.radPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.radPanel3, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 634);
			this.tableLayoutPanel1.TabIndex = 29;
			// 
			// radPanel3
			// 
			this.radPanel3.Controls.Add(this.lblPages);
			this.radPanel3.Controls.Add(this.radLabel2);
			this.radPanel3.Controls.Add(this.ddlNumRecord);
			this.radPanel3.Controls.Add(this.radLabel1);
			this.radPanel3.Controls.Add(this.btnPrevious);
			this.radPanel3.Controls.Add(this.btnNext);
			this.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radPanel3.Location = new System.Drawing.Point(3, 511);
			this.radPanel3.Name = "radPanel3";
			this.radPanel3.Size = new System.Drawing.Size(741, 120);
			this.radPanel3.TabIndex = 29;
			this.radPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel3_Paint);
			// 
			// ddlNumRecord
			// 
			this.ddlNumRecord.AutoSize = false;
			this.ddlNumRecord.DropDownAnimationEnabled = true;
			this.ddlNumRecord.Location = new System.Drawing.Point(126, 22);
			this.ddlNumRecord.Name = "ddlNumRecord";
			this.ddlNumRecord.Size = new System.Drawing.Size(64, 31);
			this.ddlNumRecord.TabIndex = 4;
			this.ddlNumRecord.Text = "radDropDownList1";
			this.ddlNumRecord.SelectedValueChanged += new System.EventHandler(this.ddlNumRecord_SelectedValueChanged);
			// 
			// radLabel1
			// 
			this.radLabel1.Location = new System.Drawing.Point(38, 27);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new System.Drawing.Size(82, 18);
			this.radLabel1.TabIndex = 3;
			this.radLabel1.Text = "Số Hàng/Trang";
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(386, 21);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(110, 32);
			this.btnPrevious.TabIndex = 1;
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(517, 20);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(110, 32);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = "Next";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// printDocUser
			// 
			this.printDocUser.AssociatedObject = this.dgvUsers;
			this.printDocUser.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printDocUser.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printDocUser.Watermark = radPrintWatermark1;
			// 
			// radLabel2
			// 
			this.radLabel2.AutoSize = false;
			this.radLabel2.Location = new System.Drawing.Point(197, 21);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new System.Drawing.Size(38, 33);
			this.radLabel2.TabIndex = 5;
			this.radLabel2.Text = "Trang";
			// 
			// lblPages
			// 
			this.lblPages.AutoSize = false;
			this.lblPages.Location = new System.Drawing.Point(241, 22);
			this.lblPages.Name = "lblPages";
			this.lblPages.Size = new System.Drawing.Size(122, 33);
			this.lblPages.TabIndex = 6;
			this.lblPages.Text = "text";
			this.lblPages.TextWrap = false;
			// 
			// fUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(747, 671);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "fUsers";
			this.Text = "Users";
			this.Load += new System.EventHandler(this.fUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUserName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ddlsearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnImportCustom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
			this.radPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
			this.radPanel2.ResumeLayout(false);
			this.radPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
			this.radPanel3.ResumeLayout(false);
			this.radPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlNumRecord)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPages)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadButton btnSearch;
		private Telerik.WinControls.UI.RadLabel lblUserName;
		private Telerik.WinControls.UI.RadDropDownList ddlsearch;
		private Telerik.WinControls.UI.RadButton btnAdd;
		private Telerik.WinControls.UI.RadButton btnDelete;
		private Telerik.WinControls.UI.RadButton btnExport;
		private Telerik.WinControls.UI.RadButton btnImport;
		private Telerik.WinControls.UI.RadButton btnPrint;
		private Telerik.WinControls.UI.RadGridView dgvUsers;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Telerik.WinControls.UI.RadButton btnImportCustom;
		private Telerik.WinControls.UI.RadPanel radPanel1;
		private Telerik.WinControls.UI.RadPanel radPanel2;
		private Telerik.WinControls.UI.RadTextBox txtSearch;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Telerik.WinControls.UI.RadPrintDocument printDocUser;
		private Telerik.WinControls.UI.RadPanel radPanel3;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadButton btnPrevious;
		private Telerik.WinControls.UI.RadButton btnNext;
		private Telerik.WinControls.UI.RadDropDownList ddlNumRecord;
		private Telerik.WinControls.UI.RadLabel lblPages;
		private Telerik.WinControls.UI.RadLabel radLabel2;
	}
}