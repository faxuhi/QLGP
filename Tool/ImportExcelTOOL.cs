using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Tool
{
	public class ImportExcelTOOL
	{
		public DataTable ImportExcel(string filepath)
		{

			//string filepath = filepath;
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
			return dt;

		}
		//public void ImportToDatabase(Datatable passToImport, string table)
		//{
		//	UserManagerContext db = new UserManagerContext();

		//	SqlConnection connection = new SqlConnection(db.Database.Connection.ConnectionString);
		//	connection.Open();
		//	using (SqlBulkCopy s = new SqlBulkCopy(connection))
		//	{
		//		//set the table name  
		//		s.DestinationTableName = table;
		//		foreach (var column in passToImport.Columns)
		//			s.ColumnMappings.Add(column.ToString(), column.ToString());
		//		s.WriteToServer(passToImport);
		//	}
		//	connection.Close();
		//}
	}
}
