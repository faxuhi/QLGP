using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManager_Hieu
{
	public partial class fPermission : Form
	{
		public fPermission()
		{
			InitializeComponent();
		}

		private void btnAddPermission_Click(object sender, EventArgs e)
		{
			try
			{
				PermissionDTO permissionDTO = new PermissionDTO();
				permissionDTO.Name = txtName.Text;
				PermissionBLL.InsertPermissionBLL(permissionDTO);
				MessageBox.Show("Thêm thành công!");
				//this.Close();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
	}
}
