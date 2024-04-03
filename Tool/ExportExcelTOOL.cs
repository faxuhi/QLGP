using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.Export;
using Telerik.WinControls;
using Microsoft.Office.Interop.Excel;
using Telerik.WinControls.UI;
//using Telerik.WinForms.Documents.Model.StructuredDocumentTags.StructuredDocumentTagProperties;



namespace Tool
{
	public class ExportExcelTOOL
	{
		public void ToExcel(RadGridView dataGridView1, string fileName)
		{
			//khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
			Microsoft.Office.Interop.Excel.Application excel;
			Microsoft.Office.Interop.Excel.Workbook workbook;
			Microsoft.Office.Interop.Excel.Worksheet worksheet;
			try
			{
				//Tạo đối tượng COM.
				excel = new Microsoft.Office.Interop.Excel.Application();
				excel.Visible = false;
				excel.DisplayAlerts = false;
				//tạo mới một Workbooks bằng phương thức add()
				workbook = excel.Workbooks.Add(Type.Missing);
				worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
				//đặt tên cho sheet
				worksheet.Name = "Quản lý Users";

				// export header trong DataGridView
				for (int i = 0; i < dataGridView1.ColumnCount; i++)
				{
					worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
				}
				// export nội dung trong DataGridView
				for (int i = 0; i < dataGridView1.RowCount; i++)
				{

					for (int j = 1; j < dataGridView1.ColumnCount; j++)
					{
						//worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString()??"";
						var cell = dataGridView1.Rows[i].Cells[j].Value;
						if (cell != null)
						{
							worksheet.Cells[i + 2, j + 1] = cell.ToString(); // Why is Value null here??
						}
						else
						{
							worksheet.Cells[i + 2, j + 1] = "";
						}
					}
				}
				worksheet.Columns[6].NumberFormat = "@";//dinh dang phone
														// sử dụng phương thức SaveAs() để lưu workbook với filename
				workbook.SaveAs(fileName);
				//đóng workbook
				workbook.Close();
				excel.Quit();
				MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				workbook = null;
				worksheet = null;
			}
		}
	}
}
