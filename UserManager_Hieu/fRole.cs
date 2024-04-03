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
using System.Xml.Linq;
using Telerik.WinControls.Extensions;

namespace UserManager_Hieu
{
	public partial class fRole : Form
	{
		RoleBLL roleBLL = new RoleBLL();
		public fRole()
		{
			InitializeComponent();
		}

		private void btnAddRole_Click(object sender, EventArgs e)
		{
			try
			{
				bool active;
				if (rbtActive.Checked)
				{
					active = true;
				}
				else
                {
					active = false;
				}
                RoleDTO roleDTO = new RoleDTO();
				//roleDTO.Id++;
				roleDTO.Name = txtName.Text;
				roleDTO.Description = rtxDescription.Text;
				roleDTO.Active = active;

				RoleBLL.InsertRoleBLL(roleDTO);
				//frmAdmin.frmAdmin_Load(sender, e);
				MessageBox.Show("Thêm thành công!");
				this.Close();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
	}
}
