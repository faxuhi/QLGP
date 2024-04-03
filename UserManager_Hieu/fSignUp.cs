using BLL;
using DAL.Models.Entities;
using DTO;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Tool;
using static UserManager_Hieu.fUsers;

namespace UserManager_Hieu
{
	public partial class fSignUp : Form
	{
		UserBLL userBLL = new UserBLL();
		HashPasswordTOOL hashPassword = new HashPasswordTOOL();
		public SetUserInfoDelegate SetUserInfoCallBack;
		public fSignUp()
		{
			InitializeComponent();
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

		private void btnOk_Click(object sender, EventArgs e)
		{
			userValidateETTBindingSource.EndEdit();
			UserValidateETT userValidateETT = userValidateETTBindingSource.Current as UserValidateETT;
			if (userValidateETT != null)
			{
				if (userValidateETT.IsValid)
				{
					string checkInfoSignUp = userBLL.CheckInfoSignUp(txtPhone.Text, txtUserName.Text, txtEmail.Text, txtPassword.Text, txtConfirmPassword.Text);
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
						case "confirmPassword":
							MessageBox.Show("Mật khẩu không trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							txtPassword.Focus();
							return;
					}
					try
					{
						UserDTO userDTO = new UserDTO();
						DateTime myDateTime = DateTime.Now;
						userDTO.RoleId = null;
						userDTO.UserName = txtUserName.Text;
						userDTO.PassWord = hashPassword.ComputeSha256Hash(txtPassword.Text);
						userDTO.Name = txtName.Text;
						if (dtpBirthday.NullableValue == null)
						{
							userDTO.Birthday = null;
						}
						else
						{
							userDTO.Birthday = dtpBirthday.Value;
						}
						userDTO.Phone = txtPhone.Text;
						userDTO.Email = txtEmail.Text;
						userDTO.RegisteredDate = myDateTime;// myDateTime;// DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,ffff",  System.Globalization.CultureInfo.InvariantCulture); // myDateTime;
						userDTO.IsOnline = false;
						userDTO.LastLogin = null;
						userDTO.Intro = rtbIntro.Text;

						UserBLL.InsertUserBLL(userDTO);

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

		private void btnOk_Validating(object sender, CancelEventArgs e)
		{
		}

		private void fSignUp_Load(object sender, EventArgs e)
		{
			userValidateETTBindingSource.DataSource = new UserValidateETT();

		}


	}
}
