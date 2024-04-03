using BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static UserManager_Hieu.fUserManager;

namespace UserManager_Hieu
{
	public partial class fLogin : Form
	{
		public bool checkLogin;
		public string currentUser = Properties.Settings.Default.CurrentUser;
		HashPasswordTOOL hashPassword = new HashPasswordTOOL();
		UserBLL userBLL = new UserBLL();
		public SendUserName send;
		public fLogin()
		{
			InitializeComponent();

		}
		public fLogin(SendUserName sender)
		{
			InitializeComponent();
			this.send = sender;
		}
		
		private void ReadSettings()
		{
			if (Properties.Settings.Default.RememberMe == "true")
			{
				txtUserName.Text = Properties.Settings.Default.UserName;
				txtPassword.Text = Properties.Settings.Default.Password;
				chkRememberMe.Checked = true;
			}
			else
			{
				txtUserName.Text = Properties.Settings.Default.UserName; ;
				txtPassword.Text = "";
				chkRememberMe.Checked = false;
			}
		}
		private void SaveHashSettings()
		{
			
			if (chkRememberMe.Checked)
			{
				Properties.Settings.Default.UserName = this.txtUserName.Text;
				Properties.Settings.Default.Password = hashPassword.ComputeSha256Hash(txtPassword.Text);
				Properties.Settings.Default.RememberMe = "true";
				Properties.Settings.Default.Save();
			}
			else
			{
				Properties.Settings.Default.UserName = this.txtUserName.Text;
				Properties.Settings.Default.Password = "";
				Properties.Settings.Default.RememberMe = "false";
				Properties.Settings.Default.Save();
			}
			
		}
		private void SaveCurrentUser()
		{
			Properties.Settings.Default.CurrentUser = txtUserName.Text;
			Properties.Settings.Default.Save();
		}
		private void ResetCurrentUser()
		{
			Properties.Settings.Default.CurrentUser = "";
			Properties.Settings.Default.Save();
		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			var userName = txtUserName.Text;
			var passWordShow = Properties.Settings.Default.Password;
			var soSanh = txtPassword.Text.Equals(passWordShow, StringComparison.OrdinalIgnoreCase);
			if (soSanh == false)
			{

				SaveHashSettings();
				passWordShow = hashPassword.ComputeSha256Hash(txtPassword.Text);
			}

			if (userBLL.CheckLoginBLL(userName, passWordShow) ==true)
			{
				userBLL.UpdateOnlineBLL(userName,true);
				SaveCurrentUser();
				send(txtUserName.Text);
				this.Hide();
			}
			else
			{
				userName = "";
				MessageBox.Show("Đăng Nhập không thành công");
			}
			
		}

		private void fLogin_Load(object sender, EventArgs e)
		{

			ReadSettings();

			if(userBLL.CheckUserOnlineBLL(currentUser) == true)
			{
				btnLogIn.Enabled = false;
				txtUserName.Enabled = false;
				txtPassword.Enabled = false;
				llbSignUp.Enabled = false;
			}
			else
			{
				btnLogOut.Enabled = false;
			}
		}

		private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			fSignUp fSignUp = new fSignUp();
			this.Hide();
			fSignUp.ShowDialog();
			this.Show();
		}
		private void btnLogOut_Click(object sender, EventArgs e)
		{
			userBLL.UpdateOnlineBLL(currentUser, false);
			userBLL.LastLoginBLL(currentUser);
			ResetCurrentUser();
			send(null);
			btnLogIn.Enabled = true;
			txtUserName.Enabled = true;
			txtPassword.Enabled = true;
			btnLogOut.Enabled = false;
			llbSignUp.Enabled = true;
			if(!chkRememberMe.Checked)
			{
			txtPassword.Text = "";
			}
		}

		private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	}
}
