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
using Tool;

namespace UserManager_Hieu
{
	public partial class test : Form
	{
		UserBLL userBLL = new UserBLL();
		HashPasswordTOOL hashPassword = new HashPasswordTOOL();
		public test()
		{
			InitializeComponent();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			try
			{
				UserDTO userDTO = new UserDTO();
				//DateTime myDateTime = DateTime.UtcNow;
				//userDTO.Id = 3;// ++;
				//userDTO.RoleId = 3;
				userDTO.UserName = txtUserName.Text;
				userDTO.PassWord = hashPassword.ComputeSha256Hash(txtPassword.Text);
				userDTO.Name = txtName.Text;
				//	userDTO.Birthday = null;// dtpBirthday.Value;
				userDTO.Phone = txtPhone.Text;
				userDTO.Email = txtEmail.Text;
				//	userDTO.RegisteredDate = null;// myDateTime;// DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,ffff",
				//  System.Globalization.CultureInfo.InvariantCulture); // myDateTime;
				//userDTO.IsOnline = false;
				//userDTO.LastLogin = null;
				//userDTO.Intro = rtbIntro.Text;

				UserBLL.InsertUserBLL(userDTO);
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
