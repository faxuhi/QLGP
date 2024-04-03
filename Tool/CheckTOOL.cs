using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Telerik.WinControls;
//using moiExcel = Microsoft.Office.Interop.Excel;


namespace Tool
{
	public class CheckTOOL
	{
		public bool CheckRegex(string inputString, string regex)
		{
			var match = Regex.Match(inputString, regex, RegexOptions.IgnoreCase);
			if (!match.Success) return false;
			return true;

		}
		public bool CheckColumnListInDataTOOL(List<string> sampleList, DataTable importList)
		{
			//return true;
			for (int i = 0; i < sampleList.Count(); i++)
			{
				foreach (DataColumn col in importList.Columns)
				{
					if (col.ColumnName.Equals(sampleList[i], StringComparison.InvariantCultureIgnoreCase)) return true;
				}
			}
			return false;
		}

		public void CheckDuplicateWriteError(DataTable table, string columnName, string errorText)
		{
			var duplicates = table.AsEnumerable().GroupBy(r => r[columnName]).Where(gr => gr.Count() > 1);
			foreach (var group in duplicates)
			{
				foreach (DataRow row in group)
				{
					var newErrorText = row["Error"].ToString() + errorText;
					row.SetField("Error", newErrorText);
				}
			}
		}



	}

}
