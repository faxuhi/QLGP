using BLL;
using DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Tool;
using UserManager.Models;
using UserManager.Models.EF;
using DataTable = System.Data.DataTable;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
//using DataTable = Microsoft.Office.Interop.Excel.DataTable;

namespace UserManager_Hieu
{
	public partial class fUsers : Form
	{
		string searchText = null;
		object searchOption;// = null;
		int pageNum = 1;
		int pageRecord;//= 10;
		int countRecords;
		int lastPage;
		HashPasswordTOOL hashPassword = new HashPasswordTOOL();
		ExportExcelTOOL exportExcelTOOL = new ExportExcelTOOL();
		public delegate void SetUserInfoDelegate();
		public UserCustomViewETT UserInfor { get; set; }
		UserBLL userBLL = new UserBLL();
		System.Collections.Generic.List<UserCustomViewETT> data;//= userBLL.GetUsersBLL();
		public class ListSearch
		{
			public string Value { get; set; }
			public string Name { get; set; }
		}
		public class NumRecord
		{
			public int Value { get; set; }
			public string Name { get; set; }
		}
		//List<UserCustomViewETT> LoadRecord(int pageNum, int pageRecord)
		//{
		//	List<UserCustomViewETT> result = new List<UserCustomViewETT>();

		//}

		public fUsers(UserCustomViewETT user)
		{
			InitializeComponent();
			UserInfor = user;
		}
		public void ReSetData()
		{
			data = userBLL.GetUsersBLL(null, searchOption);
			dgvUsers.DataSource = data.Skip((pageNum - 1) * pageRecord).Take(pageRecord).ToList();
		}

		public fUsers()
		{
			InitializeComponent();
			var numRecord = new List<NumRecord>() {
				new NumRecord(){ Value = 10, Name="10"},
				new NumRecord(){ Value = 20, Name="20"},
				new NumRecord(){ Value = 50, Name="50"},
				new NumRecord(){ Value = 100, Name="100"},
				new NumRecord(){ Value = 500, Name="500"},
				new NumRecord(){ Value = 1000, Name="1000"}
			};
			ddlNumRecord.DisplayMember = "name";
			ddlNumRecord.ValueMember = "Value";
			ddlNumRecord.DataSource = numRecord;
			//ddlNumRecord.SelectedValue = pageRecord;
			ddlNumRecord.SelectedIndex = 0;
			// pageNum = 1;
			//int  pageRecord = ddlNumRecord.SelectedValue;
			var listSearch = new List<ListSearch>() {
				new ListSearch(){ Value = "All", Name="Tất Cả"},
				new ListSearch(){ Value = "UserName", Name="User Name"},
				new ListSearch(){ Value = "RoleName", Name="Role Name"},
				new ListSearch(){ Value = "Name", Name="Name"},
				new ListSearch(){ Value = "Phone", Name="Phone"},
				new ListSearch(){ Value = "Email", Name="Email"}
			};
			ddlsearch.DisplayMember = "name";
			ddlsearch.ValueMember = "Value";
			ddlsearch.DataSource = listSearch;
			ddlsearch.SelectedValue = "UserName";

			//data = userBLL.GetUsersBLL();
			countRecords = userBLL.CountRecordsBLL();
			var lastPage = (int)Math.Ceiling((double)countRecords / pageRecord);
			lblPages.Text = "1/" + lastPage + " (tổng " + countRecords + " hàng)";

			//ddlsearch.DataSource = LoadRecord(pageNum, pageRecord);
		}

		private void fUsers_Load(object sender, EventArgs e)

		{
			//data = userBLL.GetUsersBLL(pageNum, pageRecord);
			data = userBLL.GetUsersBLL(searchText, searchOption);

			dgvUsers.DataSource = data.Skip((pageNum - 1) * pageRecord).Take(pageRecord).ToList();
			GridViewCheckBoxColumn checkBoxColumn = new GridViewCheckBoxColumn();
			checkBoxColumn.DataType = typeof(int);
			checkBoxColumn.Name = "isSelected";
			checkBoxColumn.FieldName = "isSelected";
			checkBoxColumn.HeaderText = "Select";
			checkBoxColumn.EnableHeaderCheckBox = true;
			dgvUsers.MasterTemplate.Columns.Add(checkBoxColumn);
			dgvUsers.Columns.Move(6, 0);
			GridViewDateTimeColumn dateTimeColumn = dgvUsers.Columns["Birthday"] as GridViewDateTimeColumn;
			dateTimeColumn.Name = "Birthday";
			dateTimeColumn.HeaderText = "Birthday";
			dateTimeColumn.FormatString = "{0:dd/MM/yyyy}";
			dgvUsers.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			fSignUp fSignUp = new fSignUp();
			fSignUp.SetUserInfoCallBack = new SetUserInfoDelegate(this.ReSetData);
			fSignUp.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			dgvUsers.BeginUpdate();
			BindingList<GridViewDataRowInfo> rowsToDelete = new BindingList<GridViewDataRowInfo>();
			foreach (GridViewDataRowInfo row in dgvUsers.Rows)
			{
				if (Convert.ToBoolean(row.Cells["isSelected"].Value) == true)
				{
					if (MessageBox.Show("Bạn chắc chắn xóa User chứ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//lap lai nhieu lan
					{
						rowsToDelete.Add(row);
						var userName = row.Cells["UserName"].Value.ToString();
						UserBLL.DeleteUserBLL(userName);
					}
				}
			}

			while (rowsToDelete.Count > 0)
			{
				dgvUsers.Rows.Remove(rowsToDelete.First());
				rowsToDelete.RemoveAt(0);
			}

			dgvUsers.EndUpdate();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
				exportExcelTOOL.ToExcel(dgvUsers, saveFileDialog1.FileName);
			}

		}


		private void btnSearch_Click(object sender, EventArgs e)
		{
			searchText = txtSearch.Text.ToLower();
			searchOption = ddlsearch.SelectedItem.Value;
			pageNum = 1;
			data = userBLL.GetUsersBLL(searchText, searchOption);
			dgvUsers.DataSource = data.Skip((pageNum - 1) * pageRecord).Take(pageRecord).ToList();
			countRecords = data.Count();
			//int countRecords = userBLL.CountRecordsBLL();
			lastPage = (int)Math.Ceiling((double)countRecords / pageRecord);
			lblPages.Text = pageNum + "/" + lastPage + " (tổng " + countRecords + " hàng)";

		}



		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
			if (op.ShowDialog() == DialogResult.OK)
			{
				string filepath = op.FileName;
				string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}' ";
				con = string.Format(con, filepath, "yes");
				OleDbConnection excelconnection = new OleDbConnection(con);
				excelconnection.Open();
				DataTable dtexcel = excelconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
				string excelsheet = dtexcel.Rows[0]["Table_Name"].ToString();
				OleDbCommand com = new OleDbCommand("Select * from [" + excelsheet + "]", excelconnection);
				OleDbDataAdapter oda = new OleDbDataAdapter(com);
				DataTable dt = new DataTable();
				oda.Fill(dt);

				excelconnection.Close();
				//Console.WriteLine(dt);
				//dgvUsers.DataSource = dt;
				var listcols = new List<string>();
				foreach (DataColumn item in dt.Columns)
				{
					listcols.Add(item.ColumnName);
				}
				DataView view = new DataView(dt);
				//DataTable table1 = view.ToTable(false, listcols.Take(7).ToArray());
				//DataTable table1 = view.ToTable();
				string pw = hashPassword.ComputeSha256Hash("123456");

				DataTable table1 = view.ToTable(false, listcols.Skip(1).Take(6).ToArray());
				table1.Columns.Remove("RoleName");
				table1.Columns.Add("RegisteredDate").DefaultValue = DateTime.Now;
				table1.Columns.Add("LastLogin").DefaultValue = null;
				table1.Columns.Add("Intro").DefaultValue = null;
				table1.Columns.Add("RoleId").DefaultValue = null;
				table1.Columns.Add("IsOnline").DefaultValue = false;
				table1.Columns.Add("PassWord").DefaultValue = hashPassword.ComputeSha256Hash("123456");
				for (int i = 0; i < table1.Rows.Count; i++)
				{

					//var rUserName = table1.Rows[i]["UserName"];
					table1.Rows[i]["RegisteredDate"] = DateTime.Now;
					table1.Rows[i]["LastLogin"] = null;
					table1.Rows[i]["Intro"] = "";
					table1.Rows[i]["RoleId"] = null;
					table1.Rows[i]["IsOnline"] = false;
					table1.Rows[i]["PassWord"] = hashPassword.ComputeSha256Hash("123456");
					//table1.Rows[i]["RegisteredDate"] = DateTime.Now;

				}
				UserManagerContext db = new UserManagerContext();
				SqlConnection connection = new SqlConnection(db.Database.Connection.ConnectionString);
				connection.Open();
				using (SqlBulkCopy s = new SqlBulkCopy(connection))
				{
					//set the table name  
					s.DestinationTableName = "[User]";

					foreach (var column in table1.Columns)
						s.ColumnMappings.Add(column.ToString(), column.ToString());

					s.WriteToServer(table1);
				}
				connection.Close();
			}
		}

		private void btnImportCustom_Click(object sender, EventArgs e)
		{
			fImportUser fImportUser = new fImportUser();
			fImportUser.SetUserInfoCallBack = new SetUserInfoDelegate(this.ReSetData);
			fImportUser.ShowDialog();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			GridPrintStyle style = new GridPrintStyle();
			style.FitWidthMode = PrintFitWidthMode.FitPageWidth;
			style.AlternatingRowColor = Color.AliceBlue;
			style.PrintAlternatingRowColor = true;
			style.BorderColor = Color.Blue;
			dgvUsers.PrintStyle = style;

			RadPrintDocument document = new RadPrintDocument();
			document.HeaderHeight = 50;
			document.HeaderFont = new Font("Arial", 22);
			document.Logo = System.Drawing.Image.FromFile(@"D:\logo hp\hp-blue.png");
			document.LeftHeader = "[Logo]";
			document.MiddleHeader = "Middle header";
			document.RightHeader = "Right header";
			document.ReverseHeaderOnEvenPages = true;
			document.FooterHeight = 40;
			document.FooterFont = new Font("Arial", 22);
			document.LeftFooter = "Left footer";
			document.MiddleFooter = "Middle footer";
			document.RightFooter = "Right footer";
			document.ReverseFooterOnEvenPages = true;
			document.AssociatedObject = this.dgvUsers;
			RadPrintPreviewDialog dialog = new RadPrintPreviewDialog(document);
			dialog.Show();
			//dgvUsers.PrintPreview();
		}

		private void dgvUsers_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
		{
			if (e.Row is GridViewTableHeaderRowInfo)
			{
				e.PrintCell.DrawFill = true;
				e.PrintCell.BackColor = Color.LightBlue;
				e.PrintCell.BorderColor = Color.Blue;
			}
		}

		private void radPanel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			//Console.WriteLine(searchText);

			if (pageNum > 1)
			{
				pageNum--;
				int countRecords = userBLL.CountRecordsBLL();
				var lastPage = (int)Math.Ceiling((double)countRecords / pageRecord);
				lblPages.Text = pageNum + "/" + lastPage + " (tổng " + countRecords + " hàng)";
			}
			data = userBLL.GetUsersBLL(searchText, searchOption);

			dgvUsers.DataSource = data.Skip((pageNum - 1) * pageRecord).Take(pageRecord).ToList();

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			int lastPageRecord = userBLL.GetUsersBLL(pageNum + 1, pageRecord).Count();/// pageRecord;
			if (lastPageRecord > 0)
			{
				pageNum++;
				int countRecords = userBLL.CountRecordsBLL();
				var lastPage = (int)Math.Ceiling((double)countRecords / pageRecord);
				lblPages.Text = pageNum + "/" + lastPage + " (tổng " + countRecords + " hàng)";
			}
			data = userBLL.GetUsersBLL(searchText, searchOption);

			dgvUsers.DataSource = data.Skip((pageNum - 1) * pageRecord).Take(pageRecord).ToList();
		}

		private void txtNumRow_TextChanged(object sender, EventArgs e)
		{

		}

		private void ddlNumRecord_SelectedValueChanged(object sender, EventArgs e)
		{

			bool pageRecord1;// = 10;
			pageRecord1 = Int32.TryParse(ddlNumRecord.SelectedValue.ToString(), out pageRecord);
			pageNum = 1;
			data = userBLL.GetUsersBLL(searchText, searchOption);

			dgvUsers.DataSource = data.Skip((pageNum - 1) * pageRecord).Take(pageRecord).ToList();

			int countRecords = data.Count();
			var lastPage = (int)Math.Ceiling((double)countRecords / pageRecord);
			lblPages.Text = pageNum + "/" + lastPage + " (tổng " + countRecords + " hàng)";

		}
		//string userName = "";
		//var roleName
		public static UserETT user;
		private void dgvUsers_DoubleClick(object sender, EventArgs e)
		{
			var userName = dgvUsers.CurrentRow.Cells["UserName"].Value.ToString();
			var u = userBLL.FindNameBLL(userName);
			var r = dgvUsers.CurrentRow;
			//user = new List<UserETT>();
			user = userBLL.FindNameBLL(userName).First();
			UserEditValidateETT userEditValidateETT = new UserEditValidateETT();
			//fUser.txtUserName.Text = userName;
			fUser fUser = new fUser();
			var birthday = dgvUsers.CurrentRow.Cells["Birthday"].Value;
			var roleName = dgvUsers.CurrentRow.Cells["RoleName"].Value;
			userEditValidateETT.UserName = userName;// dgvUsers.CurrentRow.Cells["UserName"].Value.ToString();
			userEditValidateETT.Phone = dgvUsers.CurrentRow.Cells["Phone"].Value.ToString();
			userEditValidateETT.Name = dgvUsers.CurrentRow.Cells["Name"].Value.ToString();
			if (user.Intro != null)
			{
				userEditValidateETT.Intro = user.Intro;
			}
			userEditValidateETT.Email = dgvUsers.CurrentRow.Cells["Email"].Value.ToString();
			//fUser.ddlRole.Text = dgvUsers.CurrentRow.Cells["RoleName"].Value.ToString();
			if (roleName != null)
			{
				int roleId = (int)user.RoleId;
				userEditValidateETT.RoleId = roleId;
				fUser.ddlRole.SelectedValue = roleId;
			}
			else
			{
				//fUser.ddlRole.NullableValue = null;
				//fUser.ddlRole.SetToNullValue();
				fUser.ddlRole.SelectedIndex = 0;
			}
			if (birthday != null)
			{
				userEditValidateETT.Birthday = Convert.ToDateTime(birthday.ToString());
			}
			else
			{
				fUser.dtpBirthday.NullableValue = null;
				fUser.dtpBirthday.SetToNullValue();
				fUser.dtpBirthday.NullText = "Chưa Ghi";
			}
			fUser.SetUserInfoCallBack = new SetUserInfoDelegate(this.ReSetData);
			fUser.userEditValidateETTBindingSource.DataSource = userEditValidateETT;
			//this.Hide();
			fUser.ShowDialog();
			//this.Show();
		}
	}
}
