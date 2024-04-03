using BLL;
using DAL.Models.Entities;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UserManager.Models;
using static UserManager_Hieu.fUsers;

namespace UserManager_Hieu
{
	public partial class fUser : Form
	{
		RoleBLL roleBLL = new RoleBLL();
		UserBLL userBLL = new UserBLL();
		public SetUserInfoDelegate SetUserInfoCallBack;
		object roleOption;
		//DateTime defaultDate = Convert.ToDateTime("02/01/0001");

		//List<RoleETT> roleList = new List<RoleETT>();
		List<string> roleList = new List<string>()
					{
						"Id",
						"Name",//Có thể bỏ chon 1 dạng - hoặc check value exists  rồi cho import
					};
		public fUser()
		{
			InitializeComponent();
			var roleList = roleBLL.GetRoleBLL();
			ddlRole.DisplayMember = "Name";
			ddlRole.ValueMember = "Id";
			var all = new RoleETT { Id = 0, Name = "Select", Description = "", Active = true };
			roleList.Insert(0, all);
			ddlRole.DataSource = roleList;

		}
		private void btnAddRole_Click(object sender, EventArgs e)
		{
			fRole fRole = new fRole();
			this.Hide();
			fRole.ShowDialog();
		}

		private void txtEmail_TextChanged(object sender, EventArgs e)
		{

		}

		private void ltlEmail_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			fChangePassword fChangePassword = new fChangePassword();
			this.Hide();
			fChangePassword.ShowDialog();
			this.Show();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;


			userEditValidateETTBindingSource.EndEdit();
			UserEditValidateETT userEditValidateETT = userEditValidateETTBindingSource.Current as UserEditValidateETT;
			if (userEditValidateETT != null)
			{
				//MessageBox.Show("Test", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				if (userEditValidateETT.IsValid)
				{
					string checkInfoSignUp = userBLL.CheckInfoEdit(txtPhone.Text, txtUserName.Text, txtEmail.Text);
					switch (checkInfoSignUp)
					{
						case "userName_da_dangky":
							MessageBox.Show("UserName đã được đăng ký rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							txtUserName.Focus();
							return;
						case "email_da_dangky":
							MessageBox.Show("Email đã được đăng ký rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							txtEmail.Focus();
							return;
						case "phoneNumber_da_dangky":
							MessageBox.Show("Số Điện Thoại đã được đăn ký rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							txtPhone.Focus();
							return;
					}
					try
					{
						UserDTO userDTO = new UserDTO();
						DateTime myDateTime = DateTime.Now;
						//userDTO.Id = 3;// ++;
						roleOption = ddlRole.SelectedItem.Value;
						if (Convert.ToInt32(roleOption) != 0)
						{
							userDTO.RoleId = Convert.ToInt32(roleOption);
						}
						else
						{
							userDTO.RoleId = null;
						}
						userDTO.UserName = txtUserName.Text;
						//	userDTO.PassWord = hashPassword.ComputeSha256Hash(txtPassword.Text);
						DateTime? birthDay = dtpBirthday.Value;
						//DateTime bd = DBNull.Value;
						//	var bd = dtpBirthday;
						userDTO.Name = txtFullName.Text;
						//DateTime? birthDay = RadDateTimePickerBegin.SelectedDate;

						//if (selected.HasValue)
						//{
						//	startDateTime = selected.Value;
						//}
						//if (dtpBirthday.Value == null)
						//{
						//	dtpBirthday.Value = DBNull.Value;
						//}
						//else
						//{

						//}
						//userDTO.Birthday = (birthDay == null) ?  : Convert.ToDateTime(birthDay);
						if (dtpBirthday.NullableValue == null)
						{
							userDTO.Birthday = null;
						}
						else
						{
							userDTO.Birthday = birthDay;
						}
						userDTO.Phone = txtPhone.Text;
						userDTO.Email = txtEmail.Text;
						//userDTO.RegisteredDate = myDateTime;// myDateTime;// DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,ffff",  System.Globalization.CultureInfo.InvariantCulture); // myDateTime;
						//userDTO.IsOnline = false;
						//userDTO.LastLogin = null;
						userDTO.Intro = txtIntro.Text;

						userBLL.UpdateUserBLL(userDTO);
						var user = userBLL.FindNameBLL(userName).First();
						SetUserInfoCallBack();
						this.Close();

					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.Message);
					}

				}

			}
		}

		private void fUser_Load(object sender, EventArgs e)
		{

		}
	}
}
