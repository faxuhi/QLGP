using BLL;
//using Microsoft.Office.Interop.Excel;

//using Microsoft.Office.Interop.Excel;

//using Microsoft.Office.Interop.Excel;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
//using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Tool;
using UserManager.Models.EF;
using static UserManager_Hieu.fUsers;

namespace UserManager_Hieu
{
	public partial class fImportUser : Form
	{
		ImportExcelTOOL importExcelTOOL = new ImportExcelTOOL();
		ExportExcelTOOL exportExcelTOOL = new ExportExcelTOOL();
		HashPasswordTOOL hashPassword = new HashPasswordTOOL();
		CheckTOOL checkTool = new CheckTOOL();
		UserBLL userBLL = new UserBLL();
		public SetUserInfoDelegate SetUserInfoCallBack;
		List<string> databaseColumnList = new List<string>()
					{
						"UserName",
						"RoleName",//Có thể bỏ chon 1 dạng - hoặc check value exists  rồi cho import
						"Name",
						"BirthDay",
						"Phone",
						"Email"
					};
		public fImportUser()
		{
			InitializeComponent();
			txtPassword.Text = "123456";
			btnImportToDatabase.Enabled = false;
			btnExport.Enabled = false;
			dgvImport.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
			dgvImport.ReadOnly = true;

		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
			if (op.ShowDialog() == DialogResult.OK)
			{
				string filepath = op.FileName;
				//var time = new FileInfo(filepath).LastWriteTime;
				//var workbook = new Application().Workbooks.Open(filepath, ReadOnly: true);

				//var lastSavedDate = (DateTime)workbook.BuiltinDocumentProperties["Last Save Time"].Value;

				var dt = importExcelTOOL.ImportExcel(filepath);
				var checkCol = false;
				checkCol = checkTool.CheckColumnListInDataTOOL(databaseColumnList, dt);
				if (!checkCol)
				{
					MessageBox.Show("Cột bảng Import còn thiếu cột cần thiết.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				var arrDr = dt.Rows.Cast<DataRow>().Where(row => !row.ItemArray.All(field => field is DBNull || field.Equals(""))).ToList();
				if (arrDr.Count() == 0)
				{
					MessageBox.Show("File không có dữ liệu, cần xem lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					dt = dt.Rows.Cast<DataRow>()
					.Where(row => !row.ItemArray
					.All(field => field is DBNull || string.IsNullOrWhiteSpace(field as string)))
					.CopyToDataTable();
				}
				dgvImport.DataSource = dt;
				btnImportToDatabase.Enabled = true;
			}
		}

		private void btnImportToDatabase_Click(object sender, EventArgs e)
		{
			DataTable dt = dgvImport.DataSource as DataTable;
			DataView view = new DataView(dt);
			DateTime dDate;
			bool importMode = true;
			bool isChecked = rbnGhiDe.IsChecked;//chưa làm vì còn xem xét các cột thêm vào có trùng lặp không
			if (!isChecked)
				importMode = false;
			string passwordAll = hashPassword.ComputeSha256Hash(txtPassword.Text);//


			DataTable table = view.ToTable(false, databaseColumnList.ToArray());//if true will filter only unique row
			table.Columns.Add("Error", typeof(String)).SetOrdinal(1);

			checkTool.CheckDuplicateWriteError(table, "UserName", " Trùng UserName; ");
			checkTool.CheckDuplicateWriteError(table, "Phone", " Trùng Phone; ");
			checkTool.CheckDuplicateWriteError(table, "Email", " Trùng Email; ");

			for (int i = 0; i < table.Rows.Count; i++)
			{

				string chuvasoRegex = @"^[a-zA-Z0-9]*$";
				string vietnamPhoneRegex = @"((^(\+84|84|0|0084){1})(3|5|7|8|9))+([0-9]{8})$";
				string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

				var userName = table.Rows[i]["UserName"].ToString();
				var birthday = table.Rows[i]["Birthday"].ToString();//datetime
				var phone = table.Rows[i]["Phone"].ToString();
				var email = table.Rows[i]["Email"].ToString();

				var checkRegexUserName = checkTool.CheckRegex(userName, chuvasoRegex);
				var checkRegexPhone = checkTool.CheckRegex(phone, vietnamPhoneRegex);
				var checkRegexEmail = checkTool.CheckRegex(email, emailRegex);
				if (DateTime.TryParse(birthday, out dDate) || String.IsNullOrEmpty(birthday))
				{
					var checkRegexBirthday = true;
				}
				else
				{
					var checkRegexBirthday = false;
				}
				if (String.IsNullOrEmpty(userName))
				{
					table.Rows[i]["Error"] = table.Rows[i]["Error"] + "UserName Trống; ";
				}
				if (String.IsNullOrEmpty(phone))
				{
					table.Rows[i]["Error"] = table.Rows[i]["Error"] + "Phone Trống; ";
				}
				if (String.IsNullOrEmpty(email))
				{
					table.Rows[i]["Error"] = table.Rows[i]["Error"] + "Email Trống; ";
				}

				var uniqueUserName = userBLL.CheckUserNameBLL(userName);
				var uniquePhone = 0;
				if (checkRegexPhone)
				{
					uniquePhone = userBLL.CheckChinSoCuoiPhoneBLL(phone);
				}
				var uniqueEmail = userBLL.CheckEmailBLL(email);

				if (!checkRegexUserName || !checkRegexPhone || !checkRegexEmail || uniqueUserName != 0 || uniquePhone != 0 || uniqueEmail != 0)
				{
					if (!checkRegexUserName)
					{
						table.Rows[i]["Error"] = table.Rows[i]["Error"] + "Định Dạng UserName Không Đúng; ";
					}

					if (!checkRegexPhone)
					{
						table.Rows[i]["Error"] = table.Rows[i]["Error"] + "Định Dạng Phone Không Đúng; ";
					}
					if (!checkRegexEmail)
					{
						table.Rows[i]["Error"] = table.Rows[i]["Error"] + "Định Dạng Email Không Đúng; ";
					}
					if (checkRegexUserName && uniqueUserName != 0)
					{
						table.Rows[i]["Error"] = table.Rows[i]["Error"] + "UserName đã đăng ký; ";
					}
					if (checkRegexPhone && uniquePhone != 0)
					{
						table.Rows[i]["Error"] = table.Rows[i]["Error"] + "Số Phone đã đăng ký; ";
					}
					if (checkRegexEmail && uniqueEmail != 0)
					{
						table.Rows[i]["Error"] = table.Rows[i]["Error"] + "Email đã đăng ký; ";
					}
				}
			}
			var errorArray = table.AsEnumerable().Where(r => !r["Error"].ToString().Trim().Equals(String.Empty)).ToArray();
			var passArray = table.AsEnumerable().Where(r => r["Error"].ToString().Trim().Equals(String.Empty)).ToArray();
			DataTable errorToView = table.Clone();
			int rowFails;
			if (errorArray.Count() != 0)
			{
				errorToView = errorArray.CopyToDataTable();
				rowFails = errorToView.Rows.Count;
			}
			else
			{
				rowFails = 0;
			}
			if (passArray.Count() > 0)
			{
				DataTable passToImport = passArray.CopyToDataTable();
				passToImport.Columns.Remove("RoleName");
				passToImport.Columns.Remove("Error");
				passToImport.Columns.Add("RegisteredDate").DefaultValue = DateTime.Now;
				passToImport.Columns.Add("LastLogin").DefaultValue = null;
				passToImport.Columns.Add("Intro").DefaultValue = null;
				passToImport.Columns.Add("RoleId").DefaultValue = null;
				passToImport.Columns.Add("IsOnline").DefaultValue = false;
				passToImport.Columns.Add("PassWord").DefaultValue = hashPassword.ComputeSha256Hash("123456");
				for (int i = 0; i < passToImport.Rows.Count; i++)
				{
					passToImport.Rows[i]["RegisteredDate"] = DateTime.Now;
					passToImport.Rows[i]["LastLogin"] = null;
					passToImport.Rows[i]["Intro"] = "";
					passToImport.Rows[i]["RoleId"] = null;
					passToImport.Rows[i]["IsOnline"] = false;
					passToImport.Rows[i]["PassWord"] = passwordAll;
				}
				UserManagerContext db = new UserManagerContext();
				SqlConnection connection = new SqlConnection(db.Database.Connection.ConnectionString);
				connection.Open();
				using (SqlBulkCopy s = new SqlBulkCopy(connection))
				{
					//set the table name  
					s.DestinationTableName = "[User]";
					foreach (var column in passToImport.Columns)
						s.ColumnMappings.Add(column.ToString(), column.ToString());
					s.WriteToServer(passToImport);
				}
				connection.Close();

				var rowPass = passToImport.Rows.Count;
				if (rowFails != 0)
				{
					MessageBox.Show("Đã import vào database: " + rowPass + "Users; Có " + rowFails + " User bị lỗi, xem lại bản (Export về để Sửa)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("Đã import vào database: " + rowPass + "Users thành công", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Không import được User nào Cần xem lại file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


			dgvImport.DataSource = errorToView;
			btnImportToDatabase.Enabled = false;
			btnExport.Enabled = true;
		}

		private void dgvImport_Click(object sender, EventArgs e)
		{

		}

		private void fImportUser_FormClosing(object sender, FormClosingEventArgs e)
		{
			SetUserInfoCallBack();

		}
	}
}
